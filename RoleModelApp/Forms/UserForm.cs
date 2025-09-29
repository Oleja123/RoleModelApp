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
    public partial class UserForm : Form
    {
        private readonly UserService _userService;
        private readonly User _loggedInUser;

        public UserForm(UserService userService, User loggedUser)
        {
            InitializeComponent();
            _userService = userService;
            _loggedInUser = loggedUser;

            InitializeMenu();
        }

        private void InitializeMenu()
        {
            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem fileMenu = new ToolStripMenuItem("Файл");

            ToolStripMenuItem changePasswordItem = new ToolStripMenuItem("Сменить пароль");
            changePasswordItem.Click += btnChangePassword_Click;

            ToolStripMenuItem exitItem = new ToolStripMenuItem("Выход");
            exitItem.Click += btnExit_Click;

            fileMenu.DropDownItems.Add(changePasswordItem);
            fileMenu.DropDownItems.Add(new ToolStripSeparator());
            fileMenu.DropDownItems.Add(exitItem);

            ToolStripMenuItem helpMenu = new ToolStripMenuItem("Справка");

            ToolStripMenuItem aboutItem = new ToolStripMenuItem("О программе");
            aboutItem.Click += AboutItem_Click;

            helpMenu.DropDownItems.Add(aboutItem);

            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(helpMenu);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private void AboutItem_Click(object sender, EventArgs e)
        {
            string info = "Салин Олег Алексеевич\n" +
                          "Группа: ПИбд-43\n" +
                          "Ограничения на выбираемые пароли: 20. Наличие букв и знаков препинания.\n" +
                          "Используемый режим шифрования алгоритма DES для шифрования файла: OFB\n" +
                          "Добавление к ключу случайного значения: Нет\n" +
                          "Используемый алгоритм хеширования пароля: MD5";

            MessageBox.Show(info, "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            while (true)
            {
                string oldPassword = Prompt.ShowDialog("Введите текущий пароль:", "Смена пароля");
                if (string.IsNullOrWhiteSpace(oldPassword)) return;

                if (!_userService.VerifyPassword(_loggedInUser.Username, oldPassword))
                {
                    MessageBox.Show("Старый пароль введён неверно.");
                    continue;
                }

                string newPassword = Prompt.ShowDialog("Введите новый пароль:", "Смена пароля");
                if (string.IsNullOrWhiteSpace(newPassword)) return;

                string confirmPassword = Prompt.ShowDialog("Повторите новый пароль:", "Смена пароля");
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Пароли не совпадают. Попробуйте ещё раз.");
                    continue;
                }

                try
                {
                    _userService.ChangePassword(_loggedInUser.Username, newPassword);
                    MessageBox.Show("Пароль успешно изменён.");
                    break;
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show($"Пароль не соответствует ограничениям: {ex.Message}");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}