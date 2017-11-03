namespace RM_Viewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxFontSize = new System.Windows.Forms.ComboBox();
            this.btnPinkTheme = new System.Windows.Forms.Button();
            this.btnBlueTheme = new System.Windows.Forms.Button();
            this.btnWhiteTheme = new System.Windows.Forms.Button();
            this.btnBlackTheme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.txtBoxReloc = new System.Windows.Forms.TextBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstBoxAll = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstBoxRM = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstBoxRMB = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lstBoxRMT = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lstBoxRMQ = new System.Windows.Forms.ListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lstBoxRMW = new System.Windows.Forms.ListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.lstBoxRTF = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtBoxSelectedRemarks = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMaximized = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbBoxFontSize);
            this.panel1.Controls.Add(this.btnPinkTheme);
            this.panel1.Controls.Add(this.btnBlueTheme);
            this.panel1.Controls.Add(this.btnWhiteTheme);
            this.panel1.Controls.Add(this.btnBlackTheme);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.btnRetrieve);
            this.panel1.Controls.Add(this.txtBoxReloc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 552);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Font Size";
            // 
            // cmbBoxFontSize
            // 
            this.cmbBoxFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbBoxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFontSize.FormattingEnabled = true;
            this.cmbBoxFontSize.Items.AddRange(new object[] {
            "9",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "30",
            "36",
            "42"});
            this.cmbBoxFontSize.Location = new System.Drawing.Point(4, 385);
            this.cmbBoxFontSize.Name = "cmbBoxFontSize";
            this.cmbBoxFontSize.Size = new System.Drawing.Size(116, 21);
            this.cmbBoxFontSize.TabIndex = 3;
            this.cmbBoxFontSize.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFontSize_SelectedIndexChanged);
            // 
            // btnPinkTheme
            // 
            this.btnPinkTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPinkTheme.BackColor = System.Drawing.Color.Pink;
            this.btnPinkTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPinkTheme.ForeColor = System.Drawing.Color.DeepPink;
            this.btnPinkTheme.Location = new System.Drawing.Point(4, 499);
            this.btnPinkTheme.Name = "btnPinkTheme";
            this.btnPinkTheme.Size = new System.Drawing.Size(116, 23);
            this.btnPinkTheme.TabIndex = 8;
            this.btnPinkTheme.Text = "Pink Theme";
            this.btnPinkTheme.UseVisualStyleBackColor = false;
            this.btnPinkTheme.Click += new System.EventHandler(this.btnPinkTheme_Click);
            // 
            // btnBlueTheme
            // 
            this.btnBlueTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBlueTheme.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBlueTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlueTheme.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBlueTheme.Location = new System.Drawing.Point(4, 470);
            this.btnBlueTheme.Name = "btnBlueTheme";
            this.btnBlueTheme.Size = new System.Drawing.Size(116, 23);
            this.btnBlueTheme.TabIndex = 7;
            this.btnBlueTheme.Text = "Blue Theme";
            this.btnBlueTheme.UseVisualStyleBackColor = false;
            this.btnBlueTheme.Click += new System.EventHandler(this.btnBlueTheme_Click);
            // 
            // btnWhiteTheme
            // 
            this.btnWhiteTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWhiteTheme.BackColor = System.Drawing.Color.White;
            this.btnWhiteTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhiteTheme.ForeColor = System.Drawing.Color.Black;
            this.btnWhiteTheme.Location = new System.Drawing.Point(4, 441);
            this.btnWhiteTheme.Name = "btnWhiteTheme";
            this.btnWhiteTheme.Size = new System.Drawing.Size(116, 23);
            this.btnWhiteTheme.TabIndex = 6;
            this.btnWhiteTheme.Text = "White Theme";
            this.btnWhiteTheme.UseVisualStyleBackColor = false;
            this.btnWhiteTheme.Click += new System.EventHandler(this.btnWhiteTheme_Click);
            // 
            // btnBlackTheme
            // 
            this.btnBlackTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBlackTheme.BackColor = System.Drawing.Color.Black;
            this.btnBlackTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlackTheme.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnBlackTheme.Location = new System.Drawing.Point(4, 412);
            this.btnBlackTheme.Name = "btnBlackTheme";
            this.btnBlackTheme.Size = new System.Drawing.Size(116, 23);
            this.btnBlackTheme.TabIndex = 5;
            this.btnBlackTheme.Text = "Black Theme";
            this.btnBlackTheme.UseVisualStyleBackColor = false;
            this.btnBlackTheme.Click += new System.EventHandler(this.btnBlackTheme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Reloc";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(12, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(3, 536);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(22, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "1.8";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.White;
            this.btnRetrieve.FlatAppearance.BorderSize = 0;
            this.btnRetrieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieve.ForeColor = System.Drawing.Color.Black;
            this.btnRetrieve.Location = new System.Drawing.Point(12, 86);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(103, 23);
            this.btnRetrieve.TabIndex = 1;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // txtBoxReloc
            // 
            this.txtBoxReloc.BackColor = System.Drawing.Color.White;
            this.txtBoxReloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxReloc.ForeColor = System.Drawing.Color.Black;
            this.txtBoxReloc.Location = new System.Drawing.Point(12, 32);
            this.txtBoxReloc.MaxLength = 6;
            this.txtBoxReloc.Name = "txtBoxReloc";
            this.txtBoxReloc.Size = new System.Drawing.Size(103, 20);
            this.txtBoxReloc.TabIndex = 1;
            this.txtBoxReloc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxReloc.TextChanged += new System.EventHandler(this.txtBoxReloc_TextChanged);
            this.txtBoxReloc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxReloc_KeyPress);
            this.txtBoxReloc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxReloc_KeyUp);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearch.BackColor = System.Drawing.Color.DimGray;
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.ForeColor = System.Drawing.Color.White;
            this.txtBoxSearch.Location = new System.Drawing.Point(428, 6);
            this.txtBoxSearch.MaxLength = 250;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(305, 21);
            this.txtBoxSearch.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtBoxSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(128, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 32);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.BackgroundImage = global::RM_Viewer.Properties.Resources.search_2;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(733, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(21, 21);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(128, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(30, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 410);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstBoxAll);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ALL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstBoxAll
            // 
            this.lstBoxAll.BackColor = System.Drawing.Color.Black;
            this.lstBoxAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxAll.ForeColor = System.Drawing.Color.Lime;
            this.lstBoxAll.FormattingEnabled = true;
            this.lstBoxAll.HorizontalScrollbar = true;
            this.lstBoxAll.Location = new System.Drawing.Point(3, 3);
            this.lstBoxAll.Name = "lstBoxAll";
            this.lstBoxAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstBoxAll.ScrollAlwaysVisible = true;
            this.lstBoxAll.Size = new System.Drawing.Size(744, 375);
            this.lstBoxAll.TabIndex = 2;
            this.lstBoxAll.DoubleClick += new System.EventHandler(this.lstBoxAll_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstBoxRM);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstBoxRM
            // 
            this.lstBoxRM.BackColor = System.Drawing.Color.Black;
            this.lstBoxRM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxRM.ForeColor = System.Drawing.Color.Lime;
            this.lstBoxRM.FormattingEnabled = true;
            this.lstBoxRM.HorizontalScrollbar = true;
            this.lstBoxRM.Location = new System.Drawing.Point(3, 3);
            this.lstBoxRM.Name = "lstBoxRM";
            this.lstBoxRM.ScrollAlwaysVisible = true;
            this.lstBoxRM.Size = new System.Drawing.Size(744, 375);
            this.lstBoxRM.TabIndex = 0;
            this.lstBoxRM.DoubleClick += new System.EventHandler(this.lstBoxRM_DoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstBoxRMB);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(750, 381);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RMB";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstBoxRMB
            // 
            this.lstBoxRMB.BackColor = System.Drawing.Color.Black;
            this.lstBoxRMB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxRMB.ForeColor = System.Drawing.Color.Lime;
            this.lstBoxRMB.FormattingEnabled = true;
            this.lstBoxRMB.HorizontalScrollbar = true;
            this.lstBoxRMB.Location = new System.Drawing.Point(3, 3);
            this.lstBoxRMB.Name = "lstBoxRMB";
            this.lstBoxRMB.ScrollAlwaysVisible = true;
            this.lstBoxRMB.Size = new System.Drawing.Size(744, 375);
            this.lstBoxRMB.TabIndex = 0;
            this.lstBoxRMB.DoubleClick += new System.EventHandler(this.lstBoxRMB_DoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lstBoxRMT);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(750, 381);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "RMT";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstBoxRMT
            // 
            this.lstBoxRMT.BackColor = System.Drawing.Color.Black;
            this.lstBoxRMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxRMT.ForeColor = System.Drawing.Color.Lime;
            this.lstBoxRMT.FormattingEnabled = true;
            this.lstBoxRMT.HorizontalScrollbar = true;
            this.lstBoxRMT.Location = new System.Drawing.Point(3, 3);
            this.lstBoxRMT.Name = "lstBoxRMT";
            this.lstBoxRMT.ScrollAlwaysVisible = true;
            this.lstBoxRMT.Size = new System.Drawing.Size(744, 375);
            this.lstBoxRMT.TabIndex = 0;
            this.lstBoxRMT.DoubleClick += new System.EventHandler(this.lstBoxRMT_DoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lstBoxRMQ);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(750, 381);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "RMQ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lstBoxRMQ
            // 
            this.lstBoxRMQ.BackColor = System.Drawing.Color.Black;
            this.lstBoxRMQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxRMQ.ForeColor = System.Drawing.Color.Lime;
            this.lstBoxRMQ.FormattingEnabled = true;
            this.lstBoxRMQ.HorizontalScrollbar = true;
            this.lstBoxRMQ.Location = new System.Drawing.Point(3, 3);
            this.lstBoxRMQ.Name = "lstBoxRMQ";
            this.lstBoxRMQ.ScrollAlwaysVisible = true;
            this.lstBoxRMQ.Size = new System.Drawing.Size(744, 375);
            this.lstBoxRMQ.TabIndex = 0;
            this.lstBoxRMQ.DoubleClick += new System.EventHandler(this.lstBoxRMQ_DoubleClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lstBoxRMW);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(750, 381);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "RMW";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lstBoxRMW
            // 
            this.lstBoxRMW.BackColor = System.Drawing.Color.Black;
            this.lstBoxRMW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxRMW.ForeColor = System.Drawing.Color.Lime;
            this.lstBoxRMW.FormattingEnabled = true;
            this.lstBoxRMW.HorizontalScrollbar = true;
            this.lstBoxRMW.Location = new System.Drawing.Point(3, 3);
            this.lstBoxRMW.Name = "lstBoxRMW";
            this.lstBoxRMW.ScrollAlwaysVisible = true;
            this.lstBoxRMW.Size = new System.Drawing.Size(744, 375);
            this.lstBoxRMW.TabIndex = 0;
            this.lstBoxRMW.DoubleClick += new System.EventHandler(this.lstBoxRMW_DoubleClick);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.lstBoxRTF);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(750, 381);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "RTF";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // lstBoxRTF
            // 
            this.lstBoxRTF.BackColor = System.Drawing.Color.Black;
            this.lstBoxRTF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxRTF.ForeColor = System.Drawing.Color.Lime;
            this.lstBoxRTF.FormattingEnabled = true;
            this.lstBoxRTF.HorizontalScrollbar = true;
            this.lstBoxRTF.Location = new System.Drawing.Point(3, 3);
            this.lstBoxRTF.Name = "lstBoxRTF";
            this.lstBoxRTF.ScrollAlwaysVisible = true;
            this.lstBoxRTF.Size = new System.Drawing.Size(744, 375);
            this.lstBoxRTF.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.txtBoxSelectedRemarks);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(128, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(758, 110);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(652, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(729, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Please Make Sure to use RF Command to Save changes in Amadeus Selling Platform";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(514, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Send Delete Command";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Honeydew;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(5, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Send Edit Command";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtBoxSelectedRemarks
            // 
            this.txtBoxSelectedRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSelectedRemarks.Location = new System.Drawing.Point(5, 6);
            this.txtBoxSelectedRemarks.MaxLength = 250;
            this.txtBoxSelectedRemarks.Name = "txtBoxSelectedRemarks";
            this.txtBoxSelectedRemarks.Size = new System.Drawing.Size(750, 20);
            this.txtBoxSelectedRemarks.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btnMaximized);
            this.panel4.Controls.Add(this.btnMinimize);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(886, 24);
            this.panel4.TabIndex = 3;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amadeus Remarks Viewer";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RM_Viewer.Properties.Resources.quotes_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximized.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximized.BackgroundImage = global::RM_Viewer.Properties.Resources.rsz_tick_blank;
            this.btnMaximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximized.ForeColor = System.Drawing.Color.White;
            this.btnMaximized.Location = new System.Drawing.Point(816, 1);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(35, 23);
            this.btnMaximized.TabIndex = 8;
            this.btnMaximized.UseVisualStyleBackColor = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(781, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 23);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(851, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 576);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Amadeus Remarks Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxReloc;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListBox lstBoxRM;
        private System.Windows.Forms.ListBox lstBoxRMB;
        private System.Windows.Forms.ListBox lstBoxRMT;
        private System.Windows.Forms.ListBox lstBoxRMQ;
        private System.Windows.Forms.ListBox lstBoxRMW;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBoxSelectedRemarks;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListBox lstBoxRTF;
        private System.Windows.Forms.Button btnBlackTheme;
        private System.Windows.Forms.Button btnWhiteTheme;
        private System.Windows.Forms.Button btnBlueTheme;
        private System.Windows.Forms.Button btnPinkTheme;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMaximized;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxFontSize;
        private System.Windows.Forms.Label label4;
    }
}