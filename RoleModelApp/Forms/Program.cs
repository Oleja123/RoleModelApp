using Services.Utils;
using System.ComponentModel.DataAnnotations;

namespace Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var (key, iv) = KeyStorage.LoadKeyIv("key_iv.dat");
            InMemoryDb inMemoryDb = new InMemoryDb("auth_encrypted.db", key, iv);
            UserService userService = new UserService(inMemoryDb);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var codeForm = new CodePhraseForm())
            {
                codeForm.ShowDialog();
                if (!codeForm.IsVerified)
                    return;
            }

            using (var loginForm = new LoginForm(userService))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    var user = loginForm.LoggedInUser;

                    if (user.IsAdmin)
                    {
                        using (var adminForm = new AdminForm(userService))
                        {
                            adminForm.ShowDialog();
                        }
                    }
                    else
                    {
                        using (var userForm = new UserForm(userService, user))
                        {
                            userForm.ShowDialog();
                        }
                    }
                }
            }
            inMemoryDb.Dispose();
        }
    }
}