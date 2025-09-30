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
        this.menuHelp
    });
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1000, 28);
            this.menuStripMain.TabIndex = 0;

            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.menuRefresh,
        this.menuMoveTop,
        this.menuMoveBottom,
        this.menuAddUser,
        this.menuChangeAdminPassword,
        this.menuEditUser,
        new ToolStripSeparator(),
        this.menuExit
    });
            this.menuFile.Text = "Файл";

            this.menuRefresh.Text = "Обновить список";
            this.menuRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.menuMoveTop.Text = "В начало списка";
            this.menuMoveTop.Click += new System.EventHandler(this.btnMoveTop_Click);

            this.menuMoveBottom.Text = "В конец списка";
            this.menuMoveBottom.Click += new System.EventHandler(this.btnMoveBottom_Click);

            this.menuAddUser.Text = "Добавить пользователя";
            this.menuAddUser.Click += new System.EventHandler(this.btnAddUser_Click);

            this.menuChangeAdminPassword.Text = "Сменить пароль администратора";
            this.menuChangeAdminPassword.Click += new System.EventHandler(this.BtnChangeAdminPassword_Click);

            this.menuEditUser.Text = "Редактировать пользователя";
            this.menuEditUser.Click += new System.EventHandler(this.btnEditUser_Click);

            this.menuExit.Text = "Выход";
            this.menuExit.Click += (s, e) => this.Close();

            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.menuAbout
    });
            this.menuHelp.Text = "Справка";

            this.menuAbout.Text = "О программе";
            this.menuAbout.Click += (s, e) =>
            {
                MessageBox.Show(
                    "Салин Олег Алексеевич\n" +
                    "Группа: ПИбд-43\n" +
                    "Ограничения на выбираемые пароли: 20. Наличие букв и знаков препинания.\n" +
                    "Используемый режим шифрования DES: OFB\n" +
                    "Добавление к ключу случайного значения: Нет\n" +
                    "Алгоритм хеширования пароля: MD5",
                    "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Dock = DockStyle.Fill; // теперь занимает всё доступное место
            this.dataGridViewUsers.ScrollBars = ScrollBars.Vertical; // вертикальный скролл
            this.dataGridViewUsers.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewUsers_CurrentCellDirtyStateChanged);
            this.dataGridViewUsers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellEndEdit);

            // 
            // Панель с кнопками
            // 
            FlowLayoutPanel panelButtons = new FlowLayoutPanel();
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.FlowDirection = FlowDirection.LeftToRight;
            panelButtons.Padding = new Padding(10);
            panelButtons.WrapContents = true;
            panelButtons.AutoSize = true;
            panelButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            this.btnRefresh.Text = "Обновить список";
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnMoveTop.Text = "В начало списка";
            this.btnMoveTop.AutoSize = true;
            this.btnMoveTop.Click += new System.EventHandler(this.btnMoveTop_Click);

            this.btnMoveBottom.Text = "В конец списка";
            this.btnMoveBottom.AutoSize = true;
            this.btnMoveBottom.Click += new System.EventHandler(this.btnMoveBottom_Click);

            this.btnAddUser.Text = "Добавить пользователя";
            this.btnAddUser.AutoSize = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);

            this.btnChangeAdminPassword.Text = "Сменить пароль";
            this.btnChangeAdminPassword.AutoSize = true;
            this.btnChangeAdminPassword.Click += new System.EventHandler(this.BtnChangeAdminPassword_Click);

            this.btnEditUser.Text = "Редактировать";
            this.btnEditUser.AutoSize = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);

            panelButtons.Controls.AddRange(new Control[] {
        this.btnRefresh,
        this.btnMoveTop,
        this.btnMoveBottom,
        this.btnAddUser,
        this.btnChangeAdminPassword,
        this.btnEditUser
    });

            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MinimumSize = new System.Drawing.Size(1200, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(panelButtons);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "AdminForm";
            this.Text = "Администрирование пользователей";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
