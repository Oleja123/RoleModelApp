namespace Forms
{
    partial class CodePhraseForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtCodePhrase;
        private System.Windows.Forms.Button btnOk;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtCodePhrase = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(20, 20);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(145, 13);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Введите кодовую фразу:";
            // 
            // txtCodePhrase
            // 
            this.txtCodePhrase.Location = new System.Drawing.Point(20, 50);
            this.txtCodePhrase.Name = "txtCodePhrase";
            this.txtCodePhrase.Size = new System.Drawing.Size(340, 20);
            this.txtCodePhrase.TabIndex = 1;
            this.txtCodePhrase.UseSystemPasswordChar = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(140, 90);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // CodePhraseForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtCodePhrase);
            this.Controls.Add(this.lblPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodePhraseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка кодовой фразы";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }

}