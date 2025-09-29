namespace Forms
{
    partial class EditUserForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.Label lblPasswordHash;
        private System.Windows.Forms.TextBox txtPasswordHash;

        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.TextBox txtSalt;

        private System.Windows.Forms.Label lblPasswordSet;
        private System.Windows.Forms.TextBox txtPasswordSetUtc;

        private System.Windows.Forms.Label lblIsAdmin;
        private System.Windows.Forms.CheckBox chkIsAdmin;

        private System.Windows.Forms.CheckBox chkBlocked;
        private System.Windows.Forms.CheckBox chkRequireLetter;
        private System.Windows.Forms.CheckBox chkRequirePunctuation;

        private System.Windows.Forms.Label lblMinLength;
        private System.Windows.Forms.NumericUpDown numMinLength;

        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.NumericUpDown numExpiry;

        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnSave;
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();

            this.lblPasswordHash = new System.Windows.Forms.Label();
            this.txtPasswordHash = new System.Windows.Forms.TextBox();

            this.lblSalt = new System.Windows.Forms.Label();
            this.txtSalt = new System.Windows.Forms.TextBox();

            this.lblPasswordSet = new System.Windows.Forms.Label();
            this.txtPasswordSetUtc = new System.Windows.Forms.TextBox();

            this.lblIsAdmin = new System.Windows.Forms.Label();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();

            this.chkBlocked = new System.Windows.Forms.CheckBox();
            this.chkRequireLetter = new System.Windows.Forms.CheckBox();
            this.chkRequirePunctuation = new System.Windows.Forms.CheckBox();

            this.lblMinLength = new System.Windows.Forms.Label();
            this.numMinLength = new System.Windows.Forms.NumericUpDown();

            this.lblExpiry = new System.Windows.Forms.Label();
            this.numExpiry = new System.Windows.Forms.NumericUpDown();

            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numMinLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpiry)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // tableLayoutPanel
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F)); // labels column
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F)); // controls column
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // We'll have 10 rows:
            this.tableLayoutPanel.RowCount = 10;
            for (int i = 0; i < 10; i++)
                this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.Size = new System.Drawing.Size(560, 320);
            this.tableLayoutPanel.TabIndex = 0;

            // lblUsername
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Text = "Имя пользователя:";
            this.lblUsername.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.lblUsername, 0, 0);

            // txtUsername (readonly)
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(360, 22);
            this.tableLayoutPanel.Controls.Add(this.txtUsername, 1, 0);

            // lblPasswordHash
            this.lblPasswordHash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPasswordHash.AutoSize = true;
            this.lblPasswordHash.Text = "Хеш пароля:";
            this.lblPasswordHash.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.lblPasswordHash, 0, 1);

            // txtPasswordHash (readonly, multiline)
            this.txtPasswordHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPasswordHash.ReadOnly = true;
            this.txtPasswordHash.Multiline = true;
            this.txtPasswordHash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPasswordHash.Name = "txtPasswordHash";
            this.txtPasswordHash.Height = 40;
            this.tableLayoutPanel.Controls.Add(this.txtPasswordHash, 1, 1);

            // lblSalt
            this.lblSalt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSalt.AutoSize = true;
            this.lblSalt.Text = "Salt:";
            this.lblSalt.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.lblSalt, 0, 2);

            // txtSalt (readonly)
            this.txtSalt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalt.ReadOnly = true;
            this.txtSalt.Name = "txtSalt";
            this.tableLayoutPanel.Controls.Add(this.txtSalt, 1, 2);

            // lblPasswordSet
            this.lblPasswordSet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPasswordSet.AutoSize = true;
            this.lblPasswordSet.Text = "Дата установки пароля (UTC):";
            this.lblPasswordSet.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.lblPasswordSet, 0, 3);

            // txtPasswordSetUtc (readonly)
            this.txtPasswordSetUtc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPasswordSetUtc.ReadOnly = true;
            this.txtPasswordSetUtc.Name = "txtPasswordSetUtc";
            this.tableLayoutPanel.Controls.Add(this.txtPasswordSetUtc, 1, 3);

            // lblIsAdmin
            this.lblIsAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIsAdmin.AutoSize = true;
            this.lblIsAdmin.Text = "Администратор:";
            this.lblIsAdmin.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.lblIsAdmin, 0, 4);

            // chkIsAdmin (readonly/disabled)
            this.chkIsAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIsAdmin.Enabled = false;
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.tableLayoutPanel.Controls.Add(this.chkIsAdmin, 1, 4);

            // chkBlocked (editable)
            // Place label implicit in control: add a label and checkbox in two cells
            var lblBlocked = new System.Windows.Forms.Label() { AutoSize = true, Text = "Заблокирован:", Anchor = System.Windows.Forms.AnchorStyles.Left, Margin = new System.Windows.Forms.Padding(3, 8, 3, 3) };
            this.tableLayoutPanel.Controls.Add(lblBlocked, 0, 5);
            this.chkBlocked.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBlocked.Name = "chkBlocked";
            this.tableLayoutPanel.Controls.Add(this.chkBlocked, 1, 5);

            // chkRequireLetter
            var lblReqLetter = new System.Windows.Forms.Label() { AutoSize = true, Text = "Требовать букву:", Anchor = System.Windows.Forms.AnchorStyles.Left, Margin = new System.Windows.Forms.Padding(3, 8, 3, 3) };
            this.tableLayoutPanel.Controls.Add(lblReqLetter, 0, 6);
            this.chkRequireLetter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRequireLetter.Name = "chkRequireLetter";
            this.tableLayoutPanel.Controls.Add(this.chkRequireLetter, 1, 6);

            // chkRequirePunctuation
            var lblReqPunct = new System.Windows.Forms.Label() { AutoSize = true, Text = "Требовать пунктуацию:", Anchor = System.Windows.Forms.AnchorStyles.Left, Margin = new System.Windows.Forms.Padding(3, 8, 3, 3) };
            this.tableLayoutPanel.Controls.Add(lblReqPunct, 0, 7);
            this.chkRequirePunctuation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRequirePunctuation.Name = "chkRequirePunctuation";
            this.tableLayoutPanel.Controls.Add(this.chkRequirePunctuation, 1, 7);

            // Min length
            this.lblMinLength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMinLength.AutoSize = true;
            this.lblMinLength.Text = "Мин. длина пароля:";
            this.lblMinLength.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.lblMinLength, 0, 8);

            this.numMinLength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numMinLength.Minimum = 0;
            this.numMinLength.Maximum = 100;
            this.numMinLength.Name = "numMinLength";
            this.numMinLength.Size = new System.Drawing.Size(80, 22);
            this.tableLayoutPanel.Controls.Add(this.numMinLength, 1, 8);

            // Expiry
            this.lblExpiry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Text = "Срок действия (мес):";
            this.lblExpiry.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.lblExpiry, 0, 9);

            this.numExpiry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numExpiry.Minimum = 0;
            this.numExpiry.Maximum = 120;
            this.numExpiry.Name = "numExpiry";
            this.numExpiry.Size = new System.Drawing.Size(80, 22);
            this.tableLayoutPanel.Controls.Add(this.numExpiry, 1, 9);

            // panelButtons (bottom)
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtons.Location = new System.Drawing.Point(12, 340);
            this.panelButtons.Size = new System.Drawing.Size(560, 48);
            this.panelButtons.Controls.Add(this.btnCancel);
            this.panelButtons.Controls.Add(this.btnSave);

            // btnSave
            this.btnSave.Text = "Сохранить";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Add controls to form
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panelButtons);

            // Form
            this.ClientSize = new System.Drawing.Size(584, 400);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование пользователя";

            ((System.ComponentModel.ISupportInitialize)(this.numMinLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpiry)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }

}