using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

public class InMemoryDb : IDisposable
{
    private readonly string _filePath;
    private readonly byte[] _key;
    private readonly byte[] _iv;

    private SqliteConnection _connection;

    public AuthDbContext Context { get; private set; }

    public InMemoryDb(string filePath, byte[] key, byte[] iv)
    {
        _filePath = filePath;
        _key = key;
        _iv = iv;

        LoadDatabaseIntoMemory();
    }

    private void LoadDatabaseIntoMemory()
    {
        byte[] dbBytes = File.Exists(_filePath) ? File.ReadAllBytes(_filePath) : Array.Empty<byte>();
        byte[]? decryptedBytes = dbBytes.Length > 0 ? FileCrypto.Decrypt(dbBytes, _key, _iv) : null;

        _connection = new SqliteConnection("Data Source=:memory:");
        _connection.Open();

        var options = new DbContextOptionsBuilder<AuthDbContext>()
            .UseSqlite(_connection)
            .Options;

        Context = new AuthDbContext(options);

        Context.Database.EnsureCreated();

        if (decryptedBytes != null && decryptedBytes.Length > 0)
        {
            string tempFile = Path.GetTempFileName();
            try
            {
                File.WriteAllBytes(tempFile, decryptedBytes);

                using var sourceConn = new SqliteConnection($"Data Source={tempFile}");
                sourceConn.Open();
                sourceConn.BackupDatabase(_connection);
                sourceConn.Close();
                SqliteConnection.ClearPool(sourceConn);
                sourceConn.Dispose();
                if(Context.Users.ToList().Count == 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ошибка при загрузке бд в память");
            }
            finally
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }
        else
        {
            var salt = Guid.NewGuid().ToString();

            var user = new User
            {
                Username = "ADMIN",
                PasswordHash = "",
                Salt = salt,
                RequireLetter = false,
                RequirePunctuation = false,
                MinPasswordLength = 0,
            };

            Context.Users.Add(user);
            Context.SaveChanges();
        }
    }

    public void SaveAndEncrypt()
    {
        Context.SaveChanges();

        string tempFile = Path.GetTempFileName();
        try
        {
            var fileConn = new SqliteConnection($"Data Source={tempFile}");
            fileConn.Open();
            _connection.BackupDatabase(fileConn);

            fileConn.Close();
            SqliteConnection.ClearPool(fileConn);
            fileConn.Dispose();

            byte[] dbBytes = File.ReadAllBytes(tempFile);
            byte[] encryptedBytes = FileCrypto.Encrypt(dbBytes, _key, _iv);

            File.WriteAllBytes(_filePath, encryptedBytes);
        }
        catch (Exception)
        {
            throw new Exception("Не удалось сохранить данные");
        }
        finally
        {
            if (File.Exists(tempFile))
                File.Delete(tempFile);
        }
    }

    public void Dispose()
    {
        SaveAndEncrypt();
        _connection?.Dispose();
        Context?.Dispose();
    }
}

