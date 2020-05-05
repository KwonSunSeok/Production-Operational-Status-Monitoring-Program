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
    public partial class Production : MetroForm
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        Timer timer = new Timer();
        Timer clock = new Timer();

        public Production()
        {
            InitializeComponent();
        }
        private MainForm mainForm = null;
        public Production(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void Production_Load(object sender, EventArgs e)
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

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;

            label2.BackColor = Color.Transparent;
            label2.Parent = pictureBox7;
            label2.Location = new Point(210, 20);
            label8.BackColor = Color.Transparent;
            label8.Parent = pictureBox7;
            label8.Location = new Point(57, 96);
            label9.BackColor = Color.Transparent;
            label9.Parent = pictureBox7;
            label9.Location = new Point(219, 96);
            label10.BackColor = Color.Transparent;
            label10.Parent = pictureBox7;
            label10.Location = new Point(94, 162);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Parent = pictureBox7;
            pictureBox1.Location = new Point(150, 30);

            label3.BackColor = Color.Transparent;
            label3.Parent = pictureBox8;
            label3.Location = new Point(210, 20);
            label11.BackColor = Color.Transparent;
            label11.Parent = pictureBox8;
            label11.Location = new Point(57, 96);
            label12.BackColor = Color.Transparent;
            label12.Parent = pictureBox8;
            label12.Location = new Point(219, 96);
            label13.BackColor = Color.Transparent;
            label13.Parent = pictureBox8;
            label13.Location = new Point(94, 162);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox8;
            pictureBox2.Location = new Point(150, 30);

            label4.BackColor = Color.Transparent;
            label4.Parent = pictureBox9;
            label4.Location = new Point(210, 20);
            label14.BackColor = Color.Transparent;
            label14.Parent = pictureBox9;
            label14.Location = new Point(57, 96);
            label15.BackColor = Color.Transparent;
            label15.Parent = pictureBox9;
            label15.Location = new Point(219, 96);
            label16.BackColor = Color.Transparent;
            label16.Parent = pictureBox9;
            label16.Location = new Point(94, 162);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureBox9;
            pictureBox3.Location = new Point(150, 30);

            label5.BackColor = Color.Transparent;
            label5.Parent = pictureBox10;
            label5.Location = new Point(210, 20);
            label17.BackColor = Color.Transparent;
            label17.Parent = pictureBox10;
            label17.Location = new Point(57, 96);
            label18.BackColor = Color.Transparent;
            label18.Parent = pictureBox10;
            label18.Location = new Point(219, 96);
            label19.BackColor = Color.Transparent;
            label19.Parent = pictureBox10;
            label19.Location = new Point(94, 162);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Parent = pictureBox10;
            pictureBox4.Location = new Point(150, 30);

            label6.BackColor = Color.Transparent;
            label6.Parent = pictureBox11;
            label6.Location = new Point(210, 20);
            label20.BackColor = Color.Transparent;
            label20.Parent = pictureBox11;
            label20.Location = new Point(57, 96);
            label21.BackColor = Color.Transparent;
            label21.Parent = pictureBox11;
            label21.Location = new Point(219, 96);
            label22.BackColor = Color.Transparent;
            label22.Parent = pictureBox11;
            label22.Location = new Point(94, 162);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Parent = pictureBox11;
            pictureBox5.Location = new Point(150, 30);

            label7.BackColor = Color.Transparent;
            label7.Parent = pictureBox12;
            label7.Location = new Point(210, 20);
            label23.BackColor = Color.Transparent;
            label23.Parent = pictureBox12;
            label23.Location = new Point(57, 96);
            label24.BackColor = Color.Transparent;
            label24.Parent = pictureBox12;
            label24.Location = new Point(219, 96);
            label25.BackColor = Color.Transparent;
            label25.Parent = pictureBox12;
            label25.Location = new Point(94, 162);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Parent = pictureBox12;
            pictureBox6.Location = new Point(150, 30);

            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            string sql = "SELECT 설비상태, 책임자, 품목명, 품목번호 FROM pro_info";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            int i = 0;
            while(reader.Read())
            {
                switch(i)
                {
                    case 0:
                        if (reader["설비상태"].ToString().Equals("가동") == true)
                        {
                            pictureBox1.ImageLocation = "C:\\프로젝트Image\\가동중 램프.png";
                            pictureBox7.ImageLocation = "C:\\프로젝트Image\\공정별 생산 현황 배경(가동).png";
                        }
                        else
                        {
                            pictureBox1.ImageLocation = "C:\\프로젝트Image\\비가동중 램프.png";
                            pictureBox7.ImageLocation = "C:\\프로젝트Image\\공정별 생산 현황 배경(비가동).png";
                        }
                        label_operatorA1.Text = reader["책임자"].ToString();
                        label_itemA1.Text = reader["품목명"].ToString();
                        label_serialA1.Text = reader["품목번호"].ToString();
                        break;
                    case 1:
                        if (reader["설비상태"].ToString().Equals("가동") == true)
                        {
                            pictureBox2.ImageLocation = "C:\\프로젝트Image\\가동중 램프.png";
                            pictureBox8.ImageLocation = "C:\\프로젝트Image\\공정별 생산 현황 배경(가동).png";
                        }
                        else
                        {
                            pictureBox2.ImageLocation = "C:\\프로젝트Image\\비가동중 램프.png";
                            pictureBox8.ImageLocation = "C:\\프로젝트Image\\공정별 생산 현황 배경(비가동).png";
                        }
                        label_operatorB1.Text = reader["책임자"].ToString();
                        label_itemB1.Text = reader["품목명"].ToString();
                        label_serialB1.Text = reader["품목번호"].ToString();
                        break;
                    case 2:
                        if (reader["설비상태"].ToString().Equals("가동") == true)
                        {
                            pictureBox3.ImageLocation = "C:\\프로젝트Image\\가동중 램프.png";
                            pictureBox9.ImageLocation = "C:\\프로젝트Image\\공정별 생산 현황 배경(가동).png";
                        }
                        else
                        {
                            pictureBox3.ImageLocation = "C:\\프로젝트Image\\비가동중 램프.png";
                            pictureBox9.ImageLocation = "C:\\프로젝트Image\\공정별 생산 현황 배경(비가동).png";
                        }
                        label_operatorB2.Text = reader["책임자"].ToString();
                        label_itemB2.Text = reader["품목명"].ToString();
                        label_serialB2.Text = reader["품목번호"].ToString();
                        break;
                    case 3:
                        if (reader["설비상태"].ToString().Equals("가동") == true)
                        {
                            pictureBox4.ImageLocation = "C:\\프로젝트Image\\가동중 램프.png";
                            pictureBox10.ImageLocation = "C:\\프로젝트Image\\공정별 생산 현황 배경(가동).png";
                        }
                        else
                        {
                            pictureBox4.ImageLocation = "C:\\프로젝트Image\\비가동중 램프.png";
                            pictureBox10.ImageLocation = "C:\\프로젝트Image\\공정별 생산 현황 배경(비가동).png";
                        }
                        label_operatorC1.Text = reader["책임자"].ToString();
                        label_itemC1.Text = reader["품목명"].ToString();
                        label_serialC1.Text = reader["품목번호"].ToString();
                        break;
                    case 4:
                        if (reader["설비상태"].ToString().Equals("가동") == true)
                        {
                            pictureBox5.ImageLocation = "C:\\프로젝트Image\\가동중 램프.png";
                            pictureBox11.ImageLocation = "C:\\프로젝트Image\\공정별 생산 현황 배경(가동).png";
                        }
                        else
                        {
                            pictureBox5.ImageLocation = "C:\\프로젝트Image\\비가동중 램프.png";
                            pictureBox11.ImageLocation = "C:\\프로젝트Image\\공정별 생산 현황 배경(비가동).png";
                        }
                        label_operatorC2.Text = reader["책임자"].ToString();
                        label_itemC2.Text = reader["품목명"].ToString();
                        label_serialC2.Text = reader["품목번호"].ToString();
                        break;
                    case 5:
                        if (reader["설비상태"].ToString().Equals("가동") == true)
                        {
                            pictureBox6.ImageLocation = "C:\\프로젝트Image\\가동중 램프.png";
                            pictureBox12.ImageLocation = "C:\\프로젝트Image\\공정별 생산 현황 배경(가동).png";
                        }
                        else
                        {
                            pictureBox6.ImageLocation = "C:\\프로젝트Image\\비가동중 램프.png";
                            pictureBox12.ImageLocation = "C:\\프로젝트Image\\공정별 생산 현황 배경(비가동).png";
                        }
                        label_operatorC3.Text = reader["책임자"].ToString();
                        label_itemC3.Text = reader["품목명"].ToString();
                        label_serialC3.Text = reader["품목번호"].ToString();
                        break;
                }
                
                i++;
            }
            reader.Close();
            conn.Close();
            
            timer.Interval = 2000;
            timer.Tick += new EventHandler(Production_Load);
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
        private void Production_FormClosed(object sender, FormClosedEventArgs e)
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
