namespace 생산_가동_현황_모니터링_프로그램
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_PassFind = new System.Windows.Forms.Button();
            this.btn_IDFind = new System.Windows.Forms.Button();
            this.btn_Join = new System.Windows.Forms.Button();
            this.tb_Pw = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.White;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Login.Location = new System.Drawing.Point(0, 551);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(400, 40);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "로그인";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_PassFind
            // 
            this.btn_PassFind.BackColor = System.Drawing.Color.White;
            this.btn_PassFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PassFind.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_PassFind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_PassFind.Location = new System.Drawing.Point(0, 639);
            this.btn_PassFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PassFind.Name = "btn_PassFind";
            this.btn_PassFind.Size = new System.Drawing.Size(190, 40);
            this.btn_PassFind.TabIndex = 6;
            this.btn_PassFind.Text = "비밀번호 찾기";
            this.btn_PassFind.UseVisualStyleBackColor = false;
            this.btn_PassFind.Click += new System.EventHandler(this.btn_PassFind_Click);
            // 
            // btn_IDFind
            // 
            this.btn_IDFind.BackColor = System.Drawing.Color.White;
            this.btn_IDFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IDFind.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IDFind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_IDFind.Location = new System.Drawing.Point(0, 595);
            this.btn_IDFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_IDFind.Name = "btn_IDFind";
            this.btn_IDFind.Size = new System.Drawing.Size(190, 40);
            this.btn_IDFind.TabIndex = 5;
            this.btn_IDFind.Text = "아이디 찾기";
            this.btn_IDFind.UseVisualStyleBackColor = false;
            this.btn_IDFind.Click += new System.EventHandler(this.btn_IDFind_Click);
            // 
            // btn_Join
            // 
            this.btn_Join.BackColor = System.Drawing.Color.White;
            this.btn_Join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Join.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Join.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Join.Location = new System.Drawing.Point(196, 595);
            this.btn_Join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Join.Name = "btn_Join";
            this.btn_Join.Size = new System.Drawing.Size(204, 84);
            this.btn_Join.TabIndex = 7;
            this.btn_Join.Text = "회원가입";
            this.btn_Join.UseVisualStyleBackColor = false;
            this.btn_Join.Click += new System.EventHandler(this.btn_Join_Click);
            // 
            // tb_Pw
            // 
            this.tb_Pw.BackColor = System.Drawing.Color.White;
            this.tb_Pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Pw.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Pw.ForeColor = System.Drawing.Color.Silver;
            this.tb_Pw.Location = new System.Drawing.Point(1, 512);
            this.tb_Pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Pw.Name = "tb_Pw";
            this.tb_Pw.Size = new System.Drawing.Size(399, 35);
            this.tb_Pw.TabIndex = 3;
            this.tb_Pw.Text = "비밀번호 입력";
            this.tb_Pw.Enter += new System.EventHandler(this.tb_Pw_Enter);
            this.tb_Pw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Pw_KeyPress);
            this.tb_Pw.Leave += new System.EventHandler(this.tb_Pw_Leave);
            // 
            // tb_ID
            // 
            this.tb_ID.BackColor = System.Drawing.Color.White;
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ID.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ID.ForeColor = System.Drawing.Color.Silver;
            this.tb_ID.Location = new System.Drawing.Point(0, 443);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(400, 35);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.Text = "아이디 입력";
            this.tb_ID.Enter += new System.EventHandler(this.tb_ID_Enter);
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Pw_KeyPress);
            this.tb_ID.Leave += new System.EventHandler(this.tb_ID_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(-4, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 52;
            this.label2.Text = "비밀번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-4, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "아이디";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_PassFind);
            this.groupBox1.Controls.Add(this.pb_Logo);
            this.groupBox1.Controls.Add(this.btn_Login);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.btn_IDFind);
            this.groupBox1.Controls.Add(this.tb_Pw);
            this.groupBox1.Controls.Add(this.btn_Join);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(568, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(400, 679);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // pb_Logo
            // 
            this.pb_Logo.ImageLocation = "C:\\프로젝트Image\\씨샾logo.png";
            this.pb_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_Logo.InitialImage")));
            this.pb_Logo.Location = new System.Drawing.Point(0, 0);
            this.pb_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(400, 400);
            this.pb_Logo.TabIndex = 50;
            this.pb_Logo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(16, 60, 16, 16);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_PassFind;
        private System.Windows.Forms.Button btn_IDFind;
        private System.Windows.Forms.Button btn_Join;
        public System.Windows.Forms.TextBox tb_Pw;
        public System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_Logo;
    }
}

