namespace 생산_가동_현황_모니터링_프로그램
{
    partial class CommutingTime
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
            this.list_Commute = new System.Windows.Forms.ListView();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_APM = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gotoWork = new System.Windows.Forms.Button();
            this.btn_leaveWork = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_gotoWork);
            this.groupBox1.Controls.Add(this.btn_leaveWork);
            this.groupBox1.Controls.Add(this.list_Commute);
            this.groupBox1.Controls.Add(this.label_Time);
            this.groupBox1.Controls.Add(this.label_APM);
            this.groupBox1.Controls.Add(this.label_Date);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(83, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1754, 927);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // list_Commute
            // 
            this.list_Commute.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.list_Commute.FullRowSelect = true;
            this.list_Commute.HideSelection = false;
            this.list_Commute.Location = new System.Drawing.Point(31, 110);
            this.list_Commute.Margin = new System.Windows.Forms.Padding(2);
            this.list_Commute.Name = "list_Commute";
            this.list_Commute.Size = new System.Drawing.Size(1689, 753);
            this.list_Commute.TabIndex = 121;
            this.list_Commute.UseCompatibleStateImageBehavior = false;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.label_Time.Location = new System.Drawing.Point(1617, 78);
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
            this.label_APM.Location = new System.Drawing.Point(1564, 78);
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
            this.label_Date.Location = new System.Drawing.Point(1390, 78);
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
            this.label1.Location = new System.Drawing.Point(735, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "출퇴근 관리";
            // 
            // btn_gotoWork
            // 
            this.btn_gotoWork.BackColor = System.Drawing.Color.White;
            this.btn_gotoWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_gotoWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gotoWork.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.btn_gotoWork.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_gotoWork.Location = new System.Drawing.Point(1520, 36);
            this.btn_gotoWork.Margin = new System.Windows.Forms.Padding(2);
            this.btn_gotoWork.Name = "btn_gotoWork";
            this.btn_gotoWork.Size = new System.Drawing.Size(98, 40);
            this.btn_gotoWork.TabIndex = 125;
            this.btn_gotoWork.Text = "출근";
            this.btn_gotoWork.UseVisualStyleBackColor = false;
            this.btn_gotoWork.Click += new System.EventHandler(this.btn_gotoWork_Click);
            // 
            // btn_leaveWork
            // 
            this.btn_leaveWork.BackColor = System.Drawing.Color.White;
            this.btn_leaveWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_leaveWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leaveWork.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.btn_leaveWork.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_leaveWork.Location = new System.Drawing.Point(1622, 36);
            this.btn_leaveWork.Margin = new System.Windows.Forms.Padding(2);
            this.btn_leaveWork.Name = "btn_leaveWork";
            this.btn_leaveWork.Size = new System.Drawing.Size(98, 40);
            this.btn_leaveWork.TabIndex = 124;
            this.btn_leaveWork.Text = "퇴근";
            this.btn_leaveWork.UseVisualStyleBackColor = false;
            this.btn_leaveWork.Click += new System.EventHandler(this.btn_leaveWork_Click);
            // 
            // CommutingTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.groupBox1);
            this.Name = "CommutingTime";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CommutingTime_FormClosed);
            this.Load += new System.EventHandler(this.CommutingTime_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView list_Commute;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_APM;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gotoWork;
        private System.Windows.Forms.Button btn_leaveWork;
    }
}