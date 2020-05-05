namespace 생산_가동_현황_모니터링_프로그램
{
    partial class ImageProcessing
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.효과ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.블러링ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.pb_Image1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_Image2 = new System.Windows.Forms.PictureBox();
            this.흑백ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.감마변환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.효과ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 효과ToolStripMenuItem
            // 
            this.효과ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.블러링ToolStripMenuItem,
            this.흑백ToolStripMenuItem,
            this.감마변환ToolStripMenuItem});
            this.효과ToolStripMenuItem.Name = "효과ToolStripMenuItem";
            this.효과ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.효과ToolStripMenuItem.Text = "효과";
            // 
            // 블러링ToolStripMenuItem
            // 
            this.블러링ToolStripMenuItem.Name = "블러링ToolStripMenuItem";
            this.블러링ToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.블러링ToolStripMenuItem.Text = "블러링";
            this.블러링ToolStripMenuItem.Click += new System.EventHandler(this.블러링ToolStripMenuItem_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Cancel.Location = new System.Drawing.Point(380, 386);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.White;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_OK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_OK.Location = new System.Drawing.Point(289, 386);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 31);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "확인";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // pb_Image1
            // 
            this.pb_Image1.Location = new System.Drawing.Point(0, 5);
            this.pb_Image1.Name = "pb_Image1";
            this.pb_Image1.Size = new System.Drawing.Size(364, 357);
            this.pb_Image1.TabIndex = 4;
            this.pb_Image1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.pb_Image2);
            this.groupBox1.Controls.Add(this.btn_OK);
            this.groupBox1.Controls.Add(this.pb_Image1);
            this.groupBox1.Location = new System.Drawing.Point(20, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 425);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // pb_Image2
            // 
            this.pb_Image2.Location = new System.Drawing.Point(381, 5);
            this.pb_Image2.Name = "pb_Image2";
            this.pb_Image2.Size = new System.Drawing.Size(364, 357);
            this.pb_Image2.TabIndex = 4;
            this.pb_Image2.TabStop = false;
            // 
            // 흑백ToolStripMenuItem
            // 
            this.흑백ToolStripMenuItem.Name = "흑백ToolStripMenuItem";
            this.흑백ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.흑백ToolStripMenuItem.Text = "흑백";
            this.흑백ToolStripMenuItem.Click += new System.EventHandler(this.흑백ToolStripMenuItem_Click);
            // 
            // 감마변환ToolStripMenuItem
            // 
            this.감마변환ToolStripMenuItem.Name = "감마변환ToolStripMenuItem";
            this.감마변환ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.감마변환ToolStripMenuItem.Text = "감마변환";
            this.감마변환ToolStripMenuItem.Click += new System.EventHandler(this.감마변환ToolStripMenuItem_Click);
            // 
            // ImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(785, 525);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImageProcessing";
            this.Load += new System.EventHandler(this.ImageProcessing_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 효과ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 블러링ToolStripMenuItem;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.PictureBox pb_Image1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_Image2;
        private System.Windows.Forms.ToolStripMenuItem 흑백ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 감마변환ToolStripMenuItem;
    }
}