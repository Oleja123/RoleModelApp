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
    public partial class EditUserForm : Form
    {
        private readonly UserService _userService;
        private readonly User _user;

        public EditUserForm(UserService userService, User user)
        {
            InitializeComponent();

            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _user = user ?? throw new ArgumentNullException(nameof(user));

            txtUsername.Text = _user.Username;
            txtPasswordHash.Text = _user.PasswordHash;
            txtSalt.Text = _user.Salt;
            txtPasswordSetUtc.Text = _user.PasswordSetUtc?.ToString("u") ?? "(не установлено)";
            chkIsAdmin.Checked = _user.IsAdmin;

            chkBlocked.Checked = _user.IsBlocked;
            chkRequireLetter.Checked = _user.RequireLetter;
            chkRequirePunctuation.Checked = _user.RequirePunctuation;
            numMinLength.Value = Math.Max(numMinLength.Minimum, Math.Min(numMinLength.Maximum, _user.MinPasswordLength));
            numExpiry.Value = Math.Max(numExpiry.Minimum, Math.Min(numExpiry.Maximum, _user.PasswordExpiryMonths));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                bool isBlocked = chkBlocked.Checked;
                bool requireLetter = chkRequireLetter.Checked;
                bool requirePunctuation = chkRequirePunctuation.Checked;
                int minPasswordLength = (int)numMinLength.Value;
                int passwordExpiryMonths = (int)numExpiry.Value;

                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Имя пользователя не может быть пустым.");
                    return;
                }

                _userService.UpdateUser(
                    _user,
                    isBlocked,
                    requireLetter,
                    requirePunctuation,
                    minPasswordLength,
                    passwordExpiryMonths
                );

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении пользователя: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
