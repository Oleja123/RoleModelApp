using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

public class UserService
{
    private readonly InMemoryDb _db;

    public UserService(InMemoryDb db)
    {
        _db = db;
    }
    public User AddUser(string username)
    {
        if (_db.Context.Users.Any(u => u.Username == username))
            throw new InvalidOperationException("Пользователь с таким именем уже существует.");

        var salt = Guid.NewGuid().ToString();

        var user = new User
        {
            Username = username,
            PasswordHash = "",
            Salt = salt,
            RequireLetter = false,
            RequirePunctuation = false,
            MinPasswordLength = 0,
        };

        _db.Context.Users.Add(user);
        _db.Context.SaveChanges();

        return user;
    }

    public List<User> GetAllUsers()
    {
        return _db.Context.Users.ToList();
    }

    public void SetBlocked(string username, bool blocked)
    {
        var user = _db.Context.Users.FirstOrDefault(u => u.Username == username);
        if (user == null) throw new InvalidOperationException("Пользователь не найден.");

        user.IsBlocked = blocked;
        _db.Context.SaveChanges();
    }

    public void ChangePassword(string username, string newPassword)
    {
        var user = _db.Context.Users.FirstOrDefault(u => u.Username == username);
        if (user == null) throw new InvalidOperationException("Пользователь не найден.");

        if (!ValidatePassword(newPassword, user, out string? reason))
            throw new InvalidOperationException($"Пароль не соответствует ограничениям: {reason}");

        user.PasswordHash = ComputeMD5Hash(newPassword, user.Salt);
        user.PasswordSetUtc = DateTime.UtcNow;
        _db.Context.SaveChanges();
    }

    public bool VerifyPassword(string username, string password)
    {
        var user = _db.Context.Users.FirstOrDefault(u => u.Username == username);
        if (user == null || user.IsBlocked) return false;

        var hash = ComputeMD5Hash(password, user.Salt);
        return hash == user.PasswordHash;
    }

    private static string ComputeMD5Hash(string password, string salt)
    {
        using var md5 = MD5.Create();
        var input = Encoding.UTF8.GetBytes(password + salt);
        var hashBytes = md5.ComputeHash(input);
        return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
    }

    private static bool ValidatePassword(string password, User user, out string? reason)
    {
        reason = null;

        if (password.Length < user.MinPasswordLength)
        {
            reason = $"Минимальная длина пароля — {user.MinPasswordLength}";
            return false;
        }
        if (user.RequireLetter && !password.Any(char.IsLetter))
        {
            reason = "Пароль должен содержать хотя бы одну букву";
            return false;
        }
        if (user.RequirePunctuation && !password.Any(char.IsPunctuation))
        {
            reason = "Пароль должен содержать хотя бы один символ пунктуации";
            return false;
        }

        return true;
    }
}
