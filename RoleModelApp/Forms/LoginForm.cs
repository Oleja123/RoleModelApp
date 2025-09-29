using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;
        private int _failedAttempts = 0;
        public User LoggedInUser { get; private set; }

        public LoginForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Введите имя пользователя");
                return;
            }

            var user = _userService.GetAllUsers().FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }

            if (user.IsBlocked)
            {
                MessageBox.Show("Учётная запись заблокирована");
                return;
            }

            if (string.IsNullOrEmpty(user.PasswordHash))
            {
                if (!SetNewPassword(user))
                    return;
            }
            else
            {
                if (!_userService.VerifyPassword(username, password))
                {
                    _failedAttempts++;
                    MessageBox.Show("Неверный пароль");

                    if (_failedAttempts >= 3)
                    {
                        MessageBox.Show("Превышено количество попыток входа. Программа будет закрыта.",
                            "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Application.Exit();
                    }
                    return;
                }
                else
                {
                    _failedAttempts = 0;
                    string? res;
                    if ((user.PasswordExpired || !UserService.ValidatePassword(password, user, out res)) && !SetNewPassword(user))
                        return;
                }
            }

            LoggedInUser = user;
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool SetNewPassword(User user)
        {
            using var dlg = new SetPasswordForm();
            if (dlg.ShowDialog() != DialogResult.OK)
                return false;

            string newPassword = dlg.Password;
            string confirmPassword = dlg.ConfirmPassword;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }

            try
            {
                _userService.ChangePassword(user.Username, newPassword);
                MessageBox.Show("Пароль успешно установлен");
                return true;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
