using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace 생산_가동_현황_모니터링_프로그램
{
    public partial class Operation : MetroForm
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        Timer timer = new Timer();
        Timer clock = new Timer();

        public Operation()
        {
            InitializeComponent();
        }
        private MainForm mainForm = null;
        public Operation(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void Operation_Load(object sender, EventArgs e)
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

            pb_B1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_B2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_C1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_C2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_C3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_A1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            String sql = "SELECT 설비번호, 설비명, 설비상태, 품목명, 생산수량 FROM pro_info";
            adt = new MySqlDataAdapter(sql, conn);
            adt.Fill(ds, "Tab1");

            DataRow row;
            ListViewItem item = new ListViewItem();

            list_Operation.Clear();
            list_Operation.BeginUpdate();
            list_Operation.View = View.Details;
            list_Operation.Columns.Add("설비No", 70, HorizontalAlignment.Center);
            list_Operation.Columns.Add("설비명", 200, HorizontalAlignment.Center);
            list_Operation.Columns.Add("가동유무", 100, HorizontalAlignment.Center);
            list_Operation.Columns.Add("품목코드", 200, HorizontalAlignment.Center);
            list_Operation.Columns.Add("금일생산", 120, HorizontalAlignment.Center);

            sql = "SELECT * FROM pro_info";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                row = ds.Tables[0].Rows[i];

                item = new ListViewItem(row["설비번호"].ToString());
                item.SubItems.Add(row["설비명"].ToString());
                item.SubItems.Add(row["설비상태"].ToString());
                item.SubItems.Add(row["품목명"].ToString());
                item.SubItems.Add(row["생산수량"].ToString());

                list_Operation.Items.Add(item);

                list_Operation.Items[i].UseItemStyleForSubItems = false;
                if (item.SubItems.Add(row["설비상태"].ToString()).Text.Equals("가동") == true)
                {
                    switch (i)
                    {
                        case 0:
                            pb_A1.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
                            label_A1.BackColor = Color.FromArgb(18, 33, 255);
                            break;
                        case 1:
                            pb_B1.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
                            label_B1.BackColor = Color.FromArgb(18, 33, 255);
                            break;
                        case 2:
                            pb_B2.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
                            label_B2.BackColor = Color.FromArgb(18, 33, 255);
                            break;
                        case 3:
                            pb_C1.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
                            label_C1.BackColor = Color.FromArgb(18, 33, 255);
                            break;
                        case 4:
                            pb_C2.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
                            label_C2.BackColor = Color.FromArgb(18, 33, 255);
                            break;
                        case 5:
                            pb_C3.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
                            label_C3.BackColor = Color.FromArgb(18, 33, 255);
                            break;
                    }
                    list_Operation.Items[i].ForeColor = Color.Blue;
                    list_Operation.Items[i].SubItems[2].ForeColor = Color.Blue;
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            pb_A1.ImageLocation = "C:\\프로젝트Image\\비가동중 설비.png";
                            label_A1.BackColor = Color.FromArgb(255, 13, 35);
                            break;
                        case 1:
                            pb_B1.ImageLocation = "C:\\프로젝트Image\\비가동중 설비.png";
                            label_B1.BackColor = Color.FromArgb(255, 13, 35);
                            break;
                        case 2:
                            pb_B2.ImageLocation = "C:\\프로젝트Image\\비가동중 설비.png";
                            label_B2.BackColor = Color.FromArgb(255, 13, 35);
                            break;
                        case 3:
                            pb_C1.ImageLocation = "C:\\프로젝트Image\\비가동중 설비.png";
                            label_C1.BackColor = Color.FromArgb(255, 13, 35);
                            break;
                        case 4:
                            pb_C2.ImageLocation = "C:\\프로젝트Image\\비가동중 설비.png";
                            label_C2.BackColor = Color.FromArgb(255, 13, 35);
                            break;
                        case 5:
                            pb_C3.ImageLocation = "C:\\프로젝트Image\\비가동중 설비.png";
                            label_C3.BackColor = Color.FromArgb(255, 13, 35);
                            break;
                    }
                    list_Operation.Items[i].ForeColor = Color.Red;
                    list_Operation.Items[i].SubItems[2].ForeColor = Color.Red;
                }

                i++;
            }
            ds.Clear();                 // 데이터셋 초기화
            reader.Close();
            conn.Close();
            list_Operation.EndUpdate();

            clock.Interval = 1000;
            clock.Tick += Timer_Tick1;
            clock.Start();
        }
        // 그룹박스 테두리 및 배경 색 변경 함수
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }
        private void Operation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            try
            {
                timer.Stop();
                clock.Stop();
            }
            catch { }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        DataSet ds = new DataSet();
        MySqlDataAdapter adt = new MySqlDataAdapter();
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            String sql = "SELECT 설비번호, 설비명, 설비상태, 품목명, 생산수량 FROM pro_info";
            adt = new MySqlDataAdapter(sql, conn);
            adt.Fill(ds, "Tab1");

            DataRow row;
            ListViewItem item = new ListViewItem();

            list_Operation.Clear();
            list_Operation.BeginUpdate();
            list_Operation.View = View.Details;
            list_Operation.Columns.Add("설비No", 70, HorizontalAlignment.Center);
            list_Operation.Columns.Add("설비명", 200, HorizontalAlignment.Center);
            list_Operation.Columns.Add("가동유무", 100, HorizontalAlignment.Center);
            list_Operation.Columns.Add("품목코드", 200, HorizontalAlignment.Center);
            list_Operation.Columns.Add("금일생산", 120, HorizontalAlignment.Center);

            sql = "SELECT * FROM pro_info";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                row = ds.Tables[0].Rows[i];

                item = new ListViewItem(row["설비번호"].ToString());
                item.SubItems.Add(row["설비명"].ToString());
                item.SubItems.Add(row["설비상태"].ToString());
                item.SubItems.Add(row["품목명"].ToString());
                item.SubItems.Add(row["생산수량"].ToString());

                list_Operation.Items.Add(item);

                list_Operation.Items[i].UseItemStyleForSubItems = false;
                if (item.SubItems.Add(row["설비상태"].ToString()).Text.Equals("가동") == true)
                {
                    switch (i)
                    {
                        case 0:
                            pb_A1.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
                            label_A1.BackColor = Color.FromArgb(18, 33, 255);
                            break;
                        case 1:
                            pb_B1.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
                            label_B1.BackColor = Color.FromArgb(18, 33, 255);
                            break;
                        case 2:
                            pb_B2.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
                            label_B2.BackColor = Color.FromArgb(18, 33, 255);
                            break;
                        case 3:
                            pb_C1.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
                            label_C1.BackColor = Color.FromArgb(18, 33, 255);
                            break;
                        case 4:
                            pb_C2.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
                            label_C2.BackColor = Color.FromArgb(18, 33, 255);
                            break;
                        case 5:
                            pb_C3.ImageLocation = "C:\\프로젝트Image\\가동중 설비.png";
                            label_C3.BackColor = Color.FromArgb(18, 33, 255);
                            break;
                    }
                    list_Operation.Items[i].ForeColor = Color.Blue;
                    list_Operation.Items[i].SubItems[2].ForeColor = Color.Blue;
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            pb_A1.ImageLocation = "C:\\프로젝트Image\\비가동중 설비.png";
                            label_A1.BackColor = Color.FromArgb(255, 13, 35);
                            break;
                        case 1:
                            pb_B1.ImageLocation = "C:\\프로젝트Image\\비가동중 설비.png";
                            label_B1.BackColor = Color.FromArgb(255, 13, 35);
                            break;
                        case 2:
                            pb_B2.ImageLocation = "C:\\프로젝트Image\\비가동중 설비.png";
                            label_B2.BackColor = Color.FromArgb(255, 13, 35);
                            break;
                        case 3:
                            pb_C1.ImageLocation = "C:\\프로젝트Image\\비가동중 설비.png";
                            label_C1.BackColor = Color.FromArgb(255, 13, 35);
                            break;
                        case 4:
                            pb_C2.ImageLocation = "C:\\프로젝트Image\\비가동중 설비.png";
                            label_C2.BackColor = Color.FromArgb(255, 13, 35);
                            break;
                        case 5:
                            pb_C3.ImageLocation = "C:\\프로젝트Image\\비가동중 설비.png";
                            label_C3.BackColor = Color.FromArgb(255, 13, 35);
                            break;
                    }
                    list_Operation.Items[i].ForeColor = Color.Red;
                    list_Operation.Items[i].SubItems[2].ForeColor = Color.Red;
                }

                i++;
            }
            ds.Clear();                 // 데이터셋 초기화
            reader.Close();
            conn.Close();
            list_Operation.EndUpdate();
        }

        private void btn_timerStart_Click(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void btn_timerStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btn_Refresh.PerformClick();
        }
        private void Timer_Tick1(object sender, EventArgs e)
        {
            label_Date.Text = string.Format("{0:yyyy.MM.dd (ddd)}", DateTime.Now);
            label_Time.Text = string.Format("{0:hh:mm:ss}", DateTime.Now);
            label_APM.Text = string.Format("{0:tt}", DateTime.Now);
        }
    }
}
