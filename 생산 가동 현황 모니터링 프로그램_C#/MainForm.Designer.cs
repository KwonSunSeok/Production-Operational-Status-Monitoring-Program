namespace 생산_가동_현황_모니터링_프로그램
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
            this.tb_Welcome = new System.Windows.Forms.TextBox();
            this.pb_LoginImage = new System.Windows.Forms.PictureBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_production = new System.Windows.Forms.Button();
            this.btn_performance = new System.Windows.Forms.Button();
            this.btn_operation = new System.Windows.Forms.Button();
            this.btn_comprehensive = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_commute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LoginImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Welcome
            // 
            this.tb_Welcome.BackColor = System.Drawing.Color.White;
            this.tb_Welcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Welcome.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_Welcome.Location = new System.Drawing.Point(62, 105);
            this.tb_Welcome.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Welcome.Name = "tb_Welcome";
            this.tb_Welcome.ReadOnly = true;
            this.tb_Welcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Welcome.Size = new System.Drawing.Size(239, 27);
            this.tb_Welcome.TabIndex = 54;
            this.tb_Welcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pb_LoginImage
            // 
            this.pb_LoginImage.Image = ((System.Drawing.Image)(resources.GetObject("pb_LoginImage.Image")));
            this.pb_LoginImage.ImageLocation = "";
            this.pb_LoginImage.InitialImage = null;
            this.pb_LoginImage.Location = new System.Drawing.Point(221, 18);
            this.pb_LoginImage.Margin = new System.Windows.Forms.Padding(2);
            this.pb_LoginImage.Name = "pb_LoginImage";
            this.pb_LoginImage.Size = new System.Drawing.Size(80, 80);
            this.pb_LoginImage.TabIndex = 53;
            this.pb_LoginImage.TabStop = false;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.White;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Logout.Location = new System.Drawing.Point(161, 135);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(140, 48);
            this.btn_Logout.TabIndex = 52;
            this.btn_Logout.Text = "로그아웃";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pb_LoginImage);
            this.groupBox2.Controls.Add(this.tb_Welcome);
            this.groupBox2.Controls.Add(this.btn_Logout);
            this.groupBox2.Location = new System.Drawing.Point(1609, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(304, 217);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_commute);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.pb_Logo);
            this.groupBox1.Controls.Add(this.btn_Select);
            this.groupBox1.Controls.Add(this.btn_production);
            this.groupBox1.Controls.Add(this.btn_performance);
            this.groupBox1.Controls.Add(this.btn_operation);
            this.groupBox1.Controls.Add(this.btn_comprehensive);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Location = new System.Drawing.Point(550, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(412, 737);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Delete.Location = new System.Drawing.Point(5, 686);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(400, 40);
            this.btn_Delete.TabIndex = 49;
            this.btn_Delete.Text = "회원 탈퇴";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.ImageLocation = "C:\\프로젝트Image\\씨샾logo.png";
            this.pb_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_Logo.InitialImage")));
            this.pb_Logo.Location = new System.Drawing.Point(5, 18);
            this.pb_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(400, 400);
            this.pb_Logo.TabIndex = 51;
            this.pb_Logo.TabStop = false;
            this.pb_Logo.Click += new System.EventHandler(this.pb_Logo_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.BackColor = System.Drawing.Color.White;
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Select.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Select.Location = new System.Drawing.Point(5, 686);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(400, 40);
            this.btn_Select.TabIndex = 50;
            this.btn_Select.Text = "회원 정보 조회";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_production
            // 
            this.btn_production.BackColor = System.Drawing.Color.White;
            this.btn_production.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_production.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_production.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_production.Location = new System.Drawing.Point(5, 512);
            this.btn_production.Margin = new System.Windows.Forms.Padding(2);
            this.btn_production.Name = "btn_production";
            this.btn_production.Size = new System.Drawing.Size(400, 40);
            this.btn_production.TabIndex = 53;
            this.btn_production.Text = "공정별 생산 현황";
            this.btn_production.UseVisualStyleBackColor = false;
            this.btn_production.Click += new System.EventHandler(this.btn_production_Click);
            // 
            // btn_performance
            // 
            this.btn_performance.BackColor = System.Drawing.Color.White;
            this.btn_performance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_performance.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_performance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_performance.Location = new System.Drawing.Point(5, 556);
            this.btn_performance.Margin = new System.Windows.Forms.Padding(2);
            this.btn_performance.Name = "btn_performance";
            this.btn_performance.Size = new System.Drawing.Size(400, 40);
            this.btn_performance.TabIndex = 54;
            this.btn_performance.Text = "생산 계획 대비 실적 현황";
            this.btn_performance.UseVisualStyleBackColor = false;
            this.btn_performance.Click += new System.EventHandler(this.btn_performance_Click);
            // 
            // btn_operation
            // 
            this.btn_operation.BackColor = System.Drawing.Color.White;
            this.btn_operation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_operation.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_operation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_operation.Location = new System.Drawing.Point(5, 469);
            this.btn_operation.Margin = new System.Windows.Forms.Padding(2);
            this.btn_operation.Name = "btn_operation";
            this.btn_operation.Size = new System.Drawing.Size(400, 40);
            this.btn_operation.TabIndex = 52;
            this.btn_operation.Text = "생산 가동 현황";
            this.btn_operation.UseVisualStyleBackColor = false;
            this.btn_operation.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // btn_comprehensive
            // 
            this.btn_comprehensive.BackColor = System.Drawing.Color.White;
            this.btn_comprehensive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprehensive.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_comprehensive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_comprehensive.Location = new System.Drawing.Point(5, 599);
            this.btn_comprehensive.Margin = new System.Windows.Forms.Padding(2);
            this.btn_comprehensive.Name = "btn_comprehensive";
            this.btn_comprehensive.Size = new System.Drawing.Size(400, 40);
            this.btn_comprehensive.TabIndex = 55;
            this.btn_comprehensive.Text = "종합 모니터링";
            this.btn_comprehensive.UseVisualStyleBackColor = false;
            this.btn_comprehensive.Click += new System.EventHandler(this.btn_comprehensive_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Update.Location = new System.Drawing.Point(5, 643);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(400, 40);
            this.btn_Update.TabIndex = 48;
            this.btn_Update.Text = "회원 정보 수정";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_commute
            // 
            this.btn_commute.BackColor = System.Drawing.Color.White;
            this.btn_commute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_commute.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_commute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_commute.Location = new System.Drawing.Point(5, 425);
            this.btn_commute.Margin = new System.Windows.Forms.Padding(2);
            this.btn_commute.Name = "btn_commute";
            this.btn_commute.Size = new System.Drawing.Size(400, 40);
            this.btn_commute.TabIndex = 56;
            this.btn_commute.Text = "출퇴근 관리";
            this.btn_commute.UseVisualStyleBackColor = false;
            this.btn_commute.Click += new System.EventHandler(this.btn_commute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(16, 60, 16, 16);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_LoginImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Welcome;
        private System.Windows.Forms.PictureBox pb_LoginImage;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_comprehensive;
        private System.Windows.Forms.Button btn_performance;
        private System.Windows.Forms.Button btn_production;
        private System.Windows.Forms.Button btn_operation;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_commute;
    }
}