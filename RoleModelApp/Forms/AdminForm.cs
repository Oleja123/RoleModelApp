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
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, bool isPassword = true)
        {
            using (Form prompt = new Form())
            {
                prompt.Text = caption;
                prompt.StartPosition = FormStartPosition.CenterScreen;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.MinimizeBox = false;
                prompt.MaximizeBox = false;
                prompt.AutoSize = true;
                prompt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                prompt.Padding = new Padding(10);

                Label lblText = new Label()
                {
                    Text = text,
                    AutoSize = true,
                    MaximumSize = new Size(400, 0)
                };
                lblText.Font = new Font(SystemFonts.MessageBoxFont.FontFamily, 10);

                TextBox txtInput = new TextBox()
                {
                    Width = 350,
                    Anchor = AnchorStyles.Left | AnchorStyles.Right
                };
                if (isPassword)
                    txtInput.UseSystemPasswordChar = true;

                Button btnOk = new Button()
                {
                    Text = "OK",
                    DialogResult = DialogResult.OK,
                    AutoSize = true,
                    Anchor = AnchorStyles.Right
                };

                FlowLayoutPanel panel = new FlowLayoutPanel()
                {
                    FlowDirection = FlowDirection.TopDown,
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    WrapContents = false
                };

                panel.Controls.Add(lblText);
                panel.Controls.Add(txtInput);
                panel.Controls.Add(btnOk);

                prompt.Controls.Add(panel);
                prompt.AcceptButton = btnOk;

                return prompt.ShowDialog() == DialogResult.OK ? txtInput.Text : "";
            }
        }
    }

    public partial class AdminForm : Form
    {
        private readonly UserService _userService;

        public AdminForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = _userService.GetAllUsers();

            dataGridViewUsers.DataSource = users;

            foreach (DataGridViewColumn col in dataGridViewUsers.Columns)
                col.ReadOnly = true;

            dataGridViewUsers.ReadOnly = false;

            dataGridViewUsers.Columns["Username"].ReadOnly = true;
            dataGridViewUsers.Columns["PasswordHash"].ReadOnly = true;
            dataGridViewUsers.Columns["Salt"].ReadOnly = true;
            dataGridViewUsers.Columns["PasswordSetUtc"].ReadOnly = true;
            dataGridViewUsers.Columns["IsBlocked"].ReadOnly = false;
            dataGridViewUsers.Columns["RequireLetter"].ReadOnly = false;
            dataGridViewUsers.Columns["RequirePunctuation"].ReadOnly = false;
            dataGridViewUsers.Columns["MinPasswordLength"].ReadOnly = false;
            dataGridViewUsers.Columns["PasswordExpiryMonths"].ReadOnly = false;
            dataGridViewUsers.Columns["IsAdmin"].Visible = false;
            dataGridViewUsers.Columns["PasswordExpired"].Visible = false;


            dataGridViewUsers.Columns["Username"].HeaderText = "Имя пользователя";
            dataGridViewUsers.Columns["PasswordHash"].HeaderText = "Хэш пароля";
            dataGridViewUsers.Columns["Salt"].HeaderText = "Соль";
            dataGridViewUsers.Columns["PasswordSetUtc"].HeaderText = "Дата обновления пароля";
            dataGridViewUsers.Columns["IsBlocked"].HeaderText = "Заблокирован";
            dataGridViewUsers.Columns["RequireLetter"].HeaderText = "Требовать букву";
            dataGridViewUsers.Columns["RequirePunctuation"].HeaderText = "Требовать пунктуацию";
            dataGridViewUsers.Columns["MinPasswordLength"].HeaderText = "Мин. длина пароля";
            dataGridViewUsers.Columns["PasswordExpiryMonths"].HeaderText = "Срок действия (мес)";
            dataGridViewUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dataGridViewUsers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (!(dataGridViewUsers.CurrentCell is DataGridViewCheckBoxCell) || !dataGridViewUsers.IsCurrentCellDirty)
                return;

            var cell = dataGridViewUsers.CurrentCell;
            if (cell.OwningColumn.Name == "IsBlocked")
            {
                var row = dataGridViewUsers.Rows[cell.RowIndex];
                var username = row.Cells["Username"].Value?.ToString();

                if (string.Equals(username, "ADMIN", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Блокировка администратора запрещена.",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    dataGridViewUsers.CancelEdit();
                    return;
                }
            }

            dataGridViewUsers.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewUsers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridViewUsers.Rows[e.RowIndex];
            string username = row.Cells["Username"].Value.ToString();

            try
            {
                var user = _userService.GetAllUsers().First(u => u.Username == username);

                bool isBlocked = Convert.ToBoolean(row.Cells["IsBlocked"].Value);
                bool requireLetter = Convert.ToBoolean(row.Cells["RequireLetter"].Value);
                bool requirePunctuation = Convert.ToBoolean(row.Cells["RequirePunctuation"].Value);
                int minLength = Convert.ToInt32(row.Cells["MinPasswordLength"].Value);
                int expiryMonths = Convert.ToInt32(row.Cells["PasswordExpiryMonths"].Value);

                _userService.UpdateUser(user, isBlocked, requireLetter, requirePunctuation, minLength, expiryMonths);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении параметров: {ex.Message}");
                LoadUsers(); // откат при ошибке
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadUsers();
        private void btnMoveTop_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.Rows.Count > 0)
                dataGridViewUsers.FirstDisplayedScrollingRowIndex = 0;
        }

        private void btnMoveBottom_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.Rows.Count > 0)
                dataGridViewUsers.FirstDisplayedScrollingRowIndex = dataGridViewUsers.Rows.Count - 1;
        }

        private void BtnChangeAdminPassword_Click(object sender, EventArgs e)
        {
            var adminUser = _userService.GetAllUsers().FirstOrDefault(u => u.IsAdmin);
            if (adminUser == null)
            {
                MessageBox.Show("Пользователь ADMIN не найден.");
                return;
            }

            string oldPassword = Prompt.ShowDialog("Введите старый пароль ADMIN:", "Смена пароля");
            if (string.IsNullOrWhiteSpace(oldPassword)) return;

            if (!_userService.VerifyPassword(adminUser.Username, oldPassword))
            {
                MessageBox.Show("Старый пароль введён неверно.");
                return;
            }

            while (true)
            {
                string newPassword = Prompt.ShowDialog("Введите новый пароль для ADMIN:", "Смена пароля");
                if (string.IsNullOrWhiteSpace(newPassword)) return;

                string confirmPassword = Prompt.ShowDialog("Повторите пароль:", "Смена пароля");
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Пароли не совпадают. Попробуйте ещё раз.");
                    continue;
                }

                try
                {
                    _userService.ChangePassword(adminUser.Username, newPassword);
                    MessageBox.Show("Пароль администратора успешно изменён.");
                    break;
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show($"Пароль не соответствует ограничениям: {ex.Message}");
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя.");
                return;
            }

            string username = dataGridViewUsers.SelectedRows[0].Cells["Username"].Value.ToString();
            var user = _userService.GetAllUsers().First(u => u.Username == username);

            using (var form = new EditUserForm(_userService, user))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    LoadUsers();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = Prompt.ShowDialog("Введите имя нового пользователя:", "Новый пользователь", false);

            if (string.IsNullOrWhiteSpace(username))
                return;

            try
            {
                _userService.AddUser(username.Trim());
                MessageBox.Show($"Пользователь '{username}' успешно добавлен с пустым паролем.");
                LoadUsers();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}