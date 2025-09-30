namespace Forms
{
    partial class SetPasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirm = new Label();
            txtConfirmPassword = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(18, 19);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(88, 15);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Новый пароль";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPassword.Location = new Point(131, 19);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(176, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(18, 56);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(94, 15);
            lblConfirm.TabIndex = 2;
            lblConfirm.Text = "Подтверждение";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtConfirmPassword.Location = new Point(131, 56);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(176, 23);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(131, 94);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(79, 28);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(228, 94);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(79, 28);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 141);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblConfirm);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Установка пароля";
            ResumeLayout(false);
            PerformLayout();
        }
    }


}