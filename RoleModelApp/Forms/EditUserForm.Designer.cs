namespace Forms
{
    partial class EditUserForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.Label lblPasswordHash;
        private System.Windows.Forms.TextBox txtPasswordHash;

        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.TextBox txtSalt;

        private System.Windows.Forms.Label lblPasswordSet;
        private System.Windows.Forms.TextBox txtPasswordSetUtc;

        private System.Windows.Forms.Label lblIsAdmin;

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
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();

            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();

            this.lblPasswordHash = new System.Windows.Forms.Label();
            this.txtPasswordHash = new System.Windows.Forms.TextBox();

            this.lblSalt = new System.Windows.Forms.Label();
            this.txtSalt = new System.Windows.Forms.TextBox();

            this.lblPasswordSet = new System.Windows.Forms.Label();
            this.txtPasswordSetUtc = new System.Windows.Forms.TextBox();

            this.lblIsAdmin = new System.Windows.Forms.Label();

            this.chkBlocked = new System.Windows.Forms.CheckBox();
            this.chkRequireLetter = new System.Windows.Forms.CheckBox();
            this.chkRequirePunctuation = new System.Windows.Forms.CheckBox();

            this.lblMinLength = new System.Windows.Forms.Label();
            this.numMinLength = new System.Windows.Forms.NumericUpDown();

            this.lblExpiry = new System.Windows.Forms.Label();
            this.numExpiry = new System.Windows.Forms.NumericUpDown();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numMinLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpiry)).BeginInit();
            this.SuspendLayout();

            // 
            // Form
            // 
            this.Text = "Редактирование пользователя";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Size = new System.Drawing.Size(800, 500);
            this.Padding = new Padding(10);

            // 
            // TableLayoutPanel
            // 
            this.tableLayoutPanel.Dock = DockStyle.Top;
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Absolute, 180F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel.RowCount = 10;
            for (int i = 0; i < 10; i++)
                this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.AutoSize));
            this.tableLayoutPanel.Padding = new Padding(10);
            this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;

            // --- Add controls ---
            AddLabelAndControl(lblUsername, "Имя пользователя:", txtUsername, true, 0);
            AddLabelAndControl(lblPasswordHash, "Хеш пароля:", txtPasswordHash, true, 1, true);
            AddLabelAndControl(lblSalt, "Salt:", txtSalt, true, 2);
            AddLabelAndControl(lblPasswordSet, "Дата установки пароля (UTC):", txtPasswordSetUtc, true, 3);

            AddLabelAndControl(new System.Windows.Forms.Label() { Text = "Заблокирован:", AutoSize = true }, null, chkBlocked, false, 5);
            AddLabelAndControl(new System.Windows.Forms.Label() { Text = "Требовать букву:", AutoSize = true }, null, chkRequireLetter, false, 6);
            AddLabelAndControl(new System.Windows.Forms.Label() { Text = "Требовать пунктуацию:", AutoSize = true }, null, chkRequirePunctuation, false, 7);
            AddLabelAndControl(lblMinLength, "Мин. длина пароля:", numMinLength, false, 8);
            AddLabelAndControl(lblExpiry, "Срок действия (мес):", numExpiry, false, 9);

            // 
            // Scroll Panel
            // 
            this.scrollPanel.Dock = DockStyle.Fill;
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Padding = new Padding(0);
            this.scrollPanel.Controls.Add(tableLayoutPanel);

            // 
            // FlowLayoutPanel (buttons)
            // 
            this.panelButtons.Dock = DockStyle.Bottom;
            this.panelButtons.FlowDirection = FlowDirection.RightToLeft;
            this.panelButtons.Padding = new Padding(10);
            this.panelButtons.Controls.Add(btnCancel);
            this.panelButtons.Controls.Add(btnSave);
            this.panelButtons.AutoSize = true;
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            // 
            // Buttons
            // 
            this.btnSave.Text = "Сохранить";
            this.btnSave.AutoSize = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Отмена";
            this.btnCancel.AutoSize = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // Add panels to form
            // 
            this.Controls.Add(scrollPanel);
            this.Controls.Add(panelButtons);

            ((System.ComponentModel.ISupportInitialize)(this.numMinLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpiry)).EndInit();
            this.ResumeLayout(true);
        }

        private void AddLabelAndControl(System.Windows.Forms.Label lbl, string text, System.Windows.Forms.Control ctrl, bool readOnly = false, int row = 0, bool multiline = false)
        {
            if (lbl != null)
            {
                if (!string.IsNullOrEmpty(text)) lbl.Text = text;
                lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
                lbl.AutoSize = true;
                tableLayoutPanel.Controls.Add(lbl, 0, row);
            }

            if (ctrl != null)
            {
                ctrl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                if (ctrl is System.Windows.Forms.TextBox tb)
                {
                    tb.ReadOnly = readOnly;
                    tb.Multiline = multiline;
                    if (multiline) tb.Height = 40;
                }
                tableLayoutPanel.Controls.Add(ctrl, 1, row);
            }
        }
    }
}
