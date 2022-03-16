namespace Lab2_Boxing {
    partial class Boxing {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.Step1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TimerCombo = new System.Windows.Forms.ToolStripComboBox();
            this.RoundAccept = new System.Windows.Forms.ToolStripButton();
            this.Step2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RestTimeBX = new System.Windows.Forms.ToolStripTextBox();
            this.RestAccept = new System.Windows.Forms.ToolStripButton();
            this.Step3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PlayBTN = new System.Windows.Forms.ToolStripButton();
            this.Step4 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.PauseBTN = new System.Windows.Forms.ToolStripButton();
            this.Step5 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.StopBTN = new System.Windows.Forms.ToolStripButton();
            this.Step6 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel12 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BellBTN = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TMinBox = new System.Windows.Forms.TextBox();
            this.TSecBox = new System.Windows.Forms.TextBox();
            this.TMilBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TTimer = new System.Windows.Forms.Timer(this.components);
            this.RestTMR = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RSecBox = new System.Windows.Forms.TextBox();
            this.RMilBox = new System.Windows.Forms.TextBox();
            this.Step1.SuspendLayout();
            this.Step2.SuspendLayout();
            this.Step3.SuspendLayout();
            this.Step4.SuspendLayout();
            this.Step5.SuspendLayout();
            this.Step6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Step1
            // 
            this.Step1.BackColor = System.Drawing.Color.White;
            this.Step1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.TimerCombo,
            this.RoundAccept});
            this.Step1.Location = new System.Drawing.Point(0, 0);
            this.Step1.Name = "Step1";
            this.Step1.Size = new System.Drawing.Size(725, 25);
            this.Step1.TabIndex = 0;
            this.Step1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Step#1:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(187, 22);
            this.toolStripLabel2.Text = "Setup Round TIme limit in munites";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TimerCombo
            // 
            this.TimerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimerCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimerCombo.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.TimerCombo.Name = "TimerCombo";
            this.TimerCombo.Size = new System.Drawing.Size(75, 25);
            // 
            // RoundAccept
            // 
            this.RoundAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RoundAccept.Image = global::Lab2_Boxing.Properties.Resources.accept;
            this.RoundAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RoundAccept.Name = "RoundAccept";
            this.RoundAccept.Size = new System.Drawing.Size(23, 22);
            this.RoundAccept.Text = "toolStripButton1";
            this.RoundAccept.Click += new System.EventHandler(this.RoundAccept_Click);
            // 
            // Step2
            // 
            this.Step2.BackColor = System.Drawing.Color.White;
            this.Step2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.toolStripSeparator2,
            this.RestTimeBX,
            this.RestAccept});
            this.Step2.Location = new System.Drawing.Point(0, 25);
            this.Step2.Name = "Step2";
            this.Step2.Size = new System.Drawing.Size(725, 25);
            this.Step2.TabIndex = 20;
            this.Step2.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel3.Text = "Step#2:";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(174, 22);
            this.toolStripLabel4.Text = "Setup Rest Time limit in seconds";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(213, 0, 0, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // RestTimeBX
            // 
            this.RestTimeBX.Name = "RestTimeBX";
            this.RestTimeBX.Size = new System.Drawing.Size(75, 25);
            // 
            // RestAccept
            // 
            this.RestAccept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RestAccept.Image = global::Lab2_Boxing.Properties.Resources.accept;
            this.RestAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RestAccept.Name = "RestAccept";
            this.RestAccept.Size = new System.Drawing.Size(23, 22);
            this.RestAccept.Text = "toolStripButton2";
            this.RestAccept.Click += new System.EventHandler(this.RestAccept_Click);
            // 
            // Step3
            // 
            this.Step3.BackColor = System.Drawing.Color.White;
            this.Step3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.toolStripLabel6,
            this.toolStripSeparator3,
            this.PlayBTN});
            this.Step3.Location = new System.Drawing.Point(0, 50);
            this.Step3.Name = "Step3";
            this.Step3.Size = new System.Drawing.Size(725, 25);
            this.Step3.TabIndex = 21;
            this.Step3.Text = "toolStrip1";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel5.Text = "Step#3:";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(128, 22);
            this.toolStripLabel6.Text = "Just hit the play button";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(259, 0, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // PlayBTN
            // 
            this.PlayBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlayBTN.Image = global::Lab2_Boxing.Properties.Resources.play;
            this.PlayBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayBTN.Name = "PlayBTN";
            this.PlayBTN.Size = new System.Drawing.Size(23, 22);
            this.PlayBTN.Text = "toolStripButton1";
            this.PlayBTN.Click += new System.EventHandler(this.PlayBTN_Click);
            // 
            // Step4
            // 
            this.Step4.BackColor = System.Drawing.Color.White;
            this.Step4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel7,
            this.toolStripLabel8,
            this.toolStripSeparator4,
            this.PauseBTN});
            this.Step4.Location = new System.Drawing.Point(0, 75);
            this.Step4.Name = "Step4";
            this.Step4.Size = new System.Drawing.Size(725, 25);
            this.Step4.TabIndex = 22;
            this.Step4.Text = "toolStrip1";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel7.Text = "Step#4:";
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(243, 22);
            this.toolStripLabel8.Text = "If you hit the play button, you can also pause";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(144, 0, 0, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // PauseBTN
            // 
            this.PauseBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PauseBTN.Image = global::Lab2_Boxing.Properties.Resources.pause;
            this.PauseBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseBTN.Name = "PauseBTN";
            this.PauseBTN.Size = new System.Drawing.Size(23, 22);
            this.PauseBTN.Text = "toolStripButton1";
            this.PauseBTN.Click += new System.EventHandler(this.PauseBTN_Click);
            // 
            // Step5
            // 
            this.Step5.BackColor = System.Drawing.Color.White;
            this.Step5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel9,
            this.toolStripLabel10,
            this.toolStripSeparator5,
            this.StopBTN});
            this.Step5.Location = new System.Drawing.Point(0, 100);
            this.Step5.Name = "Step5";
            this.Step5.Size = new System.Drawing.Size(725, 25);
            this.Step5.TabIndex = 23;
            this.Step5.Text = "toolStrip1";
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel9.Text = "Step#5:";
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(207, 22);
            this.toolStripLabel10.Text = "and you can stop and reset everything";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(180, 0, 0, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // StopBTN
            // 
            this.StopBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopBTN.Image = global::Lab2_Boxing.Properties.Resources.stop;
            this.StopBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(23, 22);
            this.StopBTN.Text = "toolStripButton1";
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // Step6
            // 
            this.Step6.BackColor = System.Drawing.Color.White;
            this.Step6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel11,
            this.toolStripLabel12,
            this.toolStripSeparator6,
            this.BellBTN});
            this.Step6.Location = new System.Drawing.Point(0, 125);
            this.Step6.Name = "Step6";
            this.Step6.Size = new System.Drawing.Size(725, 25);
            this.Step6.TabIndex = 24;
            this.Step6.Text = "toolStrip1";
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel11.Text = "Step#6:";
            // 
            // toolStripLabel12
            // 
            this.toolStripLabel12.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel12.Name = "toolStripLabel12";
            this.toolStripLabel12.Size = new System.Drawing.Size(356, 22);
            this.toolStripLabel12.Text = "Don\'t forget, you could also ring the bell if someone gets knockout";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // BellBTN
            // 
            this.BellBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BellBTN.Image = global::Lab2_Boxing.Properties.Resources.bell;
            this.BellBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BellBTN.Name = "BellBTN";
            this.BellBTN.Size = new System.Drawing.Size(23, 22);
            this.BellBTN.Text = "toolStripButton1";
            this.BellBTN.Click += new System.EventHandler(this.BellBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(177, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 47);
            this.label4.TabIndex = 31;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(103, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 47);
            this.label3.TabIndex = 30;
            this.label3.Text = ":";
            // 
            // TMinBox
            // 
            this.TMinBox.BackColor = System.Drawing.Color.White;
            this.TMinBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TMinBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TMinBox.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMinBox.ForeColor = System.Drawing.Color.DimGray;
            this.TMinBox.Location = new System.Drawing.Point(55, 237);
            this.TMinBox.Name = "TMinBox";
            this.TMinBox.ReadOnly = true;
            this.TMinBox.Size = new System.Drawing.Size(59, 64);
            this.TMinBox.TabIndex = 28;
            this.TMinBox.Text = "00";
            // 
            // TSecBox
            // 
            this.TSecBox.BackColor = System.Drawing.Color.White;
            this.TSecBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TSecBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TSecBox.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSecBox.ForeColor = System.Drawing.Color.DimGray;
            this.TSecBox.Location = new System.Drawing.Point(129, 237);
            this.TSecBox.Name = "TSecBox";
            this.TSecBox.ReadOnly = true;
            this.TSecBox.Size = new System.Drawing.Size(59, 64);
            this.TSecBox.TabIndex = 26;
            this.TSecBox.Text = "00";
            // 
            // TMilBox
            // 
            this.TMilBox.BackColor = System.Drawing.Color.White;
            this.TMilBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TMilBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TMilBox.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMilBox.ForeColor = System.Drawing.Color.DimGray;
            this.TMilBox.Location = new System.Drawing.Point(203, 237);
            this.TMilBox.Name = "TMilBox";
            this.TMilBox.ReadOnly = true;
            this.TMilBox.Size = new System.Drawing.Size(59, 64);
            this.TMilBox.TabIndex = 25;
            this.TMilBox.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "ROUND TIME";
            // 
            // TTimer
            // 
            this.TTimer.Interval = 1;
            this.TTimer.Tick += new System.EventHandler(this.TTimer_Tick);
            // 
            // RestTMR
            // 
            this.RestTMR.Interval = 1;
            this.RestTMR.Tick += new System.EventHandler(this.RestTMR_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "REST TIME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(427, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 47);
            this.label6.TabIndex = 39;
            this.label6.Text = ":";
            // 
            // RSecBox
            // 
            this.RSecBox.BackColor = System.Drawing.Color.White;
            this.RSecBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RSecBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RSecBox.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RSecBox.ForeColor = System.Drawing.Color.DimGray;
            this.RSecBox.Location = new System.Drawing.Point(379, 237);
            this.RSecBox.Name = "RSecBox";
            this.RSecBox.ReadOnly = true;
            this.RSecBox.Size = new System.Drawing.Size(59, 64);
            this.RSecBox.TabIndex = 34;
            this.RSecBox.Text = "00";
            // 
            // RMilBox
            // 
            this.RMilBox.BackColor = System.Drawing.Color.White;
            this.RMilBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RMilBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RMilBox.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMilBox.ForeColor = System.Drawing.Color.DimGray;
            this.RMilBox.Location = new System.Drawing.Point(453, 237);
            this.RMilBox.Name = "RMilBox";
            this.RMilBox.ReadOnly = true;
            this.RMilBox.Size = new System.Drawing.Size(59, 64);
            this.RMilBox.TabIndex = 33;
            this.RMilBox.Text = "00";
            // 
            // Boxing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 381);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RSecBox);
            this.Controls.Add(this.RMilBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TMinBox);
            this.Controls.Add(this.TSecBox);
            this.Controls.Add(this.TMilBox);
            this.Controls.Add(this.Step6);
            this.Controls.Add(this.Step5);
            this.Controls.Add(this.Step4);
            this.Controls.Add(this.Step3);
            this.Controls.Add(this.Step2);
            this.Controls.Add(this.Step1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Boxing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boxing Round TImer";
            this.Step1.ResumeLayout(false);
            this.Step1.PerformLayout();
            this.Step2.ResumeLayout(false);
            this.Step2.PerformLayout();
            this.Step3.ResumeLayout(false);
            this.Step3.PerformLayout();
            this.Step4.ResumeLayout(false);
            this.Step4.PerformLayout();
            this.Step5.ResumeLayout(false);
            this.Step5.PerformLayout();
            this.Step6.ResumeLayout(false);
            this.Step6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Step1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox TimerCombo;
        private System.Windows.Forms.ToolStripButton RoundAccept;
        private System.Windows.Forms.ToolStrip Step2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip Step3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton PlayBTN;
        private System.Windows.Forms.ToolStrip Step4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton PauseBTN;
        private System.Windows.Forms.ToolStrip Step5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton StopBTN;
        private System.Windows.Forms.ToolStrip Step6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BellBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TMinBox;
        private System.Windows.Forms.TextBox TSecBox;
        private System.Windows.Forms.TextBox TMilBox;
        private System.Windows.Forms.ToolStripTextBox RestTimeBX;
        private System.Windows.Forms.ToolStripButton RestAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TTimer;
        private System.Windows.Forms.Timer RestTMR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RSecBox;
        private System.Windows.Forms.TextBox RMilBox;
    }
}

