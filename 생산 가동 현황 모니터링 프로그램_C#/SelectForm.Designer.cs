namespace 생산_가동_현황_모니터링_프로그램
{
    partial class SelectForm
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
            this.list_UserInfo = new System.Windows.Forms.ListView();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_userID = new System.Windows.Forms.TextBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_UserInfo);
            this.groupBox1.Controls.Add(this.btn_Close);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.tb_userID);
            this.groupBox1.Controls.Add(this.btn_Select);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1509, 839);
            this.groupBox1.TabIndex = 153;
            this.groupBox1.TabStop = false;
            // 
            // list_UserInfo
            // 
            this.list_UserInfo.BackColor = System.Drawing.Color.White;
            this.list_UserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_UserInfo.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.list_UserInfo.ForeColor = System.Drawing.Color.Black;
            this.list_UserInfo.HideSelection = false;
            this.list_UserInfo.Location = new System.Drawing.Point(29, 173);
            this.list_UserInfo.Name = "list_UserInfo";
            this.list_UserInfo.Size = new System.Drawing.Size(1450, 600);
            this.list_UserInfo.TabIndex = 161;
            this.list_UserInfo.UseCompatibleStateImageBehavior = false;
            this.list_UserInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_UserInfo_MouseDoubleClick);
            // 
            // btn_Close
            // 
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Close.Location = new System.Drawing.Point(680, 779);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(150, 50);
            this.btn_Close.TabIndex = 160;
            this.btn_Close.Text = "나가기";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Update.Location = new System.Drawing.Point(1263, 86);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(216, 38);
            this.btn_Update.TabIndex = 156;
            this.btn_Update.Text = "회원 정보 수정";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_userID
            // 
            this.tb_userID.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_userID.ForeColor = System.Drawing.Color.Silver;
            this.tb_userID.Location = new System.Drawing.Point(1074, 128);
            this.tb_userID.Name = "tb_userID";
            this.tb_userID.Size = new System.Drawing.Size(183, 35);
            this.tb_userID.TabIndex = 159;
            this.tb_userID.Text = "ID입력";
            this.tb_userID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_userID.Click += new System.EventHandler(this.tb_userID_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.BackColor = System.Drawing.Color.White;
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Select.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Select.Location = new System.Drawing.Point(1263, 44);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(216, 38);
            this.btn_Select.TabIndex = 158;
            this.btn_Select.Text = "회원 정보 조회";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Delete.Location = new System.Drawing.Point(1263, 128);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(216, 38);
            this.btn_Delete.TabIndex = 157;
            this.btn_Delete.Text = "회원 정보 삭제";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(609, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 54);
            this.label2.TabIndex = 153;
            this.label2.Text = "회원 정보 조회";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SelectForm";
            this.Padding = new System.Windows.Forms.Padding(16, 60, 16, 16);
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView list_UserInfo;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_userID;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label2;
    }
}