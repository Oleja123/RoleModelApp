namespace Forms
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnChangePassword;
        private Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // btnChangePassword
            this.btnChangePassword.Location = new System.Drawing.Point(30, 30);
            this.btnChangePassword.Size = new System.Drawing.Size(200, 40);
            this.btnChangePassword.Text = "Сменить пароль";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(30, 80);
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.Text = "Выход";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // UserForm
            this.ClientSize = new System.Drawing.Size(260, 180);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователь";
            this.ResumeLayout(false);
        }
    }
}
