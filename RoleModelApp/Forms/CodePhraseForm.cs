using System;
using System.Windows.Forms;
using Models;

namespace Forms
{
    public partial class CodePhraseForm : Form
    {
        public bool IsVerified { get; private set; } = false;

        public CodePhraseForm()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (txtCodePhrase.Text == Key.Value)
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
