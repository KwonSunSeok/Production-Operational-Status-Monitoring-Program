using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace 생산_가동_현황_모니터링_프로그램
{
    public partial class LoginForm : MetroForm
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // 폼 사이즈 전체화면
            this.Size = new Size(
                Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height
            );
            // 폼 위치 중앙
            this.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2
            );
            groupBox1.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - groupBox1.Size.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - groupBox1.Size.Height / 2
            );
            // 그룹박스 테두리 및 배경 색 변경
            groupBox1.Paint += PaintBorderlessGroupBox;
            // Logo이미지 사이즈 설정
            pb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            MessageBox.Show("프로그램을 종료합니다.");
        }
        // 그룹박스 테두리 및 배경 색 변경 함수
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }
        private void tb_Pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btn_Login.PerformClick();
        }

        public static string uid, upw, uname, ubirth, ugender, uadress, uphone1, uphone2, uphone3;
        public static bool mainState = false;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            cmd.CommandText = "SELECT * FROM user_info WHERE uid='" + tb_ID.Text + "'";
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                uid = reader["uid"].ToString();
                upw = reader["upw"].ToString();
                uname = reader["uname"].ToString();
                ubirth = reader["ubirth"].ToString();
                ugender = reader["ugender"].ToString();
                uadress = reader["uadress"].ToString();
                uphone1 = reader["uphone1"].ToString();
                uphone2 = reader["uphone2"].ToString();
                uphone3 = reader["uphone3"].ToString();
            }
            reader.Close();
            if (upw == tb_Pw.Text && tb_Pw.Text != "" && tb_ID.Text != "")
            {
                if (tb_ID.Text == "admin")
                {
                    MessageBox.Show("관리자 권한으로 실행합니다.");
                }
                else
                    MessageBox.Show(uid + "님 환영합니다.");
                this.Visible = false;
                MainForm showMain = new MainForm(this);
                showMain.ShowDialog();

                if (mainState == true)
                {
                    this.Visible = true;
                    mainState = false;
                    tb_ID.Text = "";
                    tb_Pw.Text = "";
                    uid = upw = uname = ubirth = ugender = uadress = uphone1 = uphone2 = uphone3 = "";
                }
            }
            else
                MessageBox.Show("가입하지 않은 아이디이거나, 잘못된 비밀번호입니다.");
            conn.Close();
        }

        private void btn_IDFind_Click(object sender, EventArgs e)
        {
            FindID dlgFindID = new FindID(this);

            if (dlgFindID.ShowDialog() == DialogResult.OK)
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                cmd = new MySqlCommand("", conn);

                string sql = "SELECT * FROM user_info WHERE uname='" + dlgFindID.tb_Uname.Text;
                sql += "' AND uPhone2='" + dlgFindID.tb_Phone2.Text + "' AND uPhone3='" + dlgFindID.tb_Phone3.Text + "'";
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    uid = reader["uid"].ToString();
                    uname = reader["uname"].ToString();
                    uphone2 = reader["uphone2"].ToString();
                    uphone3 = reader["uphone3"].ToString();
                }
                reader.Close();

                if ((dlgFindID.tb_Uname.Text == uname) && (dlgFindID.tb_Phone2.Text == uphone2) && (dlgFindID.tb_Phone3.Text == uphone3))
                {
                    MessageBox.Show("아이디는 " + uid + " 입니다.");
                }
                else
                    MessageBox.Show("가입된 아이디가 없거나, 정보를 잘못 입력하셨습니다.");

                conn.Close();
            }
        }

        private void btn_PassFind_Click(object sender, EventArgs e)
        {
            FindPW dlgFindPW = new FindPW(this);

            if (dlgFindPW.ShowDialog() == DialogResult.OK)
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                cmd = new MySqlCommand("", conn);

                string sql = "SELECT * FROM user_info WHERE uid='" + dlgFindPW.tb_ID.Text + "' AND uname='";
                sql += dlgFindPW.tb_Uname.Text + "' AND uPhone2='" + dlgFindPW.tb_Phone2.Text + "' AND uPhone3='";
                sql += dlgFindPW.tb_Phone3.Text + "'";
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    uid = reader["uid"].ToString();
                    upw = reader["upw"].ToString();
                    uname = reader["uname"].ToString();
                    uphone2 = reader["uphone2"].ToString();
                    uphone3 = reader["uphone3"].ToString();
                }
                reader.Close();

                if ((dlgFindPW.tb_ID.Text == uid) && (dlgFindPW.tb_Uname.Text == uname)
                    && (dlgFindPW.tb_Phone2.Text == uphone2) && (dlgFindPW.tb_Phone3.Text == uphone3))
                {
                    MessageBox.Show("비밀번호는 " + upw + " 입니다.");
                }
                else
                    MessageBox.Show("가입된 아이디가 없거나, 정보를 잘못 입력하셨습니다.");

                conn.Close();
            }
        }
        bool join_state = true;
        private void btn_Join_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            JoinForm dlgJoinForm = new JoinForm(this);

            if (dlgJoinForm.ShowDialog() == DialogResult.OK)
            {
                while (join_state)
                {
                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    cmd = new MySqlCommand("", conn);

                    string sql = "UPDATE user_info SET upw='";
                    sql += dlgJoinForm.tb_Pw.Text + "', uname='" + dlgJoinForm.tb_Uname.Text + "', ubirth='";
                    sql += dlgJoinForm.combo_birth1.Text + "." + dlgJoinForm.combo_birth2.Text + "." + dlgJoinForm.combo_birth3.Text + "', ugender='";
                    sql += dlgJoinForm.combo_Gender.Text + "', uadress='" + dlgJoinForm.tb_Adress.Text + "', uphone1='";
                    sql += dlgJoinForm.tb_Phone1.Text + "', uphone2='" + dlgJoinForm.tb_Phone2.Text + "', uphone3='";
                    sql += dlgJoinForm.tb_Phone3.Text + "' WHERE uid='" + dlgJoinForm.tb_userID.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    join_state = false;
                    conn.Close();
                }
                this.Visible = true;
                join_state = true;
                MessageBox.Show("회원가입이 완료 되었습니다. 로그인 해주세요.");
            }
            else
                this.Visible = true;
        }

        private void tb_ID_Enter(object sender, EventArgs e)
        {
            tb_ID.Text = "";
            tb_ID.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            tb_ID.ForeColor = Color.Black;
        }
        
        private void tb_Pw_Enter(object sender, EventArgs e)
        {
            tb_Pw.Text = "";
            tb_Pw.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            tb_Pw.ForeColor = Color.Black;
            tb_Pw.PasswordChar = '*';
        }

        private void tb_ID_Leave(object sender, EventArgs e)
        {
            if (tb_ID.Text == "")
            {
                tb_ID.Text = "아이디 입력";
                tb_ID.Font = new Font("맑은 고딕", 15, FontStyle.Italic);
                tb_ID.ForeColor = Color.Silver;
            }
        }

        private void tb_Pw_Leave(object sender, EventArgs e)
        {
            if (tb_Pw.Text == "")
            {
                tb_Pw.Text = "비밀번호 입력";
                tb_Pw.Font = new Font("맑은 고딕", 15, FontStyle.Italic);
                tb_Pw.ForeColor = Color.Silver;
                tb_Pw.PasswordChar = default(char);
            }
        }
    }
}
