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
    public partial class Performance : MetroForm
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        Timer timer = new Timer();
        Timer clock = new Timer();

        public Performance()
        {
            InitializeComponent();
        }
        private MainForm mainForm = null;
        public Performance(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void Performance_Load(object sender, EventArgs e)
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

            pb_A1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_B1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_B2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_C1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_C2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_C3.SizeMode = PictureBoxSizeMode.StretchImage;
            
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            string sql = "SELECT 설비상태, 생산수량, 목표량, ROUND(생산수량/목표량*100) AS 달성률 FROM pro_info";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            int i = 0;
            while(reader.Read())
            {
                string achieve = reader["달성률"].ToString();
                if (int.Parse(achieve) > 100)
                {
                    achieve = "100";
                }
                switch (i)
                {
                    case 0:
                        if (reader["설비상태"].ToString().Equals("가동") == true)
                        {
                            cpb_A1.ProgressColor = Color.FromArgb(0, 100, 200);
                            cpb_A1.OuterColor = Color.FromArgb(220, 230, 250);
                            pb_A1.ImageLocation = "C:\\프로젝트Image\\가동중 램프.png";
                        }
                        else
                        {
                            pb_A1.ImageLocation = "C:\\프로젝트Image\\비가동중 램프.png";
                            cpb_A1.ProgressColor = Color.FromArgb(200, 50, 0);
                            cpb_A1.OuterColor = Color.FromArgb(250, 230, 220);
                        }
                        label_productA1.Text = reader["생산수량"].ToString();
                        label_achieveA1.Text = reader["목표량"].ToString();
                        cpb_A1.Text = reader["달성률"].ToString();
                        cpb_A1.Value = int.Parse(achieve);
                        break;
                    case 1:
                        if (reader["설비상태"].ToString().Equals("가동") == true)
                        {
                            cpb_B1.ProgressColor = Color.FromArgb(0, 100, 200);
                            cpb_B1.OuterColor = Color.FromArgb(220, 230, 250);
                            pb_B1.ImageLocation = "C:\\프로젝트Image\\가동중 램프.png";
                        }
                        else
                        {
                            pb_B1.ImageLocation = "C:\\프로젝트Image\\비가동중 램프.png";
                            cpb_B1.ProgressColor = Color.FromArgb(200, 50, 0);
                            cpb_B1.OuterColor = Color.FromArgb(250, 230, 220);
                        }
                        label_productB1.Text = reader["생산수량"].ToString();
                        label_achieveB1.Text = reader["목표량"].ToString();
                        cpb_B1.Text = reader["달성률"].ToString();
                        cpb_B1.Value = int.Parse(achieve);
                        break;
                    case 2:
                        if (reader["설비상태"].ToString().Equals("가동") == true)
                        {
                            cpb_B2.ProgressColor = Color.FromArgb(0, 100, 200);
                            cpb_B2.OuterColor = Color.FromArgb(220, 230, 250);
                            pb_B2.ImageLocation = "C:\\프로젝트Image\\가동중 램프.png";
                        }
                        else
                        {
                            pb_B2.ImageLocation = "C:\\프로젝트Image\\비가동중 램프.png";
                            cpb_B2.ProgressColor = Color.FromArgb(200, 50, 0);
                            cpb_B2.OuterColor = Color.FromArgb(250, 230, 220);
                        }
                        label_productB2.Text = reader["생산수량"].ToString();
                        label_achieveB2.Text = reader["목표량"].ToString();
                        cpb_B2.Text = reader["달성률"].ToString();
                        cpb_B2.Value = int.Parse(achieve);
                        break;
                    case 3:
                        if (reader["설비상태"].ToString().Equals("가동") == true)
                        {
                            cpb_C1.ProgressColor = Color.FromArgb(0, 100, 200);
                            cpb_C1.OuterColor = Color.FromArgb(220, 230, 250);
                            pb_C1.ImageLocation = "C:\\프로젝트Image\\가동중 램프.png";
                        }
                        else
                        {
                            pb_C1.ImageLocation = "C:\\프로젝트Image\\비가동중 램프.png";
                            cpb_C1.ProgressColor = Color.FromArgb(200, 50, 0);
                            cpb_C1.OuterColor = Color.FromArgb(250, 230, 220);
                        }
                        label_productC1.Text = reader["생산수량"].ToString();
                        label_achieveC1.Text = reader["목표량"].ToString();
                        cpb_C1.Text = reader["달성률"].ToString();
                        cpb_C1.Value = int.Parse(achieve);
                        break;
                    case 4:
                        if (reader["설비상태"].ToString().Equals("가동") == true)
                        {
                            cpb_C2.ProgressColor = Color.FromArgb(0, 100, 200);
                            cpb_C2.OuterColor = Color.FromArgb(220, 230, 250);
                            pb_C2.ImageLocation = "C:\\프로젝트Image\\가동중 램프.png";
                        }
                        else
                        {
                            pb_C2.ImageLocation = "C:\\프로젝트Image\\비가동중 램프.png";
                            cpb_C2.ProgressColor = Color.FromArgb(200, 50, 0);
                            cpb_C2.OuterColor = Color.FromArgb(250, 230, 220);
                        }
                        label_productC2.Text = reader["생산수량"].ToString();
                        label_achieveC2.Text = reader["목표량"].ToString();
                        cpb_C2.Text = reader["달성률"].ToString();
                        cpb_C2.Value = int.Parse(achieve);
                        break;
                    case 5:
                        if (reader["설비상태"].ToString().Equals("가동") == true)
                        {
                            cpb_C3.ProgressColor = Color.FromArgb(0, 100, 200);
                            cpb_C3.OuterColor = Color.FromArgb(220, 230, 250);
                            pb_C3.ImageLocation = "C:\\프로젝트Image\\가동중 램프.png";
                        }
                        else
                        {
                            pb_C3.ImageLocation = "C:\\프로젝트Image\\비가동중 램프.png";
                            cpb_C3.ProgressColor = Color.FromArgb(200, 50, 0);
                            cpb_C3.OuterColor = Color.FromArgb(250, 230, 220);
                        }
                        label_productC3.Text = reader["생산수량"].ToString();
                        label_achieveC3.Text = reader["목표량"].ToString();
                        cpb_C3.Text = reader["달성률"].ToString();
                        cpb_C3.Value = int.Parse(achieve);
                        break;
                }

                i++;
            }
            reader.Close();
            conn.Close();

            timer.Interval = 2000;
            timer.Tick += new EventHandler(Performance_Load);
            timer.Start();

            clock.Interval = 1000;
            clock.Tick += Timer_Tick;
            clock.Start();
        }
        // 그룹박스 테두리 및 배경 색 변경 함수
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void Performance_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            try
            {
                timer.Stop();
                clock.Stop();
            }
            catch { }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label_Date.Text = string.Format("{0:yyyy.MM.dd (ddd)}", DateTime.Now);
            label_Time.Text = string.Format("{0:hh:mm:ss}", DateTime.Now);
            label_APM.Text = string.Format("{0:tt}", DateTime.Now);
        }
    }
}
