namespace 생산_가동_현황_모니터링_프로그램
{
    partial class JoinForm
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
            this.btn_CheckID = new System.Windows.Forms.Button();
            this.tb_Phone3 = new System.Windows.Forms.TextBox();
            this.tb_Uname = new System.Windows.Forms.TextBox();
            this.combo_Gender = new System.Windows.Forms.ComboBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_PicUpload = new System.Windows.Forms.Button();
            this.tb_Phone2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Phone1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Adress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_UserPic = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_PwRe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Join = new System.Windows.Forms.Button();
            this.tb_Pw = new System.Windows.Forms.TextBox();
            this.tb_userID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_birth3 = new System.Windows.Forms.ComboBox();
            this.combo_birth2 = new System.Windows.Forms.ComboBox();
            this.combo_birth1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UserPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CheckID
            // 
            this.btn_CheckID.BackColor = System.Drawing.Color.White;
            this.btn_CheckID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckID.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.btn_CheckID.Location = new System.Drawing.Point(419, 129);
            this.btn_CheckID.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CheckID.Name = "btn_CheckID";
            this.btn_CheckID.Size = new System.Drawing.Size(130, 35);
            this.btn_CheckID.TabIndex = 155;
            this.btn_CheckID.Text = "중복확인";
            this.btn_CheckID.UseVisualStyleBackColor = false;
            this.btn_CheckID.Click += new System.EventHandler(this.btn_CheckID_Click);
            // 
            // tb_Phone3
            // 
            this.tb_Phone3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tb_Phone3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Phone3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tb_Phone3.Location = new System.Drawing.Point(375, 634);
            this.tb_Phone3.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Phone3.Name = "tb_Phone3";
            this.tb_Phone3.Size = new System.Drawing.Size(174, 35);
            this.tb_Phone3.TabIndex = 138;
            this.tb_Phone3.Text = "0000";
            this.tb_Phone3.Click += new System.EventHandler(this.tb_Phone3_Click);
            this.tb_Phone3.Enter += new System.EventHandler(this.tb_Phone3_Click);
            this.tb_Phone3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Phone1_KeyPress);
            this.tb_Phone3.Leave += new System.EventHandler(this.tb_Phone3_Leave);
            // 
            // tb_Uname
            // 
            this.tb_Uname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tb_Uname.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tb_Uname.Location = new System.Drawing.Point(226, 352);
            this.tb_Uname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Uname.Name = "tb_Uname";
            this.tb_Uname.Size = new System.Drawing.Size(323, 35);
            this.tb_Uname.TabIndex = 132;
            this.tb_Uname.Text = "최대 5글자";
            this.tb_Uname.Click += new System.EventHandler(this.tb_Uname_Click);
            this.tb_Uname.Enter += new System.EventHandler(this.tb_Uname_Click);
            this.tb_Uname.Leave += new System.EventHandler(this.tb_Uname_Leave);
            // 
            // combo_Gender
            // 
            this.combo_Gender.BackColor = System.Drawing.Color.White;
            this.combo_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Gender.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combo_Gender.ForeColor = System.Drawing.Color.Black;
            this.combo_Gender.FormattingEnabled = true;
            this.combo_Gender.Location = new System.Drawing.Point(226, 493);
            this.combo_Gender.Margin = new System.Windows.Forms.Padding(2);
            this.combo_Gender.Name = "combo_Gender";
            this.combo_Gender.Size = new System.Drawing.Size(323, 38);
            this.combo_Gender.TabIndex = 134;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Close.Location = new System.Drawing.Point(288, 695);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(120, 45);
            this.btn_Close.TabIndex = 141;
            this.btn_Close.Text = "나가기";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_PicUpload
            // 
            this.btn_PicUpload.BackColor = System.Drawing.Color.White;
            this.btn_PicUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PicUpload.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_PicUpload.Location = new System.Drawing.Point(0, 320);
            this.btn_PicUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PicUpload.Name = "btn_PicUpload";
            this.btn_PicUpload.Size = new System.Drawing.Size(141, 38);
            this.btn_PicUpload.TabIndex = 139;
            this.btn_PicUpload.Text = "사진 업로드";
            this.btn_PicUpload.UseVisualStyleBackColor = false;
            this.btn_PicUpload.Click += new System.EventHandler(this.btn_PicUpload_Click);
            // 
            // tb_Phone2
            // 
            this.tb_Phone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tb_Phone2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Phone2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tb_Phone2.Location = new System.Drawing.Point(170, 634);
            this.tb_Phone2.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Phone2.Name = "tb_Phone2";
            this.tb_Phone2.Size = new System.Drawing.Size(175, 35);
            this.tb_Phone2.TabIndex = 137;
            this.tb_Phone2.Text = "0000";
            this.tb_Phone2.Click += new System.EventHandler(this.tb_Phone2_Click);
            this.tb_Phone2.Enter += new System.EventHandler(this.tb_Phone2_Click);
            this.tb_Phone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Phone1_KeyPress);
            this.tb_Phone2.Leave += new System.EventHandler(this.tb_Phone2_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(349, 636);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 30);
            this.label11.TabIndex = 153;
            this.label11.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(144, 636);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 30);
            this.label10.TabIndex = 152;
            this.label10.Text = "-";
            // 
            // tb_Phone1
            // 
            this.tb_Phone1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tb_Phone1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Phone1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tb_Phone1.Location = new System.Drawing.Point(0, 634);
            this.tb_Phone1.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Phone1.Name = "tb_Phone1";
            this.tb_Phone1.Size = new System.Drawing.Size(143, 35);
            this.tb_Phone1.TabIndex = 136;
            this.tb_Phone1.Text = "000";
            this.tb_Phone1.Click += new System.EventHandler(this.tb_Phone1_Click);
            this.tb_Phone1.Enter += new System.EventHandler(this.tb_Phone1_Click);
            this.tb_Phone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Phone1_KeyPress);
            this.tb_Phone1.Leave += new System.EventHandler(this.tb_Phone1_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 602);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 30);
            this.label8.TabIndex = 151;
            this.label8.Text = "휴대전화";
            // 
            // tb_Adress
            // 
            this.tb_Adress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tb_Adress.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Adress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tb_Adress.Location = new System.Drawing.Point(0, 565);
            this.tb_Adress.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Adress.Name = "tb_Adress";
            this.tb_Adress.Size = new System.Drawing.Size(549, 35);
            this.tb_Adress.TabIndex = 135;
            this.tb_Adress.Text = "ex) 서울특별시 강남구 삼성동";
            this.tb_Adress.Click += new System.EventHandler(this.tb_Adress_Click);
            this.tb_Adress.Enter += new System.EventHandler(this.tb_Adress_Click);
            this.tb_Adress.Leave += new System.EventHandler(this.tb_Adress_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 533);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 30);
            this.label6.TabIndex = 150;
            this.label6.Text = "주소";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(227, 461);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 30);
            this.label5.TabIndex = 149;
            this.label5.Text = "성별";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(227, 389);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 148;
            this.label4.Text = "생년월일";
            // 
            // pb_UserPic
            // 
            this.pb_UserPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_UserPic.Location = new System.Drawing.Point(0, 320);
            this.pb_UserPic.Margin = new System.Windows.Forms.Padding(2);
            this.pb_UserPic.Name = "pb_UserPic";
            this.pb_UserPic.Size = new System.Drawing.Size(200, 211);
            this.pb_UserPic.TabIndex = 147;
            this.pb_UserPic.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(227, 320);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 30);
            this.label9.TabIndex = 146;
            this.label9.Text = "이름";
            // 
            // tb_PwRe
            // 
            this.tb_PwRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tb_PwRe.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_PwRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tb_PwRe.Location = new System.Drawing.Point(0, 268);
            this.tb_PwRe.Margin = new System.Windows.Forms.Padding(2);
            this.tb_PwRe.Name = "tb_PwRe";
            this.tb_PwRe.Size = new System.Drawing.Size(549, 35);
            this.tb_PwRe.TabIndex = 131;
            this.tb_PwRe.Text = "위의 비밀번호와 같게 입력";
            this.tb_PwRe.Click += new System.EventHandler(this.tb_PwRe_Click);
            this.tb_PwRe.Enter += new System.EventHandler(this.tb_PwRe_Click);
            this.tb_PwRe.Leave += new System.EventHandler(this.tb_PwRe_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 145;
            this.label1.Text = "비밀번호 확인";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(186, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 54);
            this.label7.TabIndex = 144;
            this.label7.Text = "회원 가입";
            // 
            // btn_Join
            // 
            this.btn_Join.BackColor = System.Drawing.Color.White;
            this.btn_Join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Join.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Join.Location = new System.Drawing.Point(140, 695);
            this.btn_Join.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Join.Name = "btn_Join";
            this.btn_Join.Size = new System.Drawing.Size(120, 45);
            this.btn_Join.TabIndex = 140;
            this.btn_Join.Text = "회원 가입";
            this.btn_Join.UseVisualStyleBackColor = false;
            this.btn_Join.Click += new System.EventHandler(this.btn_Join_Click);
            // 
            // tb_Pw
            // 
            this.tb_Pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tb_Pw.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tb_Pw.Location = new System.Drawing.Point(0, 199);
            this.tb_Pw.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Pw.Name = "tb_Pw";
            this.tb_Pw.Size = new System.Drawing.Size(549, 35);
            this.tb_Pw.TabIndex = 130;
            this.tb_Pw.Text = "4~14자리 영어, 숫자, 특수문자";
            this.tb_Pw.Click += new System.EventHandler(this.tb_Pw_Click);
            this.tb_Pw.Enter += new System.EventHandler(this.tb_Pw_Click);
            this.tb_Pw.Leave += new System.EventHandler(this.tb_Pw_Leave);
            // 
            // tb_userID
            // 
            this.tb_userID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tb_userID.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_userID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tb_userID.Location = new System.Drawing.Point(0, 128);
            this.tb_userID.Margin = new System.Windows.Forms.Padding(2);
            this.tb_userID.Name = "tb_userID";
            this.tb_userID.Size = new System.Drawing.Size(408, 35);
            this.tb_userID.TabIndex = 129;
            this.tb_userID.Text = "4~12자리 영어, 숫자";
            this.tb_userID.Click += new System.EventHandler(this.tb_userID_Click);
            this.tb_userID.Enter += new System.EventHandler(this.tb_userID_Click);
            this.tb_userID.Leave += new System.EventHandler(this.tb_userID_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 30);
            this.label3.TabIndex = 143;
            this.label3.Text = "비밀번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 30);
            this.label2.TabIndex = 142;
            this.label2.Text = "아이디";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_birth3);
            this.groupBox1.Controls.Add(this.combo_birth2);
            this.groupBox1.Controls.Add(this.combo_birth1);
            this.groupBox1.Controls.Add(this.btn_CheckID);
            this.groupBox1.Controls.Add(this.tb_userID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_Phone3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_Uname);
            this.groupBox1.Controls.Add(this.tb_Pw);
            this.groupBox1.Controls.Add(this.combo_Gender);
            this.groupBox1.Controls.Add(this.btn_Join);
            this.groupBox1.Controls.Add(this.btn_Close);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_PicUpload);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Phone2);
            this.groupBox1.Controls.Add(this.tb_PwRe);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pb_UserPic);
            this.groupBox1.Controls.Add(this.tb_Phone1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_Adress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(446, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(549, 759);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            // 
            // combo_birth3
            // 
            this.combo_birth3.BackColor = System.Drawing.Color.White;
            this.combo_birth3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_birth3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combo_birth3.ForeColor = System.Drawing.Color.Black;
            this.combo_birth3.FormattingEnabled = true;
            this.combo_birth3.Location = new System.Drawing.Point(464, 421);
            this.combo_birth3.Margin = new System.Windows.Forms.Padding(2);
            this.combo_birth3.Name = "combo_birth3";
            this.combo_birth3.Size = new System.Drawing.Size(85, 38);
            this.combo_birth3.TabIndex = 158;
            // 
            // combo_birth2
            // 
            this.combo_birth2.BackColor = System.Drawing.Color.White;
            this.combo_birth2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_birth2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combo_birth2.ForeColor = System.Drawing.Color.Black;
            this.combo_birth2.FormattingEnabled = true;
            this.combo_birth2.Location = new System.Drawing.Point(375, 421);
            this.combo_birth2.Margin = new System.Windows.Forms.Padding(2);
            this.combo_birth2.Name = "combo_birth2";
            this.combo_birth2.Size = new System.Drawing.Size(85, 38);
            this.combo_birth2.TabIndex = 157;
            // 
            // combo_birth1
            // 
            this.combo_birth1.BackColor = System.Drawing.Color.White;
            this.combo_birth1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_birth1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combo_birth1.ForeColor = System.Drawing.Color.Black;
            this.combo_birth1.FormattingEnabled = true;
            this.combo_birth1.Location = new System.Drawing.Point(226, 421);
            this.combo_birth1.Margin = new System.Windows.Forms.Padding(2);
            this.combo_birth1.Name = "combo_birth1";
            this.combo_birth1.Size = new System.Drawing.Size(145, 38);
            this.combo_birth1.TabIndex = 156;
            // 
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JoinForm";
            this.Padding = new System.Windows.Forms.Padding(16, 60, 16, 16);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JoinForm_FormClosed);
            this.Load += new System.EventHandler(this.JoinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_UserPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CheckID;
        public System.Windows.Forms.TextBox tb_Phone3;
        public System.Windows.Forms.TextBox tb_Uname;
        public System.Windows.Forms.ComboBox combo_Gender;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_PicUpload;
        public System.Windows.Forms.TextBox tb_Phone2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tb_Phone1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tb_Adress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_UserPic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_PwRe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Join;
        public System.Windows.Forms.TextBox tb_Pw;
        public System.Windows.Forms.TextBox tb_userID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox combo_birth3;
        public System.Windows.Forms.ComboBox combo_birth2;
        public System.Windows.Forms.ComboBox combo_birth1;
    }
}