namespace 생산_가동_현황_모니터링_프로그램
{
    partial class ComMonitoring
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_timerStart = new System.Windows.Forms.Button();
            this.btn_timerStop = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_APM = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_timerStart);
            this.groupBox1.Controls.Add(this.btn_timerStop);
            this.groupBox1.Controls.Add(this.listView);
            this.groupBox1.Controls.Add(this.label_Time);
            this.groupBox1.Controls.Add(this.label_APM);
            this.groupBox1.Controls.Add(this.label_Date);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(92, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1754, 927);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_timerStart
            // 
            this.btn_timerStart.BackColor = System.Drawing.Color.White;
            this.btn_timerStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_timerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timerStart.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.btn_timerStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timerStart.Location = new System.Drawing.Point(1358, 66);
            this.btn_timerStart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timerStart.Name = "btn_timerStart";
            this.btn_timerStart.Size = new System.Drawing.Size(179, 40);
            this.btn_timerStart.TabIndex = 123;
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
            this.btn_timerStop.Location = new System.Drawing.Point(1541, 66);
            this.btn_timerStop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timerStop.Name = "btn_timerStop";
            this.btn_timerStop.Size = new System.Drawing.Size(179, 40);
            this.btn_timerStop.TabIndex = 122;
            this.btn_timerStop.Text = "자동갱신STOP";
            this.btn_timerStop.UseVisualStyleBackColor = false;
            this.btn_timerStop.Click += new System.EventHandler(this.btn_timerStop_Click);
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(31, 110);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1689, 753);
            this.listView.TabIndex = 121;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.label_Time.Location = new System.Drawing.Point(1617, 34);
            this.label_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(103, 30);
            this.label_Time.TabIndex = 120;
            this.label_Time.Text = "00:00:00";
            // 
            // label_APM
            // 
            this.label_APM.AutoSize = true;
            this.label_APM.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.label_APM.Location = new System.Drawing.Point(1564, 34);
            this.label_APM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_APM.Name = "label_APM";
            this.label_APM.Size = new System.Drawing.Size(57, 30);
            this.label_APM.TabIndex = 120;
            this.label_APM.Text = "오전";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.label_Date.Location = new System.Drawing.Point(1390, 34);
            this.label_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(175, 30);
            this.label_Date.TabIndex = 120;
            this.label_Date.Text = "0000.00.00 (일)";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Cancel.Location = new System.Drawing.Point(797, 887);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(160, 40);
            this.btn_Cancel.TabIndex = 117;
            this.btn_Cancel.Text = "나가기";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(710, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "종합 모니터링";
            // 
            // ComMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ComMonitoring";
            this.Padding = new System.Windows.Forms.Padding(16, 60, 16, 16);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComMonitoring_FormClosed);
            this.Load += new System.EventHandler(this.ComMonitoring_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_APM;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btn_timerStart;
        private System.Windows.Forms.Button btn_timerStop;
    }
}