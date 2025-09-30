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
            btnChangePassword = new Button();
            btnExit = new Button();
            TableLayoutPanel layout = new TableLayoutPanel();

            SuspendLayout();

            // 
            // layout
            // 
            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 1;
            layout.RowCount = 3;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F)); // верхний отступ
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));     // кнопка смены пароля
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));     // кнопка выхода
            layout.Padding = new Padding(20);
            layout.AutoSize = true;
            layout.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // 
            // btnChangePassword
            // 
            btnChangePassword.Text = "Сменить пароль";
            btnChangePassword.AutoSize = true;
            btnChangePassword.Anchor = AnchorStyles.None;
            btnChangePassword.Padding = new Padding(10, 5, 10, 5);
            btnChangePassword.Click += btnChangePassword_Click;

            // 
            // btnExit
            // 
            btnExit.Text = "Выход";
            btnExit.AutoSize = true;
            btnExit.Anchor = AnchorStyles.None;
            btnExit.Padding = new Padding(10, 5, 10, 5);
            btnExit.Click += btnExit_Click;

            // добавляем кнопки в layout
            layout.Controls.Add(btnChangePassword, 0, 1);
            layout.Controls.Add(btnExit, 0, 2);

            // 
            // UserForm
            // 
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(300, 200);
            Controls.Add(layout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пользователь";

            ResumeLayout(false);
        }

    }
}
