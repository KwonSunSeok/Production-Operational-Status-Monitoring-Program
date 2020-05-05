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
    public partial class ComMonitoring : MetroForm
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        DataSet ds = new DataSet();
        MySqlDataAdapter adt = new MySqlDataAdapter();
        Timer clock = new Timer();
        Timer refresh = new Timer();

        public ComMonitoring()
        {
            InitializeComponent();
        }
        private MainForm mainForm = null;
        public ComMonitoring(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }
        private void ComMonitoring_Load(object sender, EventArgs e)
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

            // 리스트 뷰 설정
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            String sql = "SELECT *, 생산수량/목표량*100 AS 달성률, 불량수량/생산수량*100 AS 불량률 FROM pro_info";
            adt = new MySqlDataAdapter(sql, conn);
            adt.Fill(ds, "Tab1");

            DataRow row;
            ListViewItem item = new ListViewItem();

            listView.Clear();
            listView.BeginUpdate();
            listView.View = View.Details;
            listView.Columns.Add("설비번호", 150, HorizontalAlignment.Center);
            listView.Columns.Add("설비명", 130, HorizontalAlignment.Center);
            listView.Columns.Add("설비상태", 150, HorizontalAlignment.Center);
            listView.Columns.Add("책임자", 130, HorizontalAlignment.Center);
            listView.Columns.Add("품목명", 130, HorizontalAlignment.Center);
            listView.Columns.Add("품목번호", 155, HorizontalAlignment.Center);
            listView.Columns.Add("작업시간", 150, HorizontalAlignment.Center);
            listView.Columns.Add("목표량", 130, HorizontalAlignment.Center);
            listView.Columns.Add("생산수량", 150, HorizontalAlignment.Center);
            listView.Columns.Add("불량수량", 150, HorizontalAlignment.Center);
            listView.Columns.Add("달성률", 130, HorizontalAlignment.Center);
            listView.Columns.Add("불량률", 130, HorizontalAlignment.Center);


            sql = "SELECT *, ROUND(생산수량/목표량*100) AS 달성률, 불량수량/생산수량*100 AS 불량률 FROM pro_info";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                row = ds.Tables[0].Rows[i];

                item = new ListViewItem(row["설비번호"].ToString());
                item.SubItems.Add(row["설비명"].ToString());
                item.SubItems.Add(row["설비상태"].ToString());
                item.SubItems.Add(row["책임자"].ToString());
                item.SubItems.Add(row["품목명"].ToString());
                item.SubItems.Add(row["품목번호"].ToString());
                item.SubItems.Add(row["작업시간"].ToString());
                item.SubItems.Add(row["목표량"].ToString());
                item.SubItems.Add(row["생산수량"].ToString());
                item.SubItems.Add(row["불량수량"].ToString());
                item.SubItems.Add(row["달성률"].ToString());
                item.SubItems.Add(row["불량률"].ToString());

                listView.Items.Add(item);

                listView.Items[i].UseItemStyleForSubItems = false;
                if (item.SubItems.Add(row["설비상태"].ToString()).Text.Equals("가동") == true)
                    listView.Items[i].SubItems[2].ForeColor = Color.Blue;
                else
                    listView.Items[i].SubItems[2].ForeColor = Color.Red;
                i++;
            }
            listView.EndUpdate();
            reader.Close();
            conn.Close();
            ds.Clear();

            // 리스트뷰 행 높이 지정
            SetHeight(listView, 60);
            // 시계 설정
            clock.Interval = 1000;
            clock.Tick += Timer_Tick;
            clock.Start();
            // 갱신 설정
            refresh.Interval = 5000;
            refresh.Tick += Refresh_Tick;
        }
        // 그룹박스 테두리 및 배경 색 변경 함수
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }
        // 폼 닫힐시
        private void ComMonitoring_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            try
            {
                clock.Stop();
            }
            catch { }
        }
        // 나가기 버튼
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        //// 리스트뷰 행 색 교차 변경
        //public void SetAlternatingRowColors(ListView lst, Color color1, Color color2)
        //{
        //    //// 리스트뷰 행 색상 교차 변경
        //    //SetAlternatingRowColors(listView, Color.FromArgb(210, 210, 255), Color.FromArgb(157, 157, 255));
        //    foreach (ListViewItem item in lst.Items)
        //    {
        //        if ((item.Index % 2) == 0)
        //            item.BackColor = color1;
        //        else
        //            item.BackColor = color2;
        //    }
        //}
        // 리스트뷰 헤더 색상 변경
        private void listView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
            e.DrawText();
        }
        // 리스트뷰 행 높이 지정
        private void SetHeight(ListView LV, int height)
        {
            // listView 높이 지정
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            LV.SmallImageList = imgList;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label_Date.Text = string.Format("{0:yyyy.MM.dd (ddd)}", DateTime.Now);
            label_Time.Text = string.Format("{0:hh:mm:ss}", DateTime.Now);
            label_APM.Text = string.Format("{0:tt}", DateTime.Now);
        }

        private void Refresh_Tick(object sender, EventArgs e)
        {
            // 리스트 뷰 설정
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            String sql = "SELECT *, 생산수량/목표량*100 AS 달성률, 불량수량/생산수량*100 AS 불량률 FROM pro_info";
            adt = new MySqlDataAdapter(sql, conn);
            adt.Fill(ds, "Tab1");

            DataRow row;
            ListViewItem item = new ListViewItem();

            listView.Clear();
            listView.BeginUpdate();
            listView.View = View.Details;
            listView.Columns.Add("설비번호", 150, HorizontalAlignment.Center);
            listView.Columns.Add("설비명", 130, HorizontalAlignment.Center);
            listView.Columns.Add("설비상태", 150, HorizontalAlignment.Center);
            listView.Columns.Add("책임자", 130, HorizontalAlignment.Center);
            listView.Columns.Add("품목명", 130, HorizontalAlignment.Center);
            listView.Columns.Add("품목번호", 155, HorizontalAlignment.Center);
            listView.Columns.Add("작업시간", 150, HorizontalAlignment.Center);
            listView.Columns.Add("목표량", 130, HorizontalAlignment.Center);
            listView.Columns.Add("생산수량", 150, HorizontalAlignment.Center);
            listView.Columns.Add("불량수량", 150, HorizontalAlignment.Center);
            listView.Columns.Add("달성률", 130, HorizontalAlignment.Center);
            listView.Columns.Add("불량률", 130, HorizontalAlignment.Center);


            sql = "SELECT *, ROUND(생산수량/목표량*100) AS 달성률, 불량수량/생산수량*100 AS 불량률 FROM pro_info";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                row = ds.Tables[0].Rows[i];

                item = new ListViewItem(row["설비번호"].ToString());
                item.SubItems.Add(row["설비명"].ToString());
                item.SubItems.Add(row["설비상태"].ToString());
                item.SubItems.Add(row["책임자"].ToString());
                item.SubItems.Add(row["품목명"].ToString());
                item.SubItems.Add(row["품목번호"].ToString());
                item.SubItems.Add(row["작업시간"].ToString());
                item.SubItems.Add(row["목표량"].ToString());
                item.SubItems.Add(row["생산수량"].ToString());
                item.SubItems.Add(row["불량수량"].ToString());
                item.SubItems.Add(row["달성률"].ToString());
                item.SubItems.Add(row["불량률"].ToString());

                listView.Items.Add(item);

                listView.Items[i].UseItemStyleForSubItems = false;
                if (item.SubItems.Add(row["설비상태"].ToString()).Text.Equals("가동") == true)
                    listView.Items[i].SubItems[2].ForeColor = Color.Blue;
                else
                    listView.Items[i].SubItems[2].ForeColor = Color.Red;
                i++;
            }
            listView.EndUpdate();
            reader.Close();
            conn.Close();
            ds.Clear();

            // 리스트뷰 행 높이 지정
            SetHeight(listView, 60);
        }

        private void btn_timerStart_Click(object sender, EventArgs e)
        {
            refresh.Start();
        }

        private void btn_timerStop_Click(object sender, EventArgs e)
        {
            refresh.Stop();
        }
    }
}
