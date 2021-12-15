namespace CSharpLearning
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.label_timer = new System.Windows.Forms.Label();
            this.label_user_login_time = new System.Windows.Forms.Label();
            this.label_user_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnContactus = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.pnlNav);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnContactus);
            this.pnlMenu.Controls.Add(this.btnCalendar);
            this.pnlMenu.Controls.Add(this.btnAnalytics);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pnlUser);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(186, 577);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 4;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.label_timer);
            this.pnlUser.Controls.Add(this.label_user_login_time);
            this.pnlUser.Controls.Add(this.label_user_name);
            this.pnlUser.Controls.Add(this.userAvatar);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(186, 144);
            this.pnlUser.TabIndex = 1;
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label_timer.Location = new System.Drawing.Point(57, 130);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(80, 13);
            this.label_timer.TabIndex = 3;
            this.label_timer.Text = "Logged time:";
            // 
            // label_user_login_time
            // 
            this.label_user_login_time.AutoSize = true;
            this.label_user_login_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_login_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label_user_login_time.Location = new System.Drawing.Point(134, 131);
            this.label_user_login_time.Name = "label_user_login_time";
            this.label_user_login_time.Size = new System.Drawing.Size(49, 12);
            this.label_user_login_time.TabIndex = 2;
            this.label_user_login_time.Text = "00:00:00";
            // 
            // label_user_name
            // 
            this.label_user_name.AutoSize = true;
            this.label_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label_user_name.Location = new System.Drawing.Point(48, 88);
            this.label_user_name.Name = "label_user_name";
            this.label_user_name.Size = new System.Drawing.Size(85, 16);
            this.label_user_name.TabIndex = 1;
            this.label_user_name.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(200, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbSearch.Location = new System.Drawing.Point(588, 22);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(292, 25);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.Text = "Search...";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(904, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(206, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 130);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "$1234";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(17, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Details of 28 Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Earnings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(505, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 130);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label5.Location = new System.Drawing.Point(14, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "12K+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(17, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Details of 28 Days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Downloads";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.circularProgressBar1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(206, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 337);
            this.panel3.TabIndex = 4;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Nirmala UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(48, 43);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(249)))));
            this.circularProgressBar1.ProgressWidth = 7;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 1;
            this.circularProgressBar1.Text = "67%";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(5, 8, 5, 15);
            this.circularProgressBar1.Value = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Some Progress";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label8.Location = new System.Drawing.Point(17, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 51);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enter some Text related applications\r\nSome extra text here to make \r\nthe tab more" +
    " attractive\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(505, 228);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 279);
            this.panel4.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Graph ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(505, 513);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(398, 54);
            this.panel5.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label11.Location = new System.Drawing.Point(17, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(317, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Some extra text here to make the tab more attractive\r\n";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Downloads";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(355, 201);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CSharpLearning.Properties.Resources.download___1458_;
            this.pictureBox2.InitialImage = global::CSharpLearning.Properties.Resources.download___1458_;
            this.pictureBox2.Location = new System.Drawing.Point(156, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSharpLearning.Properties.Resources.dollar___1189_;
            this.pictureBox1.Location = new System.Drawing.Point(156, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = global::CSharpLearning.Properties.Resources.settings___1365_1;
            this.btnSettings.Location = new System.Drawing.Point(0, 535);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 42);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnContactus
            // 
            this.btnContactus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContactus.FlatAppearance.BorderSize = 0;
            this.btnContactus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactus.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnContactus.Image = global::CSharpLearning.Properties.Resources.profile_image___1362_;
            this.btnContactus.Location = new System.Drawing.Point(0, 270);
            this.btnContactus.Name = "btnContactus";
            this.btnContactus.Size = new System.Drawing.Size(186, 42);
            this.btnContactus.TabIndex = 2;
            this.btnContactus.Text = "Contact Us";
            this.btnContactus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnContactus.UseVisualStyleBackColor = true;
            this.btnContactus.Click += new System.EventHandler(this.btnContactus_Click);
            this.btnContactus.Leave += new System.EventHandler(this.btnContactus_Leave);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalendar.Image = global::CSharpLearning.Properties.Resources.calendar___1195_;
            this.btnCalendar.Location = new System.Drawing.Point(0, 228);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(186, 42);
            this.btnCalendar.TabIndex = 2;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            this.btnCalendar.Leave += new System.EventHandler(this.btnCalendar_Leave);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAnalytics.Image = global::CSharpLearning.Properties.Resources.stats___1370_;
            this.btnAnalytics.Location = new System.Drawing.Point(0, 186);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(186, 42);
            this.btnAnalytics.TabIndex = 2;
            this.btnAnalytics.Text = "Analytics";
            this.btnAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            this.btnAnalytics.Leave += new System.EventHandler(this.btnAnalytics_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Image = global::CSharpLearning.Properties.Resources.home___1391_;
            this.btnDashboard.Location = new System.Drawing.Point(0, 144);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(186, 42);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // userAvatar
            // 
            this.userAvatar.Image = global::CSharpLearning.Properties.Resources.user_icon_png_pnglogocom_133466;
            this.userAvatar.Location = new System.Drawing.Point(60, 22);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(63, 63);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAvatar.TabIndex = 0;
            this.userAvatar.TabStop = false;
            this.userAvatar.Click += new System.EventHandler(this.userAvatar_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDrag_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.pnlMenu.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label label_user_login_time;
        private System.Windows.Forms.Label label_user_name;
        private System.Windows.Forms.PictureBox userAvatar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Button btnContactus;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

