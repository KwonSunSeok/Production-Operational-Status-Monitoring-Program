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
    public partial class UpdateForm : MetroForm
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public UpdateForm()
        {
            InitializeComponent();
        }
        private MainForm mainForm = null;
        public UpdateForm(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }
        /// <summary>
        /// UpdateForm Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateFormcs_Load(object sender, EventArgs e)
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
            // 콤보박스 설정
            combo_Gender.Items.Add('M');
            combo_Gender.Items.Add('F');

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
            // 회원 정보 로드
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            string sql = "SELECT * FROM user_info WHERE uid='" + LoginForm.uid + "'";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tb_userID.Text = reader["uid"].ToString();
                tb_PwChange.Text = reader["upw"].ToString();
                tb_PwChangeRe.Text = reader["upw"].ToString();
                tb_Uname.Text = reader["uname"].ToString();
                string str = reader["ubirth"].ToString();
                string[] split = str.Split('.');
                combo_birth1.Text = split[0];
                combo_birth2.Text = split[1];
                combo_birth3.Text = split[2];
                combo_Gender.Text = reader["ugender"].ToString();
                tb_Adress.Text = reader["uadress"].ToString();
                tb_Phone1.Text = reader["uphone1"].ToString();
                tb_Phone2.Text = reader["uphone2"].ToString();
                tb_Phone3.Text = reader["uphone3"].ToString();
            }
            reader.Close();
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                cmd = new MySqlCommand("", conn);

                int height = 0;
                int width = 0;

                sql = "SELECT * FROM user_image WHERE fid='" + tb_userID.Text + "'";
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
            catch
            {

            }
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
        /// 정보 수정 버튼 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Join_Click(object sender, EventArgs e)
        {
            if (tb_PwChange.Text != tb_PwChangeRe.Text)
                MessageBox.Show("변경할 비밀번호와 비밀번호 확인란을 같게 입력해주세요.");
            else if (tb_Pw.Text != LoginForm.upw)
                MessageBox.Show("비밀번호가 틀렸습니다.");
            else if (combo_Gender.Text != "M" && combo_Gender.Text != "F")
                MessageBox.Show("성별을 확인해주세요.");
            else if (tb_Adress.Text == "")
                MessageBox.Show("주소를 입력해주세요.");
            else if (tb_Phone1.Text == "" || tb_Phone2.Text == "" || tb_Phone3.Text == "")
                MessageBox.Show("휴대폰 번호를 입력해주세요.");
            else if (tb_Phone1.Text.Trim().Length > 3 || tb_Phone2.Text.Trim().Length > 4 || tb_Phone3.Text.Trim().Length > 4)
                MessageBox.Show("휴대폰 번호를 확인해주세요.");
            else
            {
                if (tb_PwChange.Text != "")
                {
                    LoginForm.upw = tb_PwChange.Text;
                }
                LoginForm.uadress = tb_Adress.Text;
                LoginForm.uphone1 = tb_Phone1.Text;
                LoginForm.uphone2 = tb_Phone2.Text;
                LoginForm.uphone3 = tb_Phone3.Text;
                updateState = false;
                this.DialogResult = DialogResult.OK;
                MainForm.updateState = true;
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
            MainForm.updateState = true;
        }
        /// <summary>
        /// 이미지 로드 버튼 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PicUpload_Click(object sender, EventArgs e)
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

                string sql = "SELECT height, width FROM user_image WHERE fid='" + tb_userID.Text + "'";
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    height = int.Parse(reader["height"].ToString());
                    width = int.Parse(reader["width"].ToString());
                    break;
                }
                reader.Close();

                sql = "SELECT xPos, yPos, r, g, b FROM user_image WHERE fid='" + tb_userID.Text + "'";
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();

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
        /// <summary>
        /// 회원 정보 수정 페이지 닫힐때 이미지 로드를 했으나, 정보 수정 버튼 클릭하지않고 나가기 버튼을 눌렀을 때
        /// </summary>
        public static int[] prexPos = { }, preyPos = { }, prer = { }, preg = { }, preb = { };
        public static int preheight, prewidth;
        public static bool updateState = false;
        private void UpdateFormcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK && updateState == true)
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                cmd = new MySqlCommand("", conn);

                string sql = "DELETE FROM user_image WHERE fid='" + tb_userID.Text + "'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();


                for (int i = 0; i < (ImageProcessing.inH * ImageProcessing.inW); i++)
                {
                    if (i == 0)
                    {
                        sql = "INSERT INTO user_image VALUES('" + tb_userID.Text + "'," + prexPos[i] + "," + preyPos[i] + ",";
                        sql += prer[i] + "," + preg[i] + "," + preb[i] + "," + preheight + ",";
                        sql += prewidth + ")";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        sql = "INSERT INTO user_image (fid, xPos, yPos, r, g, b) VALUES('" + tb_userID.Text + "'," + prexPos[i] + "," + preyPos[i] + ",";
                        sql += prer[i] + "," + preg[i] + "," + preb[i] + ")";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
                updateState = false;
            }
            Array.Resize(ref prexPos, 0);
            Array.Resize(ref preyPos, 0);
            Array.Resize(ref prer, 0);
            Array.Resize(ref preg, 0);
            Array.Resize(ref preb, 0);
        }
        /// <summary>
        /// 휴대폰 번호에 숫자만 입력 가능
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_Phone1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지 Key 입력불가
            {
                e.Handled = true;
            }
        }
    }
}
