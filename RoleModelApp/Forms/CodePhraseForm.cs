using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class CodePhraseForm : Form
    {
        private readonly string _expectedCodePhrase = "Россия вперед";
        private TextBox txtCodePhrase;
        private Button btnOk;
        private Label lblPrompt;

        public bool IsVerified { get; private set; } = false;

        public CodePhraseForm()
        {
            this.Text = "Проверка кодовой фразы";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new System.Drawing.Size(400, 150);

            lblPrompt = new Label()
            {
                Text = "Введите кодовую фразу:",
                Left = 20,
                Top = 20,
                AutoSize = true
            };

            txtCodePhrase = new TextBox()
            {
                Left = 20,
                Top = 50,
                Width = 340,
                UseSystemPasswordChar = true
            };

            btnOk = new Button()
            {
                Text = "OK",
                Left = 140,
                Top = 90,
                Width = 100
            };

            btnOk.Click += BtnOk_Click;

            this.Controls.Add(lblPrompt);
            this.Controls.Add(txtCodePhrase);
            this.Controls.Add(btnOk);

            this.AcceptButton = btnOk;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (txtCodePhrase.Text == _expectedCodePhrase)
            {
                IsVerified = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Кодовая фраза неверна. Приложение будет закрыто.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
