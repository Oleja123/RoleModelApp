namespace Forms
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMoveTop;
        private System.Windows.Forms.Button btnMoveBottom;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnChangeAdminPassword;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.ToolStripMenuItem menuMoveTop;
        private System.Windows.Forms.ToolStripMenuItem menuMoveBottom;
        private System.Windows.Forms.ToolStripMenuItem menuAddUser;
        private System.Windows.Forms.ToolStripMenuItem menuChangeAdminPassword;
        private System.Windows.Forms.ToolStripMenuItem menuEditUser;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;

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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMoveTop = new System.Windows.Forms.Button();
            this.btnMoveBottom = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnChangeAdminPassword = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();

            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveTop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangeAdminPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuFile,
                this.menuHelp,
                this.menuExit
            });
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1500, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";

            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuRefresh,
                this.menuMoveTop,
                this.menuMoveBottom,
                this.menuAddUser,
                this.menuChangeAdminPassword,
                this.menuEditUser
            });
            this.menuFile.Name = "menuFile";
            this.menuFile.Text = "Файл";

            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Text = "Обновить список";
            this.menuRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // menuMoveTop
            // 
            this.menuMoveTop.Name = "menuMoveTop";
            this.menuMoveTop.Text = "В начало списка";
            this.menuMoveTop.Click += new System.EventHandler(this.btnMoveTop_Click);

            // 
            // menuMoveBottom
            // 
            this.menuMoveBottom.Name = "menuMoveBottom";
            this.menuMoveBottom.Text = "В конец списка";
            this.menuMoveBottom.Click += new System.EventHandler(this.btnMoveBottom_Click);

            // 
            // menuAddUser
            // 
            this.menuAddUser.Name = "menuAddUser";
            this.menuAddUser.Text = "Добавить";
            this.menuAddUser.Click += new System.EventHandler(this.btnAddUser_Click);

            // 
            // menuChangeAdminPassword
            // 
            this.menuChangeAdminPassword.Name = "menuChangeAdminPassword";
            this.menuChangeAdminPassword.Text = "Сменить пароль администратора";
            this.menuChangeAdminPassword.Click += new System.EventHandler(this.BtnChangeAdminPassword_Click);

            // 
            // menuEditUser
            // 
            this.menuEditUser.Name = "menuEditUser";
            this.menuEditUser.Text = "Редактировать пользователя";
            this.menuEditUser.Click += new System.EventHandler(this.btnEditUser_Click);

            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Text = "Выход";

            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuAbout
            });
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Text = "Справка";

            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Text = "О программе";
            this.menuAbout.Click += (s, e) =>
            {
                MessageBox.Show(
                    "Салин Олег Алексеевич\n" +
                    "Группа: ПИбд-43\n" +
                    "Ограничения на выбираемые пароли: 20. Наличие букв и знаков препинания.\n" +
                    "Используемый режим шифрования алгоритма DES для шифрования файла: OFB\n" +
                    "Добавление к ключу случайного значения: Нет\n" +
                    "Используемый алгоритм хеширования пароля: MD5",
                    "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1476, 400);
            this.dataGridViewUsers.TabIndex = 1;

            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 450);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить список";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // btnMoveTop
            // 
            this.btnMoveTop.Location = new System.Drawing.Point(180, 450);
            this.btnMoveTop.Name = "btnMoveTop";
            this.btnMoveTop.Size = new System.Drawing.Size(150, 30);
            this.btnMoveTop.TabIndex = 3;
            this.btnMoveTop.Text = "В начало списка";
            this.btnMoveTop.UseVisualStyleBackColor = true;
            this.btnMoveTop.Click += new System.EventHandler(this.btnMoveTop_Click);

            // 
            // btnMoveBottom
            // 
            this.btnMoveBottom.Location = new System.Drawing.Point(350, 450);
            this.btnMoveBottom.Name = "btnMoveBottom";
            this.btnMoveBottom.Size = new System.Drawing.Size(150, 30);
            this.btnMoveBottom.TabIndex = 4;
            this.btnMoveBottom.Text = "В конец списка";
            this.btnMoveBottom.UseVisualStyleBackColor = true;
            this.btnMoveBottom.Click += new System.EventHandler(this.btnMoveBottom_Click);

            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(520, 450);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(150, 30);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Добавить пользователя";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);

            // 
            // btnChangeAdminPassword
            // 
            this.btnChangeAdminPassword.Location = new System.Drawing.Point(680, 450);
            this.btnChangeAdminPassword.Name = "btnChangeAdminPassword";
            this.btnChangeAdminPassword.Size = new System.Drawing.Size(150, 30);
            this.btnChangeAdminPassword.TabIndex = 6;
            this.btnChangeAdminPassword.Text = "Сменить пароль";
            this.btnChangeAdminPassword.UseVisualStyleBackColor = true;
            this.btnChangeAdminPassword.Click += new System.EventHandler(this.BtnChangeAdminPassword_Click);

            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(840, 450);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(150, 30);
            this.btnEditUser.TabIndex = 7;
            this.btnEditUser.Text = "Редактировать";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);

            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 500);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMoveTop);
            this.Controls.Add(this.btnMoveBottom);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnChangeAdminPassword);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "AdminForm";
            this.Text = "Администрирование пользователей";

            this.dataGridViewUsers.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewUsers_CurrentCellDirtyStateChanged);
            this.dataGridViewUsers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellEndEdit);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
