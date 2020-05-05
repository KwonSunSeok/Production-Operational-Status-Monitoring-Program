namespace 생산_가동_현황_모니터링_프로그램
{
    partial class Operation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operation));
            this.list_Operation = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_APM = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_C1 = new System.Windows.Forms.Label();
            this.pb_C1 = new System.Windows.Forms.PictureBox();
            this.label_C2 = new System.Windows.Forms.Label();
            this.pb_C2 = new System.Windows.Forms.PictureBox();
            this.label_C3 = new System.Windows.Forms.Label();
            this.pb_C3 = new System.Windows.Forms.PictureBox();
            this.label_A1 = new System.Windows.Forms.Label();
            this.pb_A1 = new System.Windows.Forms.PictureBox();
            this.label_B1 = new System.Windows.Forms.Label();
            this.pb_B1 = new System.Windows.Forms.PictureBox();
            this.label_B2 = new System.Windows.Forms.Label();
            this.pb_B2 = new System.Windows.Forms.PictureBox();
            this.btn_timerStart = new System.Windows.Forms.Button();
            this.btn_timerStop = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_B2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // list_Operation
            // 
            this.list_Operation.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.list_Operation.FullRowSelect = true;
            this.list_Operation.HideSelection = false;
            this.list_Operation.Location = new System.Drawing.Point(1052, 162);
            this.list_Operation.Name = "list_Operation";
            this.list_Operation.Size = new System.Drawing.Size(696, 686);
            this.list_Operation.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_Operation.TabIndex = 2;
            this.list_Operation.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Time);
            this.groupBox1.Controls.Add(this.label_APM);
            this.groupBox1.Controls.Add(this.label_Date);
            this.groupBox1.Controls.Add(this.label_C1);
            this.groupBox1.Controls.Add(this.pb_C1);
            this.groupBox1.Controls.Add(this.label_C2);
            this.groupBox1.Controls.Add(this.pb_C2);
            this.groupBox1.Controls.Add(this.label_C3);
            this.groupBox1.Controls.Add(this.pb_C3);
            this.groupBox1.Controls.Add(this.label_A1);
            this.groupBox1.Controls.Add(this.pb_A1);
            this.groupBox1.Controls.Add(this.label_B1);
            this.groupBox1.Controls.Add(this.pb_B1);
            this.groupBox1.Controls.Add(this.label_B2);
            this.groupBox1.Controls.Add(this.pb_B2);
            this.groupBox1.Controls.Add(this.btn_timerStart);
            this.groupBox1.Controls.Add(this.btn_timerStop);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.list_Operation);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1754, 927);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.label_Time.Location = new System.Drawing.Point(1645, 74);
            this.label_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(103, 30);
            this.label_Time.TabIndex = 121;
            this.label_Time.Text = "00:00:00";
            // 
            // label_APM
            // 
            this.label_APM.AutoSize = true;
            this.label_APM.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.label_APM.Location = new System.Drawing.Point(1592, 74);
            this.label_APM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_APM.Name = "label_APM";
            this.label_APM.Size = new System.Drawing.Size(57, 30);
            this.label_APM.TabIndex = 122;
            this.label_APM.Text = "오전";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.label_Date.Location = new System.Drawing.Point(1418, 74);
            this.label_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(175, 30);
            this.label_Date.TabIndex = 123;
            this.label_Date.Text = "0000.00.00 (일)";
            // 
            // label_C1
            // 
            this.label_C1.AutoSize = true;
            this.label_C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.label_C1.Font = new System.Drawing.Font("맑은 고딕", 50F, System.Drawing.FontStyle.Bold);
            this.label_C1.ForeColor = System.Drawing.Color.White;
            this.label_C1.Location = new System.Drawing.Point(809, 417);
            this.label_C1.Name = "label_C1";
            this.label_C1.Size = new System.Drawing.Size(120, 89);
            this.label_C1.TabIndex = 74;
            this.label_C1.Text = "C1";
            // 
            // pb_C1
            // 
            this.pb_C1.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
            this.pb_C1.Location = new System.Drawing.Point(779, 386);
            this.pb_C1.Name = "pb_C1";
            this.pb_C1.Size = new System.Drawing.Size(180, 150);
            this.pb_C1.TabIndex = 73;
            this.pb_C1.TabStop = false;
            // 
            // label_C2
            // 
            this.label_C2.AutoSize = true;
            this.label_C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.label_C2.Font = new System.Drawing.Font("맑은 고딕", 50F, System.Drawing.FontStyle.Bold);
            this.label_C2.ForeColor = System.Drawing.Color.White;
            this.label_C2.Location = new System.Drawing.Point(809, 573);
            this.label_C2.Name = "label_C2";
            this.label_C2.Size = new System.Drawing.Size(120, 89);
            this.label_C2.TabIndex = 71;
            this.label_C2.Text = "C2";
            // 
            // pb_C2
            // 
            this.pb_C2.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
            this.pb_C2.Location = new System.Drawing.Point(779, 542);
            this.pb_C2.Name = "pb_C2";
            this.pb_C2.Size = new System.Drawing.Size(180, 150);
            this.pb_C2.TabIndex = 70;
            this.pb_C2.TabStop = false;
            // 
            // label_C3
            // 
            this.label_C3.AutoSize = true;
            this.label_C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.label_C3.Font = new System.Drawing.Font("맑은 고딕", 50F, System.Drawing.FontStyle.Bold);
            this.label_C3.ForeColor = System.Drawing.Color.White;
            this.label_C3.Location = new System.Drawing.Point(809, 729);
            this.label_C3.Name = "label_C3";
            this.label_C3.Size = new System.Drawing.Size(120, 89);
            this.label_C3.TabIndex = 69;
            this.label_C3.Text = "C3";
            // 
            // pb_C3
            // 
            this.pb_C3.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
            this.pb_C3.Location = new System.Drawing.Point(779, 698);
            this.pb_C3.Name = "pb_C3";
            this.pb_C3.Size = new System.Drawing.Size(180, 150);
            this.pb_C3.TabIndex = 68;
            this.pb_C3.TabStop = false;
            // 
            // label_A1
            // 
            this.label_A1.AutoSize = true;
            this.label_A1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.label_A1.Font = new System.Drawing.Font("맑은 고딕", 72F, System.Drawing.FontStyle.Bold);
            this.label_A1.ForeColor = System.Drawing.Color.White;
            this.label_A1.Location = new System.Drawing.Point(165, 634);
            this.label_A1.Name = "label_A1";
            this.label_A1.Size = new System.Drawing.Size(179, 128);
            this.label_A1.TabIndex = 67;
            this.label_A1.Text = "A1";
            // 
            // pb_A1
            // 
            this.pb_A1.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
            this.pb_A1.Location = new System.Drawing.Point(74, 548);
            this.pb_A1.Name = "pb_A1";
            this.pb_A1.Size = new System.Drawing.Size(360, 300);
            this.pb_A1.TabIndex = 66;
            this.pb_A1.TabStop = false;
            // 
            // label_B1
            // 
            this.label_B1.AutoSize = true;
            this.label_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.label_B1.Font = new System.Drawing.Font("맑은 고딕", 72F, System.Drawing.FontStyle.Bold);
            this.label_B1.ForeColor = System.Drawing.Color.White;
            this.label_B1.Location = new System.Drawing.Point(128, 196);
            this.label_B1.Name = "label_B1";
            this.label_B1.Size = new System.Drawing.Size(172, 128);
            this.label_B1.TabIndex = 65;
            this.label_B1.Text = "B1";
            // 
            // pb_B1
            // 
            this.pb_B1.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
            this.pb_B1.Location = new System.Drawing.Point(74, 160);
            this.pb_B1.Name = "pb_B1";
            this.pb_B1.Size = new System.Drawing.Size(280, 200);
            this.pb_B1.TabIndex = 64;
            this.pb_B1.TabStop = false;
            // 
            // label_B2
            // 
            this.label_B2.AutoSize = true;
            this.label_B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(255)))));
            this.label_B2.Font = new System.Drawing.Font("맑은 고딕", 72F, System.Drawing.FontStyle.Bold);
            this.label_B2.ForeColor = System.Drawing.Color.White;
            this.label_B2.Location = new System.Drawing.Point(414, 196);
            this.label_B2.Name = "label_B2";
            this.label_B2.Size = new System.Drawing.Size(172, 128);
            this.label_B2.TabIndex = 63;
            this.label_B2.Text = "B2";
            // 
            // pb_B2
            // 
            this.pb_B2.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
            this.pb_B2.Location = new System.Drawing.Point(360, 160);
            this.pb_B2.Name = "pb_B2";
            this.pb_B2.Size = new System.Drawing.Size(280, 200);
            this.pb_B2.TabIndex = 62;
            this.pb_B2.TabStop = false;
            // 
            // btn_timerStart
            // 
            this.btn_timerStart.BackColor = System.Drawing.Color.White;
            this.btn_timerStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_timerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timerStart.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.btn_timerStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timerStart.Location = new System.Drawing.Point(1342, 117);
            this.btn_timerStart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timerStart.Name = "btn_timerStart";
            this.btn_timerStart.Size = new System.Drawing.Size(179, 40);
            this.btn_timerStart.TabIndex = 60;
            this.btn_timerStart.Text = "자동갱신START";
            this.btn_timerStart.UseVisualStyleBackColor = false;
            this.btn_timerStart.Click += new System.EventHandler(this.btn_timerStart_Click);
            // 
            // btn_timerStop
            // 
            this.btn_timerStop.BackColor = System.Drawing.Color.White;
            this.btn_timerStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_timerStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timerStop.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.btn_timerStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timerStop.Location = new System.Drawing.Point(1525, 117);
            this.btn_timerStop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timerStop.Name = "btn_timerStop";
            this.btn_timerStop.Size = new System.Drawing.Size(179, 40);
            this.btn_timerStop.TabIndex = 59;
            this.btn_timerStop.Text = "자동갱신STOP";
            this.btn_timerStop.UseVisualStyleBackColor = false;
            this.btn_timerStop.Click += new System.EventHandler(this.btn_timerStop_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Cancel.Location = new System.Drawing.Point(796, 890);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(163, 32);
            this.btn_Cancel.TabIndex = 54;
            this.btn_Cancel.Text = "나가기";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(702, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 65);
            this.label1.TabIndex = 52;
            this.label1.Text = "생산 가동 현황";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.BackgroundImage")));
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Refresh.Location = new System.Drawing.Point(1708, 117);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(40, 40);
            this.btn_Refresh.TabIndex = 51;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\프로젝트Image\\생산 가동 현황 배경.png";
            this.pictureBox1.Location = new System.Drawing.Point(67, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(901, 701);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.groupBox1);
            this.Name = "Operation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Operation_FormClosed);
            this.Load += new System.EventHandler(this.Operation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_B2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView list_Operation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_timerStop;
        private System.Windows.Forms.Button btn_timerStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_B1;
        private System.Windows.Forms.PictureBox pb_B1;
        private System.Windows.Forms.Label label_B2;
        private System.Windows.Forms.PictureBox pb_B2;
        private System.Windows.Forms.Label label_C1;
        private System.Windows.Forms.PictureBox pb_C1;
        private System.Windows.Forms.Label label_C2;
        private System.Windows.Forms.PictureBox pb_C2;
        private System.Windows.Forms.Label label_C3;
        private System.Windows.Forms.PictureBox pb_C3;
        private System.Windows.Forms.Label label_A1;
        private System.Windows.Forms.PictureBox pb_A1;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_APM;
        private System.Windows.Forms.Label label_Date;
    }
}