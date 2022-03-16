namespace Midterm_Lab {
    partial class SimpleGame {
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
            this.GameBTN = new System.Windows.Forms.Button();
            this.PlayBTN = new System.Windows.Forms.Button();
            this.AgainBTN = new System.Windows.Forms.Button();
            this.CompScoreLBL = new System.Windows.Forms.Label();
            this.PlayerScoreLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputTXTBX = new System.Windows.Forms.TextBox();
            this.PicTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeTMR = new System.Windows.Forms.Timer(this.components);
            this.ScissorsBTN = new System.Windows.Forms.Button();
            this.RockBTN = new System.Windows.Forms.Button();
            this.PaperBTN = new System.Windows.Forms.Button();
            this.PlayerPIC = new System.Windows.Forms.PictureBox();
            this.CompPIC = new System.Windows.Forms.PictureBox();
            this.MinBox = new System.Windows.Forms.Label();
            this.SecBox = new System.Windows.Forms.Label();
            this.MilBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SetBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompPIC)).BeginInit();
            this.SuspendLayout();
            // 
            // GameBTN
            // 
            this.GameBTN.BackColor = System.Drawing.Color.DarkGray;
            this.GameBTN.FlatAppearance.BorderSize = 0;
            this.GameBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameBTN.ForeColor = System.Drawing.Color.White;
            this.GameBTN.Location = new System.Drawing.Point(34, 21);
            this.GameBTN.Name = "GameBTN";
            this.GameBTN.Size = new System.Drawing.Size(135, 45);
            this.GameBTN.TabIndex = 0;
            this.GameBTN.Text = "GAME ON!";
            this.GameBTN.UseVisualStyleBackColor = false;
            this.GameBTN.Click += new System.EventHandler(this.GameBTN_Click);
            // 
            // PlayBTN
            // 
            this.PlayBTN.BackColor = System.Drawing.Color.DarkGray;
            this.PlayBTN.FlatAppearance.BorderSize = 0;
            this.PlayBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBTN.ForeColor = System.Drawing.Color.White;
            this.PlayBTN.Location = new System.Drawing.Point(190, 110);
            this.PlayBTN.Name = "PlayBTN";
            this.PlayBTN.Size = new System.Drawing.Size(99, 36);
            this.PlayBTN.TabIndex = 1;
            this.PlayBTN.Text = "PLAY";
            this.PlayBTN.UseVisualStyleBackColor = false;
            this.PlayBTN.Click += new System.EventHandler(this.PlayBTN_Click);
            // 
            // AgainBTN
            // 
            this.AgainBTN.BackColor = System.Drawing.Color.DarkGray;
            this.AgainBTN.FlatAppearance.BorderSize = 0;
            this.AgainBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgainBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgainBTN.ForeColor = System.Drawing.Color.White;
            this.AgainBTN.Location = new System.Drawing.Point(190, 152);
            this.AgainBTN.Name = "AgainBTN";
            this.AgainBTN.Size = new System.Drawing.Size(99, 36);
            this.AgainBTN.TabIndex = 2;
            this.AgainBTN.Text = "AGAIN";
            this.AgainBTN.UseVisualStyleBackColor = false;
            this.AgainBTN.Click += new System.EventHandler(this.AgainBTN_Click);
            // 
            // CompScoreLBL
            // 
            this.CompScoreLBL.AutoSize = true;
            this.CompScoreLBL.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompScoreLBL.ForeColor = System.Drawing.Color.IndianRed;
            this.CompScoreLBL.Location = new System.Drawing.Point(78, 240);
            this.CompScoreLBL.Name = "CompScoreLBL";
            this.CompScoreLBL.Size = new System.Drawing.Size(32, 37);
            this.CompScoreLBL.TabIndex = 5;
            this.CompScoreLBL.Text = "0";
            // 
            // PlayerScoreLBL
            // 
            this.PlayerScoreLBL.AutoSize = true;
            this.PlayerScoreLBL.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScoreLBL.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.PlayerScoreLBL.Location = new System.Drawing.Point(357, 240);
            this.PlayerScoreLBL.Name = "PlayerScoreLBL";
            this.PlayerScoreLBL.Size = new System.Drawing.Size(32, 37);
            this.PlayerScoreLBL.TabIndex = 6;
            this.PlayerScoreLBL.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(31, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time limit in seconds:";
            // 
            // InputTXTBX
            // 
            this.InputTXTBX.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTXTBX.Location = new System.Drawing.Point(190, 324);
            this.InputTXTBX.Name = "InputTXTBX";
            this.InputTXTBX.Size = new System.Drawing.Size(155, 29);
            this.InputTXTBX.TabIndex = 14;
            this.InputTXTBX.Text = "10";
            this.InputTXTBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PicTimer
            // 
            this.PicTimer.Interval = 1;
            this.PicTimer.Tick += new System.EventHandler(this.PicTimer_Tick);
            // 
            // TimeTMR
            // 
            this.TimeTMR.Interval = 1;
            this.TimeTMR.Tick += new System.EventHandler(this.TimeTMR_Tick);
            // 
            // ScissorsBTN
            // 
            this.ScissorsBTN.FlatAppearance.BorderSize = 0;
            this.ScissorsBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ScissorsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScissorsBTN.Image = global::Midterm_Lab.Properties.Resources.scissors;
            this.ScissorsBTN.Location = new System.Drawing.Point(487, 290);
            this.ScissorsBTN.Name = "ScissorsBTN";
            this.ScissorsBTN.Size = new System.Drawing.Size(133, 132);
            this.ScissorsBTN.TabIndex = 13;
            this.ScissorsBTN.UseVisualStyleBackColor = true;
            this.ScissorsBTN.Click += new System.EventHandler(this.ScissorsBTN_Click);
            // 
            // RockBTN
            // 
            this.RockBTN.FlatAppearance.BorderSize = 0;
            this.RockBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.RockBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RockBTN.Image = global::Midterm_Lab.Properties.Resources.rock;
            this.RockBTN.Location = new System.Drawing.Point(487, 150);
            this.RockBTN.Name = "RockBTN";
            this.RockBTN.Size = new System.Drawing.Size(133, 132);
            this.RockBTN.TabIndex = 12;
            this.RockBTN.UseVisualStyleBackColor = true;
            this.RockBTN.Click += new System.EventHandler(this.RockBTN_Click);
            // 
            // PaperBTN
            // 
            this.PaperBTN.FlatAppearance.BorderSize = 0;
            this.PaperBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.PaperBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaperBTN.Image = global::Midterm_Lab.Properties.Resources.paper;
            this.PaperBTN.Location = new System.Drawing.Point(487, 12);
            this.PaperBTN.Name = "PaperBTN";
            this.PaperBTN.Size = new System.Drawing.Size(133, 132);
            this.PaperBTN.TabIndex = 11;
            this.PaperBTN.UseVisualStyleBackColor = true;
            this.PaperBTN.Click += new System.EventHandler(this.PaperBTN_Click);
            // 
            // PlayerPIC
            // 
            this.PlayerPIC.Image = global::Midterm_Lab.Properties.Resources.Hide;
            this.PlayerPIC.Location = new System.Drawing.Point(306, 85);
            this.PlayerPIC.Name = "PlayerPIC";
            this.PlayerPIC.Size = new System.Drawing.Size(135, 131);
            this.PlayerPIC.TabIndex = 4;
            this.PlayerPIC.TabStop = false;
            // 
            // CompPIC
            // 
            this.CompPIC.Image = global::Midterm_Lab.Properties.Resources.Hide;
            this.CompPIC.Location = new System.Drawing.Point(34, 85);
            this.CompPIC.Name = "CompPIC";
            this.CompPIC.Size = new System.Drawing.Size(135, 131);
            this.CompPIC.TabIndex = 3;
            this.CompPIC.TabStop = false;
            // 
            // MinBox
            // 
            this.MinBox.AutoSize = true;
            this.MinBox.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBox.ForeColor = System.Drawing.Color.Gray;
            this.MinBox.Location = new System.Drawing.Point(225, 21);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(47, 37);
            this.MinBox.TabIndex = 15;
            this.MinBox.Text = "00";
            // 
            // SecBox
            // 
            this.SecBox.AutoSize = true;
            this.SecBox.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecBox.ForeColor = System.Drawing.Color.Gray;
            this.SecBox.Location = new System.Drawing.Point(279, 21);
            this.SecBox.Name = "SecBox";
            this.SecBox.Size = new System.Drawing.Size(47, 37);
            this.SecBox.TabIndex = 16;
            this.SecBox.Text = "00";
            // 
            // MilBox
            // 
            this.MilBox.AutoSize = true;
            this.MilBox.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilBox.ForeColor = System.Drawing.Color.Gray;
            this.MilBox.Location = new System.Drawing.Point(335, 21);
            this.MilBox.Name = "MilBox";
            this.MilBox.Size = new System.Drawing.Size(47, 37);
            this.MilBox.TabIndex = 17;
            this.MilBox.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(263, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(318, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = ":";
            // 
            // SetBTN
            // 
            this.SetBTN.BackColor = System.Drawing.Color.DarkGray;
            this.SetBTN.FlatAppearance.BorderSize = 0;
            this.SetBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetBTN.ForeColor = System.Drawing.Color.White;
            this.SetBTN.Location = new System.Drawing.Point(351, 324);
            this.SetBTN.Name = "SetBTN";
            this.SetBTN.Size = new System.Drawing.Size(77, 29);
            this.SetBTN.TabIndex = 20;
            this.SetBTN.Text = "SET";
            this.SetBTN.UseVisualStyleBackColor = false;
            this.SetBTN.Click += new System.EventHandler(this.SetBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 445);
            this.Controls.Add(this.SetBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MilBox);
            this.Controls.Add(this.SecBox);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.InputTXTBX);
            this.Controls.Add(this.ScissorsBTN);
            this.Controls.Add(this.RockBTN);
            this.Controls.Add(this.PaperBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayerScoreLBL);
            this.Controls.Add(this.CompScoreLBL);
            this.Controls.Add(this.PlayerPIC);
            this.Controls.Add(this.CompPIC);
            this.Controls.Add(this.AgainBTN);
            this.Controls.Add(this.PlayBTN);
            this.Controls.Add(this.GameBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Game";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompPIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameBTN;
        private System.Windows.Forms.Button PlayBTN;
        private System.Windows.Forms.Button AgainBTN;
        private System.Windows.Forms.PictureBox CompPIC;
        private System.Windows.Forms.PictureBox PlayerPIC;
        private System.Windows.Forms.Label CompScoreLBL;
        private System.Windows.Forms.Label PlayerScoreLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PaperBTN;
        private System.Windows.Forms.Button RockBTN;
        private System.Windows.Forms.Button ScissorsBTN;
        private System.Windows.Forms.TextBox InputTXTBX;
        private System.Windows.Forms.Timer PicTimer;
        private System.Windows.Forms.Timer TimeTMR;
        private System.Windows.Forms.Label MinBox;
        private System.Windows.Forms.Label SecBox;
        private System.Windows.Forms.Label MilBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SetBTN;
    }
}

