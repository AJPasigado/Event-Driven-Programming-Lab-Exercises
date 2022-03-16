namespace Lab3_Login {
    partial class StartScreen {
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
            this.LogoutBTN = new System.Windows.Forms.Button();
            this.WelcomeLBL = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.AnimationTMR = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.StartPNL = new System.Windows.Forms.Panel();
            this.FlowAnimation = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LoginPNL = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserManBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.StartPNL.SuspendLayout();
            this.LoginPNL.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutBTN
            // 
            this.LogoutBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.LogoutBTN.FlatAppearance.BorderSize = 0;
            this.LogoutBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.LogoutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.LogoutBTN.ForeColor = System.Drawing.Color.White;
            this.LogoutBTN.Location = new System.Drawing.Point(719, 6);
            this.LogoutBTN.Name = "LogoutBTN";
            this.LogoutBTN.Size = new System.Drawing.Size(80, 30);
            this.LogoutBTN.TabIndex = 6;
            this.LogoutBTN.Text = "LOGOUT";
            this.LogoutBTN.UseVisualStyleBackColor = false;
            this.LogoutBTN.Visible = false;
            this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
            // 
            // WelcomeLBL
            // 
            this.WelcomeLBL.AutoSize = true;
            this.WelcomeLBL.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLBL.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLBL.ForeColor = System.Drawing.Color.White;
            this.WelcomeLBL.Location = new System.Drawing.Point(307, 105);
            this.WelcomeLBL.Name = "WelcomeLBL";
            this.WelcomeLBL.Size = new System.Drawing.Size(193, 45);
            this.WelcomeLBL.TabIndex = 7;
            this.WelcomeLBL.Text = "Hello, Super!";
            this.WelcomeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLBL.Click += new System.EventHandler(this.WelcomeLBL_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.CloseBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBTN.FlatAppearance.BorderSize = 0;
            this.CloseBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.CloseBTN.ForeColor = System.Drawing.Color.White;
            this.CloseBTN.Location = new System.Drawing.Point(811, 6);
            this.CloseBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(30, 30);
            this.CloseBTN.TabIndex = 7;
            this.CloseBTN.Text = "X";
            this.CloseBTN.UseVisualStyleBackColor = false;
            this.CloseBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnimationTMR
            // 
            this.AnimationTMR.Interval = 1;
            this.AnimationTMR.Tick += new System.EventHandler(this.AnimationTMR_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.UserManBTN);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(168, 227);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(557, 373);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(371, 156);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(120, 21);
            this.DateLabel.TabIndex = 12;
            this.DateLabel.Text = "January 30, 2017";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartPNL
            // 
            this.StartPNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartPNL.Controls.Add(this.WelcomeLBL);
            this.StartPNL.Controls.Add(this.flowLayoutPanel1);
            this.StartPNL.Controls.Add(this.DateLabel);
            this.StartPNL.Location = new System.Drawing.Point(850, 0);
            this.StartPNL.Name = "StartPNL";
            this.StartPNL.Size = new System.Drawing.Size(850, 600);
            this.StartPNL.TabIndex = 14;
            this.StartPNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.StartPNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.StartPNL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // FlowAnimation
            // 
            this.FlowAnimation.Interval = 1;
            this.FlowAnimation.Tick += new System.EventHandler(this.FlowAnimation_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(137, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Please enter your credentials.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(140, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "USERNAME";
            // 
            // PassBox
            // 
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.Location = new System.Drawing.Point(141, 329);
            this.PassBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '●';
            this.PassBox.Size = new System.Drawing.Size(197, 25);
            this.PassBox.TabIndex = 1;
            this.PassBox.Enter += new System.EventHandler(this.txtPass_Enter);
            this.PassBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(142, 273);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(197, 25);
            this.txtUser.TabIndex = 0;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(191, 390);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "LOGIN";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(139, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(182, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 54);
            this.label1.TabIndex = 17;
            this.label1.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(76, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 54);
            this.label5.TabIndex = 22;
            this.label5.Text = "Welcome to";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(98, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 65);
            this.label6.TabIndex = 23;
            this.label6.Text = "SADDB";
            // 
            // LoginPNL
            // 
            this.LoginPNL.BackColor = System.Drawing.Color.White;
            this.LoginPNL.Controls.Add(this.pictureBox1);
            this.LoginPNL.Controls.Add(this.panel2);
            this.LoginPNL.Controls.Add(this.label1);
            this.LoginPNL.Controls.Add(this.PassBox);
            this.LoginPNL.Controls.Add(this.label3);
            this.LoginPNL.Controls.Add(this.label2);
            this.LoginPNL.Controls.Add(this.txtUser);
            this.LoginPNL.Controls.Add(this.button3);
            this.LoginPNL.Controls.Add(this.label4);
            this.LoginPNL.Controls.Add(this.label7);
            this.LoginPNL.Controls.Add(this.label8);
            this.LoginPNL.Location = new System.Drawing.Point(0, 0);
            this.LoginPNL.Name = "LoginPNL";
            this.LoginPNL.Size = new System.Drawing.Size(850, 600);
            this.LoginPNL.TabIndex = 13;
            this.LoginPNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.LoginPNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.LoginPNL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(489, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 600);
            this.panel2.TabIndex = 23;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "_________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "_________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Lab3_Login.Properties.Resources.eYE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Lab3_Login.Properties.Resources.eYE;
            this.pictureBox1.Location = new System.Drawing.Point(311, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 17);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // UserManBTN
            // 
            this.UserManBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.UserManBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.UserManBTN.FlatAppearance.BorderSize = 3;
            this.UserManBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.UserManBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.UserManBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManBTN.ForeColor = System.Drawing.Color.White;
            this.UserManBTN.Image = global::Lab3_Login.Properties.Resources.UserMNG;
            this.UserManBTN.Location = new System.Drawing.Point(3, 3);
            this.UserManBTN.Name = "UserManBTN";
            this.UserManBTN.Size = new System.Drawing.Size(178, 171);
            this.UserManBTN.TabIndex = 3;
            this.UserManBTN.Text = "User Management";
            this.UserManBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UserManBTN.UseVisualStyleBackColor = false;
            this.UserManBTN.Visible = false;
            this.UserManBTN.Click += new System.EventHandler(this.UserManBTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Lab3_Login.Properties.Resources.Temp;
            this.button1.Location = new System.Drawing.Point(187, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 171);
            this.button1.TabIndex = 4;
            this.button1.Text = "Module 2";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(161)))), ((int)(((byte)(206)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Lab3_Login.Properties.Resources.Settings;
            this.button2.Location = new System.Drawing.Point(371, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 171);
            this.button2.TabIndex = 5;
            this.button2.Text = "Settings";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.CancelButton = this.CloseBTN;
            this.ClientSize = new System.Drawing.Size(848, 598);
            this.ControlBox = false;
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.LogoutBTN);
            this.Controls.Add(this.LoginPNL);
            this.Controls.Add(this.StartPNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginMain_FormClosed);
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartScreen_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartScreen_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.StartPNL.ResumeLayout(false);
            this.StartPNL.PerformLayout();
            this.LoginPNL.ResumeLayout(false);
            this.LoginPNL.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogoutBTN;
        private System.Windows.Forms.Button UserManBTN;
        private System.Windows.Forms.Label WelcomeLBL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Timer AnimationTMR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Panel StartPNL;
        private System.Windows.Forms.Timer FlowAnimation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel LoginPNL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}