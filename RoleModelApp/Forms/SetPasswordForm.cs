using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class SetPasswordForm : Form
    {
        public string Password => txtPassword.Text;
        public string ConfirmPassword => txtConfirmPassword.Text;

        public SetPasswordForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Введите пароль и его подтверждение");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}