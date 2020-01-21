namespace MyOnlineCinema
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.authMenu = new System.Windows.Forms.Panel();
            this._userControlPanel = new System.Windows.Forms.Panel();
            this._usernameLbl = new System.Windows.Forms.Label();
            this._exitBTN = new System.Windows.Forms.Button();
            this._mySubsBTN = new System.Windows.Forms.Button();
            this._myPaymentsBTN = new System.Windows.Forms.Button();
            this._authGB = new System.Windows.Forms.GroupBox();
            this._registerBTN = new System.Windows.Forms.Button();
            this._authBTN = new System.Windows.Forms.Button();
            this._passwordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._loginTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this._filmsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._mySubsPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._userSubsGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._allSubsGV = new System.Windows.Forms.DataGridView();
            this._buySubBTN = new System.Windows.Forms.Button();
            this._myFilmsPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this._myFilmGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this._lookMode = new System.Windows.Forms.ComboBox();
            this._searchTB = new System.Windows.Forms.TextBox();
            this._searchBTN = new System.Windows.Forms.Button();
            this._showMenuBTN = new System.Windows.Forms.Button();
            this.authMenu.SuspendLayout();
            this._userControlPanel.SuspendLayout();
            this._authGB.SuspendLayout();
            this._mySubsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._userSubsGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._allSubsGV)).BeginInit();
            this._myFilmsPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._myFilmGV)).BeginInit();
            this.SuspendLayout();
            // 
            // authMenu
            // 
            this.authMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.authMenu.BackColor = System.Drawing.Color.Teal;
            this.authMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.authMenu.Controls.Add(this._userControlPanel);
            this.authMenu.Controls.Add(this._authGB);
            this.authMenu.Controls.Add(this.label1);
            this.authMenu.Controls.Add(this.label);
            this.authMenu.Location = new System.Drawing.Point(0, 0);
            this.authMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authMenu.Name = "authMenu";
            this.authMenu.Size = new System.Drawing.Size(315, 518);
            this.authMenu.TabIndex = 4;
            // 
            // _userControlPanel
            // 
            this._userControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._userControlPanel.Controls.Add(this._usernameLbl);
            this._userControlPanel.Controls.Add(this._exitBTN);
            this._userControlPanel.Controls.Add(this._mySubsBTN);
            this._userControlPanel.Controls.Add(this._myPaymentsBTN);
            this._userControlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._userControlPanel.Location = new System.Drawing.Point(4, 70);
            this._userControlPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._userControlPanel.Name = "_userControlPanel";
            this._userControlPanel.Size = new System.Drawing.Size(307, 422);
            this._userControlPanel.TabIndex = 4;
            // 
            // _usernameLbl
            // 
            this._usernameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._usernameLbl.AutoSize = true;
            this._usernameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._usernameLbl.Location = new System.Drawing.Point(99, 0);
            this._usernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._usernameLbl.Name = "_usernameLbl";
            this._usernameLbl.Size = new System.Drawing.Size(107, 24);
            this._usernameLbl.TabIndex = 8;
            this._usernameLbl.Text = "{username}";
            this._usernameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _exitBTN
            // 
            this._exitBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._exitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._exitBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._exitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._exitBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this._exitBTN.Location = new System.Drawing.Point(5, 386);
            this._exitBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._exitBTN.Name = "_exitBTN";
            this._exitBTN.Size = new System.Drawing.Size(301, 32);
            this._exitBTN.TabIndex = 6;
            this._exitBTN.Text = "Выход";
            this._exitBTN.UseVisualStyleBackColor = false;
            this._exitBTN.Click += new System.EventHandler(this._exitBTN_Click);
            // 
            // _mySubsBTN
            // 
            this._mySubsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._mySubsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._mySubsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._mySubsBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this._mySubsBTN.Location = new System.Drawing.Point(4, 102);
            this._mySubsBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._mySubsBTN.Name = "_mySubsBTN";
            this._mySubsBTN.Size = new System.Drawing.Size(297, 32);
            this._mySubsBTN.TabIndex = 7;
            this._mySubsBTN.Text = "Мои подписки";
            this._mySubsBTN.UseVisualStyleBackColor = false;
            this._mySubsBTN.Click += new System.EventHandler(this._mySubsBTN_Click);
            // 
            // _myPaymentsBTN
            // 
            this._myPaymentsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._myPaymentsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._myPaymentsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._myPaymentsBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this._myPaymentsBTN.Location = new System.Drawing.Point(4, 63);
            this._myPaymentsBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._myPaymentsBTN.Name = "_myPaymentsBTN";
            this._myPaymentsBTN.Size = new System.Drawing.Size(297, 32);
            this._myPaymentsBTN.TabIndex = 6;
            this._myPaymentsBTN.Text = "Мои покупки";
            this._myPaymentsBTN.UseVisualStyleBackColor = false;
            this._myPaymentsBTN.Click += new System.EventHandler(this._myPaymentsBTN_Click);
            // 
            // _authGB
            // 
            this._authGB.BackColor = System.Drawing.Color.Transparent;
            this._authGB.Controls.Add(this._registerBTN);
            this._authGB.Controls.Add(this._authBTN);
            this._authGB.Controls.Add(this._passwordTB);
            this._authGB.Controls.Add(this.label3);
            this._authGB.Controls.Add(this._loginTB);
            this._authGB.Controls.Add(this.label2);
            this._authGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._authGB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._authGB.Location = new System.Drawing.Point(16, 70);
            this._authGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._authGB.Name = "_authGB";
            this._authGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._authGB.Size = new System.Drawing.Size(281, 225);
            this._authGB.TabIndex = 3;
            this._authGB.TabStop = false;
            this._authGB.Text = "Авторизация";
            // 
            // _registerBTN
            // 
            this._registerBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._registerBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._registerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._registerBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this._registerBTN.Location = new System.Drawing.Point(12, 186);
            this._registerBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._registerBTN.Name = "_registerBTN";
            this._registerBTN.Size = new System.Drawing.Size(153, 32);
            this._registerBTN.TabIndex = 5;
            this._registerBTN.Text = "Регистрация";
            this._registerBTN.UseVisualStyleBackColor = false;
            this._registerBTN.Click += new System.EventHandler(this._registerBTN_Click);
            // 
            // _authBTN
            // 
            this._authBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._authBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._authBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._authBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this._authBTN.Location = new System.Drawing.Point(173, 186);
            this._authBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._authBTN.Name = "_authBTN";
            this._authBTN.Size = new System.Drawing.Size(100, 32);
            this._authBTN.TabIndex = 4;
            this._authBTN.Text = "Вход";
            this._authBTN.UseVisualStyleBackColor = false;
            this._authBTN.Click += new System.EventHandler(this._authBTN_Click);
            // 
            // _passwordTB
            // 
            this._passwordTB.Location = new System.Drawing.Point(12, 134);
            this._passwordTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._passwordTB.Name = "_passwordTB";
            this._passwordTB.PasswordChar = '*';
            this._passwordTB.Size = new System.Drawing.Size(260, 29);
            this._passwordTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // _loginTB
            // 
            this._loginTB.Location = new System.Drawing.Point(12, 69);
            this._loginTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._loginTB.Name = "_loginTB";
            this._loginTB.Size = new System.Drawing.Size(260, 29);
            this._loginTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(113, 0);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 29);
            this.label.TabIndex = 1;
            this.label.Text = "Меню";
            // 
            // _filmsPanel
            // 
            this._filmsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._filmsPanel.AutoScroll = true;
            this._filmsPanel.Location = new System.Drawing.Point(71, 64);
            this._filmsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._filmsPanel.Name = "_filmsPanel";
            this._filmsPanel.Size = new System.Drawing.Size(971, 400);
            this._filmsPanel.TabIndex = 6;
            this._filmsPanel.WrapContents = false;
            // 
            // _mySubsPanel
            // 
            this._mySubsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mySubsPanel.BackColor = System.Drawing.Color.Teal;
            this._mySubsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._mySubsPanel.Controls.Add(this.groupBox1);
            this._mySubsPanel.Controls.Add(this.groupBox2);
            this._mySubsPanel.Location = new System.Drawing.Point(313, 0);
            this._mySubsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._mySubsPanel.Name = "_mySubsPanel";
            this._mySubsPanel.Size = new System.Drawing.Size(732, 518);
            this._mySubsPanel.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._userSubsGV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(11, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(705, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список ваших подписок";
            // 
            // _userSubsGV
            // 
            this._userSubsGV.AllowUserToAddRows = false;
            this._userSubsGV.AllowUserToDeleteRows = false;
            this._userSubsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._userSubsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._userSubsGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._userSubsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._userSubsGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this._userSubsGV.Location = new System.Drawing.Point(7, 26);
            this._userSubsGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._userSubsGV.Name = "_userSubsGV";
            this._userSubsGV.ReadOnly = true;
            this._userSubsGV.Size = new System.Drawing.Size(691, 196);
            this._userSubsGV.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this._allSubsGV);
            this.groupBox2.Controls.Add(this._buySubBTN);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(9, 241);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(705, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список доступных подписок";
            // 
            // _allSubsGV
            // 
            this._allSubsGV.AllowUserToAddRows = false;
            this._allSubsGV.AllowUserToDeleteRows = false;
            this._allSubsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._allSubsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._allSubsGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._allSubsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._allSubsGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this._allSubsGV.Location = new System.Drawing.Point(8, 31);
            this._allSubsGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._allSubsGV.Name = "_allSubsGV";
            this._allSubsGV.ReadOnly = true;
            this._allSubsGV.Size = new System.Drawing.Size(689, 162);
            this._allSubsGV.TabIndex = 0;
            // 
            // _buySubBTN
            // 
            this._buySubBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buySubBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._buySubBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._buySubBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._buySubBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._buySubBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this._buySubBTN.Location = new System.Drawing.Point(400, 201);
            this._buySubBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._buySubBTN.Name = "_buySubBTN";
            this._buySubBTN.Size = new System.Drawing.Size(297, 32);
            this._buySubBTN.TabIndex = 9;
            this._buySubBTN.Text = "Оформить подписку";
            this._buySubBTN.UseVisualStyleBackColor = false;
            this._buySubBTN.Click += new System.EventHandler(this._buySubBTN_Click);
            // 
            // _myFilmsPanel
            // 
            this._myFilmsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._myFilmsPanel.BackColor = System.Drawing.Color.Teal;
            this._myFilmsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._myFilmsPanel.Controls.Add(this.groupBox3);
            this._myFilmsPanel.Location = new System.Drawing.Point(313, 0);
            this._myFilmsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._myFilmsPanel.Name = "_myFilmsPanel";
            this._myFilmsPanel.Size = new System.Drawing.Size(732, 519);
            this._myFilmsPanel.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(11, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(717, 486);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Список купленных фильмов";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this._myFilmGV);
            this.panel4.Location = new System.Drawing.Point(8, 31);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(701, 448);
            this.panel4.TabIndex = 0;
            // 
            // _myFilmGV
            // 
            this._myFilmGV.AllowUserToAddRows = false;
            this._myFilmGV.AllowUserToDeleteRows = false;
            this._myFilmGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._myFilmGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._myFilmGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._myFilmGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._myFilmGV.GridColor = System.Drawing.SystemColors.ControlLight;
            this._myFilmGV.Location = new System.Drawing.Point(4, 4);
            this._myFilmGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._myFilmGV.Name = "_myFilmGV";
            this._myFilmGV.ReadOnly = true;
            this._myFilmGV.Size = new System.Drawing.Size(692, 441);
            this._myFilmGV.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(71, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "MyOnlineCinema |";
            // 
            // _lookMode
            // 
            this._lookMode.BackColor = System.Drawing.Color.White;
            this._lookMode.DropDownHeight = 100;
            this._lookMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._lookMode.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lookMode.ForeColor = System.Drawing.Color.Teal;
            this._lookMode.FormattingEnabled = true;
            this._lookMode.IntegralHeight = false;
            this._lookMode.Items.AddRange(new object[] {
            "Недавно добавленные",
            "Полный список",
            "По описанию"});
            this._lookMode.Location = new System.Drawing.Point(375, 20);
            this._lookMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._lookMode.Name = "_lookMode";
            this._lookMode.Size = new System.Drawing.Size(277, 34);
            this._lookMode.TabIndex = 8;
            this._lookMode.SelectedIndexChanged += new System.EventHandler(this._lookMode_SelectedIndexChanged);
            // 
            // _searchTB
            // 
            this._searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._searchTB.Location = new System.Drawing.Point(661, 20);
            this._searchTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._searchTB.Name = "_searchTB";
            this._searchTB.Size = new System.Drawing.Size(325, 37);
            this._searchTB.TabIndex = 9;
            // 
            // _searchBTN
            // 
            this._searchBTN.BackgroundImage = global::MyOnlineCinema.Properties.Resources.search;
            this._searchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._searchBTN.Location = new System.Drawing.Point(996, 17);
            this._searchBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._searchBTN.Name = "_searchBTN";
            this._searchBTN.Size = new System.Drawing.Size(45, 41);
            this._searchBTN.TabIndex = 10;
            this._searchBTN.UseVisualStyleBackColor = true;
            this._searchBTN.Click += new System.EventHandler(this._searchBTN_Click);
            // 
            // _showMenuBTN
            // 
            this._showMenuBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_showMenuBTN.BackgroundImage")));
            this._showMenuBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._showMenuBTN.Location = new System.Drawing.Point(16, 15);
            this._showMenuBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._showMenuBTN.Name = "_showMenuBTN";
            this._showMenuBTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._showMenuBTN.Size = new System.Drawing.Size(47, 43);
            this._showMenuBTN.TabIndex = 3;
            this._showMenuBTN.UseVisualStyleBackColor = true;
            this._showMenuBTN.Click += new System.EventHandler(this._showMenuBTN_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 527);
            this.Controls.Add(this._mySubsPanel);
            this.Controls.Add(this._myFilmsPanel);
            this.Controls.Add(this._showMenuBTN);
            this.Controls.Add(this.authMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._filmsPanel);
            this.Controls.Add(this._lookMode);
            this.Controls.Add(this._searchBTN);
            this.Controls.Add(this._searchTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1064, 559);
            this.Name = "MainMenu";
            this.Text = "Онлайн-кинотеатр";
            this.TransparencyKey = System.Drawing.Color.DarkCyan;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.authMenu.ResumeLayout(false);
            this.authMenu.PerformLayout();
            this._userControlPanel.ResumeLayout(false);
            this._userControlPanel.PerformLayout();
            this._authGB.ResumeLayout(false);
            this._authGB.PerformLayout();
            this._mySubsPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._userSubsGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._allSubsGV)).EndInit();
            this._myFilmsPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._myFilmGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _showMenuBTN;
        private System.Windows.Forms.Panel authMenu;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox _authGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _loginTB;
        private System.Windows.Forms.TextBox _passwordTB;
        private System.Windows.Forms.Button _authBTN;
        private System.Windows.Forms.Button _registerBTN;
        private System.Windows.Forms.Panel _userControlPanel;
        private System.Windows.Forms.Button _mySubsBTN;
        private System.Windows.Forms.Button _myPaymentsBTN;
        private System.Windows.Forms.Button _exitBTN;
        private System.Windows.Forms.Label _usernameLbl;
        private System.Windows.Forms.Panel _mySubsPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView _allSubsGV;
        private System.Windows.Forms.Button _buySubBTN;
        private System.Windows.Forms.DataGridView _userSubsGV;
        private System.Windows.Forms.FlowLayoutPanel _filmsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel _myFilmsPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView _myFilmGV;
        private System.Windows.Forms.ComboBox _lookMode;
        private System.Windows.Forms.TextBox _searchTB;
        private System.Windows.Forms.Button _searchBTN;
    }
}

