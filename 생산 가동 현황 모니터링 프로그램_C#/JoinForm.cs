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

namespace 생산_가동_현황_모니터링_프로그램
{
    public partial class JoinForm : MetroForm
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public JoinForm()
        {
            InitializeComponent();
        }
        private LoginForm loginForm = null;
        public JoinForm(LoginForm form)
        {
            InitializeComponent();
            this.loginForm = form;
        }
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JoinForm_Load(object sender, EventArgs e)
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
            string[] gender = { "M", "F" };
            combo_Gender.Items.AddRange(gender);
            
            for (int i = 1900; i < 2020; i++)
            {
                combo_birth1.Items.Add(i);
            }
            for (int i = 1; i < 13; i++)
            {
                combo_birth2.Items.Add(i);
            }
            for (int i = 1; i < 31; i++)
            {
                combo_birth3.Items.Add(i);
            }
            joinState = false;
            checkIDState = false;
        }
        /// <summary>
        /// 그룹박스 테두리 및 배경 색 변경 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="p"></param>
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }
        /// <summary>
        /// Form Closed
        /// </summary>
        bool checkIDState = false;
        private void JoinForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (checkIDState == true && joinState == false)
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                cmd = new MySqlCommand("", conn);

                string sql = "DELETE FROM user_image WHERE fid='" + tb_userID.Text + "'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                sql = "DELETE FROM user_info WHERE uid='" + tb_userID.Text + "'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        /// <summary>
        /// 아이디 중복확인
        /// </summary>
        string userID;
        public static string userIDCheck;
        private void btn_CheckID_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            string sql = "SELECT * FROM user_info WHERE uid='" + tb_userID.Text + "'";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                userID = reader["uid"].ToString();
                break;
            }
            reader.Close();
            conn.Close();
            if (tb_userID.Text == userID)
                MessageBox.Show("이미 사용중인 아이디입니다.");
            else if (tb_userID.Text == "" || tb_userID.Text == "4~12자리 영어, 숫자")
                MessageBox.Show("아이디를 입력해주세요.");
            else
            {
                try
                {
                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    cmd = new MySqlCommand("", conn);

                    sql = "INSERT INTO user_info VALUES('" + tb_userID.Text + "', '" + "', '" + "', '" + "', '" + "', '" + "', '" + "', '" + "', '" + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("사용가능한 아이디입니다.");
                    userIDCheck = tb_userID.Text;
                    tb_userID.ReadOnly = true;
                    tb_userID.BackColor = Color.Gray;
                    tb_userID.ForeColor = Color.Black;
                    checkIDState = true;
                }
                catch
                {
                    MessageBox.Show("이미 사용중인 아이디입니다.");
                }
            }
        }
        /// <summary>
        /// 회원가입 버튼 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        bool joinState = false;
        private void btn_Join_Click(object sender, EventArgs e)
        {
            if (checkIDState == false)
                MessageBox.Show("아이디 중복확인을 해주세요.");
            else if (tb_Pw.Text == "" || tb_Pw.Text == "4~14자리 영어, 숫자")
                MessageBox.Show("비밀번호를 확인해주세요.");
            else if (tb_Pw.Text != tb_PwRe.Text)
                MessageBox.Show("두 개의 비밀번호가 일치하지 않습니다.");
            else if (tb_Uname.Text == "" || tb_Uname.Text == "최대 5글자")
                MessageBox.Show("이름을 입력해주세요.");
            else if (combo_birth1.Text == "" || combo_birth2.Text == "" || combo_birth3.Text == "")
                MessageBox.Show("생년월일을 입력해주세요.");
            else if (combo_Gender.Text != "M" && combo_Gender.Text != "F")
                MessageBox.Show("성별을 확인해주세요.");
            else if (tb_Adress.Text == "" || tb_Adress.Text == "ex) 서울특별시 강남구 삼성동")
                MessageBox.Show("주소를 입력해주세요.");
            else if (tb_Phone1.Text == "" || tb_Phone2.Text == "" || tb_Phone3.Text == ""
                || tb_Phone1.Text == "000" || tb_Phone2.Text == "0000" || tb_Phone3.Text == "0000")
                MessageBox.Show("휴대폰 번호를 입력해주세요.");
            else if (tb_Phone1.Text.Trim().Length > 3 || tb_Phone2.Text.Trim().Length > 4 || tb_Phone3.Text.Trim().Length > 4)
                MessageBox.Show("휴대폰 번호를 확인해주세요");
            else
            {
                if (tb_userID.Text != "" && tb_Pw.Text != "" && tb_PwRe.Text != ""
                && tb_Uname.Text != "" && combo_birth1.Text != "" && combo_birth2.Text != "" && combo_birth3.Text != ""
                && combo_Gender.Text != "" && tb_Adress.Text != "" && tb_Phone1.Text != "" && tb_Phone2.Text != "" && tb_Phone3.Text != "")
                {
                    this.DialogResult = DialogResult.OK;
                    joinState = true;
                }
                else
                    MessageBox.Show("다시 확인해주세요.");
            }
        }
        /// <summary>
        /// 나가기 버튼 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// 이미지 로드 버튼 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PicUpload_Click(object sender, EventArgs e)
        {
            if (checkIDState == false)
            {
                MessageBox.Show("아이디 중복확인을 먼저 해주세요.");
            }
            else
            {
                ImageProcessing dlgImage = new ImageProcessing(this);
                dlgImage.ShowDialog();

                if (dlgImage.DialogResult == DialogResult.OK)
                {
                    btn_PicUpload.Visible = false;

                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    cmd = new MySqlCommand("", conn);

                    int height = 0;
                    int width = 0;

                    string sql = "SELECT * FROM user_image WHERE fid='" + tb_userID.Text + "'";
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        height = int.Parse(reader["height"].ToString());
                        width = int.Parse(reader["width"].ToString());
                        break;
                    }

                    Bitmap paper = new Bitmap(height, width);
                    Color c;
                    int r, g, b;
                    while (reader.Read())
                    {
                        int xPos = int.Parse(reader["xPos"].ToString());
                        int yPos = int.Parse(reader["yPos"].ToString());
                        r = int.Parse(reader["r"].ToString());
                        g = int.Parse(reader["g"].ToString());
                        b = int.Parse(reader["b"].ToString());
                    
                        c = Color.FromArgb(r, g, b);
                        paper.SetPixel(xPos, yPos, c);
                    }
                    reader.Close();

                    pb_UserPic.Image = paper;
                    pb_UserPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    conn.Close();
                }
            }
        }

        //////////////////////////////////////////
        /// ********** 각종 이벤트들 ********** ///
        //////////////////////////////////////////
        
        /// <summary>
        /// 핸드폰 번호 입력 란에 숫자만 입력가능
        /// </summary>
        private void tb_Phone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지 Key 입력불가
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// 클릭시 텍스트박스 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_userID_Click(object sender, EventArgs e)
        {
            tb_userID.Text = "";
            tb_userID.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            tb_userID.ForeColor = Color.Black;
        }

        private void tb_Pw_Click(object sender, EventArgs e)
        {
            tb_Pw.Text = "";
            tb_Pw.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            tb_Pw.ForeColor = Color.Black;
            tb_Pw.PasswordChar = '*';
        }

        private void tb_PwRe_Click(object sender, EventArgs e)
        {
            tb_PwRe.Text = "";
            tb_PwRe.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            tb_PwRe.ForeColor = Color.Black;
            tb_PwRe.PasswordChar = '*';
        }

        private void tb_Uname_Click(object sender, EventArgs e)
        {
            tb_Uname.Text = "";
            tb_Uname.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            tb_Uname.ForeColor = Color.Black;
        }

        private void tb_Adress_Click(object sender, EventArgs e)
        {
            tb_Adress.Text = "";
            tb_Adress.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            tb_Adress.ForeColor = Color.Black;
        }

        private void tb_Phone1_Click(object sender, EventArgs e)
        {
            tb_Phone1.Text = "";
            tb_Phone1.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            tb_Phone1.ForeColor = Color.Black;
        }

        private void tb_Phone2_Click(object sender, EventArgs e)
        {
            tb_Phone2.Text = "";
            tb_Phone2.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            tb_Phone2.ForeColor = Color.Black;
        }

        private void tb_Phone3_Click(object sender, EventArgs e)
        {
            tb_Phone3.Text = "";
            tb_Phone3.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            tb_Phone3.ForeColor = Color.Black;
        }
        /// <summary>
        /// 텍스트 박스를 떠날 시 빈 칸이면 다시 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_userID_Leave(object sender, EventArgs e)
        {
            if(tb_userID.Text == "")
            {
                tb_userID.Text = "4~12자리 영어, 숫자";
                tb_userID.Font = new Font("맑은 고딕", 15, FontStyle.Italic);
                tb_userID.ForeColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void tb_Pw_Leave(object sender, EventArgs e)
        {
            if (tb_Pw.Text == "")
            {
                tb_Pw.Text = "4~14자리 영어, 숫자, 특수문자";
                tb_Pw.Font = new Font("맑은 고딕", 15, FontStyle.Italic);
                tb_Pw.ForeColor = Color.FromArgb(150, 150, 150);
                tb_Pw.PasswordChar = default(char);
            }
        }

        private void tb_PwRe_Leave(object sender, EventArgs e)
        {
            if (tb_PwRe.Text == "")
            {
                tb_PwRe.Text = "위의 비밀번호와 같게 입력";
                tb_PwRe.Font = new Font("맑은 고딕", 15, FontStyle.Italic);
                tb_PwRe.ForeColor = Color.FromArgb(150, 150, 150);
                tb_PwRe.PasswordChar = default(char);
            }
        }

        private void tb_Uname_Leave(object sender, EventArgs e)
        {
            if (tb_Uname.Text == "")
            {
                tb_Uname.Text = "최대 5글자";
                tb_Uname.Font = new Font("맑은 고딕", 15, FontStyle.Italic);
                tb_Uname.ForeColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void tb_Adress_Leave(object sender, EventArgs e)
        {
            if (tb_Adress.Text == "")
            {
                tb_Adress.Text = "ex) 서울특별시 강남구 삼성동";
                tb_Adress.Font = new Font("맑은 고딕", 15, FontStyle.Italic);
                tb_Adress.ForeColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void tb_Phone1_Leave(object sender, EventArgs e)
        {
            if (tb_Phone1.Text == "")
            {
                tb_Phone1.Text = "010";
                tb_Phone1.Font = new Font("맑은 고딕", 15, FontStyle.Italic);
                tb_Phone1.ForeColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void tb_Phone2_Leave(object sender, EventArgs e)
        {
            if (tb_Phone2.Text == "")
            {
                tb_Phone2.Text = "0000";
                tb_Phone2.Font = new Font("맑은 고딕", 15, FontStyle.Italic);
                tb_Phone2.ForeColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void tb_Phone3_Leave(object sender, EventArgs e)
        {
            if (tb_Phone3.Text == "")
            {
                tb_Phone3.Text = "0000";
                tb_Phone3.Font = new Font("맑은 고딕", 15, FontStyle.Italic);
                tb_Phone3.ForeColor = Color.FromArgb(150, 150, 150);
            }
        }
    }
}
