namespace 생산_가동_현황_모니터링_프로그램
{
    partial class SelectDeleteForm
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tb_DeleteCheck = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Close.Location = new System.Drawing.Point(300, 109);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(116, 40);
            this.btn_Close.TabIndex = 173;
            this.btn_Close.Text = "나가기";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Location = new System.Drawing.Point(166, 109);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(116, 40);
            this.btn_Delete.TabIndex = 172;
            this.btn_Delete.Text = "회원 삭제";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tb_DeleteCheck
            // 
            this.tb_DeleteCheck.BackColor = System.Drawing.Color.White;
            this.tb_DeleteCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_DeleteCheck.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold);
            this.tb_DeleteCheck.ForeColor = System.Drawing.Color.Black;
            this.tb_DeleteCheck.Location = new System.Drawing.Point(0, 32);
            this.tb_DeleteCheck.Name = "tb_DeleteCheck";
            this.tb_DeleteCheck.ReadOnly = true;
            this.tb_DeleteCheck.Size = new System.Drawing.Size(583, 54);
            this.tb_DeleteCheck.TabIndex = 174;
            this.tb_DeleteCheck.TabStop = false;
            this.tb_DeleteCheck.Text = "-";
            this.tb_DeleteCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Close);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.tb_DeleteCheck);
            this.groupBox1.Location = new System.Drawing.Point(20, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 154);
            this.groupBox1.TabIndex = 175;
            this.groupBox1.TabStop = false;
            // 
            // SelectDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(656, 208);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectDeleteForm";
            this.Load += new System.EventHandler(this.SelectDeleteForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox tb_DeleteCheck;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}