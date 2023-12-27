namespace VCaro
{
    partial class FVCaro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVCaro));
            this.BTNew = new System.Windows.Forms.Button();
            this.BTUndo = new System.Windows.Forms.Button();
            this.PNCaroBoard = new System.Windows.Forms.Panel();
            this.BTHM = new System.Windows.Forms.Button();
            this.LBCPUTime = new System.Windows.Forms.Label();
            this.TMMoveTime = new System.Windows.Forms.Timer(this.components);
            this.LBHMTime = new System.Windows.Forms.Label();
            this.GBDifficulty = new System.Windows.Forms.GroupBox();
            this.RBVeryHard = new System.Windows.Forms.RadioButton();
            this.RBHard = new System.Windows.Forms.RadioButton();
            this.RBNormal = new System.Windows.Forms.RadioButton();
            this.RBEasy = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PBHM = new System.Windows.Forms.PictureBox();
            this.PBCPU = new System.Windows.Forms.PictureBox();
            this.GBDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNew
            // 
            this.BTNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(190)))));
            this.BTNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNew.FlatAppearance.BorderSize = 0;
            this.BTNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNew.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNew.ForeColor = System.Drawing.Color.White;
            this.BTNew.Image = ((System.Drawing.Image)(resources.GetObject("BTNew.Image")));
            this.BTNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNew.Location = new System.Drawing.Point(12, 519);
            this.BTNew.Name = "BTNew";
            this.BTNew.Size = new System.Drawing.Size(129, 41);
            this.BTNew.TabIndex = 1;
            this.BTNew.Text = "NEW GAME";
            this.BTNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNew.UseVisualStyleBackColor = false;
            this.BTNew.Click += new System.EventHandler(this.BTNew_Click);
            this.BTNew.MouseHover += new System.EventHandler(this.BTNew_MouseHover);
            // 
            // BTUndo
            // 
            this.BTUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(190)))));
            this.BTUndo.FlatAppearance.BorderSize = 0;
            this.BTUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTUndo.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold);
            this.BTUndo.ForeColor = System.Drawing.Color.White;
            this.BTUndo.Image = ((System.Drawing.Image)(resources.GetObject("BTUndo.Image")));
            this.BTUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTUndo.Location = new System.Drawing.Point(386, 519);
            this.BTUndo.Name = "BTUndo";
            this.BTUndo.Size = new System.Drawing.Size(87, 41);
            this.BTUndo.TabIndex = 2;
            this.BTUndo.Text = "Undo";
            this.BTUndo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTUndo.UseVisualStyleBackColor = false;
            this.BTUndo.Click += new System.EventHandler(this.BTUndo_Click);
            this.BTUndo.MouseHover += new System.EventHandler(this.BTNew_MouseHover);
            // 
            // PNCaroBoard
            // 
            this.PNCaroBoard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PNCaroBoard.Location = new System.Drawing.Point(12, 45);
            this.PNCaroBoard.Name = "PNCaroBoard";
            this.PNCaroBoard.Size = new System.Drawing.Size(461, 461);
            this.PNCaroBoard.TabIndex = 7;
            this.PNCaroBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.PNCaroBoard_Paint);
            this.PNCaroBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PNCaroBoard_MouseClick);
            // 
            // BTHM
            // 
            this.BTHM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(190)))));
            this.BTHM.FlatAppearance.BorderSize = 0;
            this.BTHM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTHM.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold);
            this.BTHM.ForeColor = System.Drawing.Color.White;
            this.BTHM.Image = ((System.Drawing.Image)(resources.GetObject("BTHM.Image")));
            this.BTHM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTHM.Location = new System.Drawing.Point(217, 519);
            this.BTHM.Name = "BTHM";
            this.BTHM.Size = new System.Drawing.Size(80, 41);
            this.BTHM.TabIndex = 10;
            this.BTHM.Text = "Help";
            this.BTHM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTHM.UseVisualStyleBackColor = false;
            this.BTHM.Click += new System.EventHandler(this.BTHM_Click);
            this.BTHM.MouseHover += new System.EventHandler(this.BTNew_MouseHover);
            // 
            // LBCPUTime
            // 
            this.LBCPUTime.AutoSize = true;
            this.LBCPUTime.BackColor = System.Drawing.Color.Transparent;
            this.LBCPUTime.ForeColor = System.Drawing.SystemColors.Control;
            this.LBCPUTime.Location = new System.Drawing.Point(552, 197);
            this.LBCPUTime.Name = "LBCPUTime";
            this.LBCPUTime.Size = new System.Drawing.Size(22, 13);
            this.LBCPUTime.TabIndex = 11;
            this.LBCPUTime.Text = "--:--";
            // 
            // TMMoveTime
            // 
            this.TMMoveTime.Enabled = true;
            this.TMMoveTime.Interval = 1000;
            this.TMMoveTime.Tick += new System.EventHandler(this.TMMoveTime_Tick);
            // 
            // LBHMTime
            // 
            this.LBHMTime.AutoSize = true;
            this.LBHMTime.BackColor = System.Drawing.Color.Transparent;
            this.LBHMTime.ForeColor = System.Drawing.SystemColors.Control;
            this.LBHMTime.Location = new System.Drawing.Point(552, 481);
            this.LBHMTime.Name = "LBHMTime";
            this.LBHMTime.Size = new System.Drawing.Size(22, 13);
            this.LBHMTime.TabIndex = 12;
            this.LBHMTime.Text = "--:--";
            // 
            // GBDifficulty
            // 
            this.GBDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.GBDifficulty.Controls.Add(this.RBVeryHard);
            this.GBDifficulty.Controls.Add(this.RBHard);
            this.GBDifficulty.Controls.Add(this.RBNormal);
            this.GBDifficulty.Controls.Add(this.RBEasy);
            this.GBDifficulty.ForeColor = System.Drawing.Color.White;
            this.GBDifficulty.Location = new System.Drawing.Point(505, 223);
            this.GBDifficulty.Name = "GBDifficulty";
            this.GBDifficulty.Size = new System.Drawing.Size(120, 118);
            this.GBDifficulty.TabIndex = 14;
            this.GBDifficulty.TabStop = false;
            this.GBDifficulty.Text = "Độ khó";
            // 
            // RBVeryHard
            // 
            this.RBVeryHard.AutoSize = true;
            this.RBVeryHard.Location = new System.Drawing.Point(7, 88);
            this.RBVeryHard.Name = "RBVeryHard";
            this.RBVeryHard.Size = new System.Drawing.Size(63, 17);
            this.RBVeryHard.TabIndex = 3;
            this.RBVeryHard.TabStop = true;
            this.RBVeryHard.Text = "Rất khó";
            this.RBVeryHard.UseVisualStyleBackColor = true;
            // 
            // RBHard
            // 
            this.RBHard.AutoSize = true;
            this.RBHard.Location = new System.Drawing.Point(7, 65);
            this.RBHard.Name = "RBHard";
            this.RBHard.Size = new System.Drawing.Size(44, 17);
            this.RBHard.TabIndex = 2;
            this.RBHard.TabStop = true;
            this.RBHard.Text = "Khó";
            this.RBHard.UseVisualStyleBackColor = true;
            // 
            // RBNormal
            // 
            this.RBNormal.AutoSize = true;
            this.RBNormal.Location = new System.Drawing.Point(7, 42);
            this.RBNormal.Name = "RBNormal";
            this.RBNormal.Size = new System.Drawing.Size(62, 17);
            this.RBNormal.TabIndex = 1;
            this.RBNormal.TabStop = true;
            this.RBNormal.Text = "Thường";
            this.RBNormal.UseVisualStyleBackColor = true;
            // 
            // RBEasy
            // 
            this.RBEasy.AutoSize = true;
            this.RBEasy.Location = new System.Drawing.Point(7, 20);
            this.RBEasy.Name = "RBEasy";
            this.RBEasy.Size = new System.Drawing.Size(39, 17);
            this.RBEasy.TabIndex = 0;
            this.RBEasy.TabStop = true;
            this.RBEasy.Text = "Dễ";
            this.RBEasy.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PBHM
            // 
            this.PBHM.Location = new System.Drawing.Point(505, 363);
            this.PBHM.Name = "PBHM";
            this.PBHM.Size = new System.Drawing.Size(120, 104);
            this.PBHM.TabIndex = 6;
            this.PBHM.TabStop = false;
            // 
            // PBCPU
            // 
            this.PBCPU.Location = new System.Drawing.Point(505, 86);
            this.PBCPU.Name = "PBCPU";
            this.PBCPU.Size = new System.Drawing.Size(120, 108);
            this.PBCPU.TabIndex = 5;
            this.PBCPU.TabStop = false;
            // 
            // FVCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 569);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GBDifficulty);
            this.Controls.Add(this.LBHMTime);
            this.Controls.Add(this.LBCPUTime);
            this.Controls.Add(this.BTHM);
            this.Controls.Add(this.PNCaroBoard);
            this.Controls.Add(this.PBHM);
            this.Controls.Add(this.PBCPU);
            this.Controls.Add(this.BTUndo);
            this.Controls.Add(this.BTNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FVCaro";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FVCaro_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.GBDifficulty.ResumeLayout(false);
            this.GBDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNew;
        private System.Windows.Forms.Button BTUndo;
        private System.Windows.Forms.PictureBox PBCPU;
        private System.Windows.Forms.PictureBox PBHM;
        private System.Windows.Forms.Panel PNCaroBoard;
        private System.Windows.Forms.Button BTHM;
        private System.Windows.Forms.Label LBCPUTime;
        private System.Windows.Forms.Timer TMMoveTime;
        private System.Windows.Forms.Label LBHMTime;
        private System.Windows.Forms.GroupBox GBDifficulty;
        private System.Windows.Forms.RadioButton RBVeryHard;
        private System.Windows.Forms.RadioButton RBHard;
        private System.Windows.Forms.RadioButton RBNormal;
        private System.Windows.Forms.RadioButton RBEasy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

