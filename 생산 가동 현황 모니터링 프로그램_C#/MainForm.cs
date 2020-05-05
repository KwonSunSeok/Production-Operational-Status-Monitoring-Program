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
    public partial class MainForm : MetroForm
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public MainForm()
        {
            InitializeComponent();
        }
        private LoginForm loginForm = null;
        public MainForm(LoginForm form)
        {
            InitializeComponent();
            this.loginForm = form;
        }
        private void MainForm_Load(object sender, EventArgs e)
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
            groupBox2.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width - groupBox2.Size.Width, 30
            );
            // 그룹박스 테두리 및 배경 색 변경
            groupBox1.Paint += PaintBorderlessGroupBox;
            groupBox2.Paint += PaintBorderlessGroupBox;
            // Logo이미지 사이즈 설정
            pb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            tb_Welcome.Text = LoginForm.uid + "님 환영합니다.";

            if (LoginForm.uid == "admin")
            {
                btn_Delete.Visible = false;
                btn_Select.Visible = true;
            }
            else
            {
                btn_Select.Visible = false;
            }
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                cmd = new MySqlCommand("", conn);

                int height = 0;
                int width = 0;

                string sql = "SELECT * FROM user_image WHERE fid='" + loginForm.tb_ID.Text + "'";
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

                pb_LoginImage.Image = paper;
                pb_LoginImage.SizeMode = PictureBoxSizeMode.StretchImage;
                conn.Close();
            }
            catch
            {
                pb_LoginImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.mainState = true;
            MessageBox.Show("로그아웃 되었습니다.");
        }
        // 그룹박스 테두리 및 배경 색 변경 함수
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
        private void btn_commute_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CommutingTime dlgCommuting = new CommutingTime(this);
            dlgCommuting.ShowDialog();

            if (dlgCommuting.DialogResult == DialogResult.Cancel)
                this.Visible = true;
        }

        private void btn_operation_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Operation dlgOperation = new Operation(this);
            dlgOperation.ShowDialog();

            if (dlgOperation.DialogResult == DialogResult.Cancel)
                this.Visible = true;
        }

        private void btn_production_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Production dlgProduction = new Production(this);
            dlgProduction.ShowDialog();

            if (dlgProduction.DialogResult == DialogResult.Cancel)
                this.Visible = true;
        }

        private void btn_performance_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Performance dlgPerformance = new Performance(this);
            dlgPerformance.ShowDialog();

            if (dlgPerformance.DialogResult == DialogResult.Cancel)
                this.Visible = true;
        }

        private void btn_comprehensive_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ComMonitoring dlgComMonitoring = new ComMonitoring(this);
            dlgComMonitoring.ShowDialog();

            if (dlgComMonitoring.DialogResult == DialogResult.Cancel)
                this.Visible = true;
        }

        public static bool updateState = false;
        private void btn_Update_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateForm dlgUpdate = new UpdateForm(this);
            dlgUpdate.ShowDialog();

            if (dlgUpdate.DialogResult == DialogResult.OK)
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                cmd = new MySqlCommand("", conn);

                string sql = "UPDATE user_info SET ";
                sql += " upw='" + LoginForm.upw + "', ";
                sql += " uadress='" + dlgUpdate.tb_Adress.Text + "', uphone1='" + dlgUpdate.tb_Phone1.Text + "', ";
                sql += " uphone2='" + dlgUpdate.tb_Phone2.Text + "', uphone3='" + dlgUpdate.tb_Phone3.Text + "' ";
                sql += " WHERE uid='" + dlgUpdate.tb_userID.Text + "'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                this.Visible = true;
                MessageBox.Show("회원정보수정이 완료되었습니다.\n다시 로그인해주세요.");
                btn_Logout.PerformClick();
            }
            else if (dlgUpdate.DialogResult == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DeleteForm dlgDelete = new DeleteForm(this);
            dlgDelete.ShowDialog();

            if (dlgDelete.DialogResult == DialogResult.OK)
            {
                this.Visible = true;

                conn = new MySqlConnection(strConn);
                conn.Open();
                cmd = new MySqlCommand("", conn);

                string sql = "DELETE FROM user_image WHERE fid='" + dlgDelete.tb_userID.Text + "'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                sql = "DELETE FROM user_info WHERE uid='" + dlgDelete.tb_userID.Text + "'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                this.Visible = true;
                MessageBox.Show("회원정보가 삭제되었습니다.");
                btn_Logout.PerformClick();
            }
            else if (dlgDelete.DialogResult == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SelectForm dlgSelect = new SelectForm(this);
            dlgSelect.ShowDialog();

            if (dlgSelect.DialogResult == DialogResult.OK)
                this.Visible = true;
            else if (dlgSelect.DialogResult == DialogResult.Cancel)
                this.Visible = true;
        }

        private void pb_Logo_Click(object sender, EventArgs e)
        {
            RandomValue dlgRndVal = new RandomValue();
            dlgRndVal.Show();
        }
    }
}
