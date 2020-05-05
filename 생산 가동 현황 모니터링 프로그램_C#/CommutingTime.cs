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
    public partial class CommutingTime : MetroForm
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        DataSet ds = new DataSet();
        MySqlDataAdapter adt = new MySqlDataAdapter();
        Timer clock = new Timer();
        Timer refresh = new Timer();
        public static bool stateA1 = false, stateB1 = false, stateB2 = false;
        public static bool stateC1 = false, stateC2 = false, stateC3 = false;

        public CommutingTime()
        {
            InitializeComponent();
        }
        private MainForm mainForm = null;
        public CommutingTime(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void CommutingTime_Load(object sender, EventArgs e)
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

            string sql = "SELECT * FROM commuting_time";
            adt = new MySqlDataAdapter(sql, conn);
            adt.Fill(ds, "Tab1");

            DataRow row;
            ListViewItem item = new ListViewItem();

            list_Commute.Clear();
            list_Commute.BeginUpdate();
            list_Commute.View = View.Details;
            list_Commute.Columns.Add("아이디", 250, HorizontalAlignment.Center);
            list_Commute.Columns.Add("이름", 235, HorizontalAlignment.Center);
            list_Commute.Columns.Add("출근시간", 400, HorizontalAlignment.Center);
            list_Commute.Columns.Add("퇴근시간", 400, HorizontalAlignment.Center);
            list_Commute.Columns.Add("작업라인", 200, HorizontalAlignment.Center);
            list_Commute.Columns.Add("책임유무", 200, HorizontalAlignment.Center);


            sql = "SELECT * FROM commuting_time";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            stateA1 = false; stateB1 = false; stateB2 = false;
            stateC1 = false; stateC2 = false; stateC3 = false;
            int i = 0;
            while (reader.Read())
            {
                if (reader["작업라인"].ToString() == "A1" && reader["책임유무"].ToString() == "Yes")
                    stateA1 = true;
                else if (reader["작업라인"].ToString() == "B1" && reader["책임유무"].ToString() == "Yes")
                    stateB1 = true;
                else if (reader["작업라인"].ToString() == "B2" && reader["책임유무"].ToString() == "Yes")
                    stateB2 = true;
                else if (reader["작업라인"].ToString() == "C1" && reader["책임유무"].ToString() == "Yes")
                    stateC1 = true;
                else if (reader["작업라인"].ToString() == "C2" && reader["책임유무"].ToString() == "Yes")
                    stateC2 = true;
                else if (reader["작업라인"].ToString() == "C3" && reader["책임유무"].ToString() == "Yes")
                    stateC3 = true;

                row = ds.Tables[0].Rows[i];

                item = new ListViewItem(row["아이디"].ToString());
                item.SubItems.Add(row["이름"].ToString());
                item.SubItems.Add(row["출근시간"].ToString());
                item.SubItems.Add(row["퇴근시간"].ToString());
                item.SubItems.Add(row["작업라인"].ToString());
                item.SubItems.Add(row["책임유무"].ToString());

                list_Commute.Items.Add(item);
                i++;
            }
            list_Commute.EndUpdate();
            reader.Close();
            conn.Close();
            ds.Clear();

            clock.Interval = 1000;
            clock.Tick += Timer_Tick;
            clock.Start();

            refresh.Interval = 2000;
            refresh.Tick += Refresh_Tick;
            refresh.Start();
        }
        // 그룹박스 테두리 및 배경 색 변경 함수
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }
        // 현재 시간 표시 함수
        private void Timer_Tick(object sender, EventArgs e)
        {
            label_Date.Text = string.Format("{0:yyyy.MM.dd (ddd)}", DateTime.Now);
            label_Time.Text = string.Format("{0:hh:mm:ss}", DateTime.Now);
            label_APM.Text = string.Format("{0:tt}", DateTime.Now);
        }
        private void CommutingTime_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            clock.Stop();
            refresh.Stop();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void btn_gotoWork_Click(object sender, EventArgs e)
        {
            GotoWork dlgGotoWork = new GotoWork(this);
            dlgGotoWork.ShowDialog();

            if (dlgGotoWork.DialogResult == DialogResult.OK)
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                cmd = new MySqlCommand("", conn);

                string sql = "SELECT 출근시간 FROM commuting_time WHERE 아이디='" + LoginForm.uid + "'";
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();

                string[] attendTime = { };
                while (reader.Read())
                {
                    attendTime = reader["출근시간"].ToString().Split(' ');
                }
                reader.Close();

                // 출근 체크한 날짜가 DB에 있는 출근 날짜와 같지 않을 때 실행
                if (attendTime[0].ToString() != DateTime.Now.ToString("yyyy-MM-dd"))
                {
                    string dateTime = DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm:ss");

                    sql = "UPDATE commuting_time SET ";
                    sql += " 출근시간='" + dateTime + "', " + "퇴근시간=NULL, ";
                    sql += "작업라인='" + GotoWork.strWorkLine + "', 책임유무='" + GotoWork.strYesNo + "' ";
                    sql += " WHERE 아이디='" + LoginForm.uid + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("출근 처리가 이미 되었습니다.");
            }
        }
        private void btn_leaveWork_Click(object sender, EventArgs e)
        {
            LeaveWork dlgLeaveWork = new LeaveWork(this);
            dlgLeaveWork.ShowDialog();

            if (dlgLeaveWork.DialogResult == DialogResult.OK)
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
                cmd = new MySqlCommand("", conn);

                string sql = "SELECT 출근시간, 퇴근시간 FROM commuting_time WHERE 아이디='" + LoginForm.uid + "'";
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();

                string attendTime = "", leaveTime = "";
                while (reader.Read())
                {
                    attendTime = reader["출근시간"].ToString();
                    leaveTime = reader["퇴근시간"].ToString();
                }
                reader.Close();

                if (attendTime != "" && leaveTime == "")
                {
                    string dateTime = DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm:ss");

                    sql = "UPDATE commuting_time SET ";
                    sql += "퇴근시간='" + dateTime + "' " + "WHERE 아이디='" + LoginForm.uid + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                else if (leaveTime != "")
                    MessageBox.Show("퇴근 처리가 이미 되었습니다.");
                else
                    MessageBox.Show("출근 처리를 먼저 해주세요.");
            }
        }
        private void Refresh_Tick(object sender, EventArgs e)
        {
            // 리스트 뷰 설정
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            string sql = "SELECT * FROM commuting_time";
            adt = new MySqlDataAdapter(sql, conn);
            adt.Fill(ds, "Tab1");

            DataRow row;
            ListViewItem item = new ListViewItem();

            list_Commute.Clear();
            list_Commute.BeginUpdate();
            list_Commute.View = View.Details;
            list_Commute.Columns.Add("아이디", 250, HorizontalAlignment.Center);
            list_Commute.Columns.Add("이름", 235, HorizontalAlignment.Center);
            list_Commute.Columns.Add("출근시간", 400, HorizontalAlignment.Center);
            list_Commute.Columns.Add("퇴근시간", 400, HorizontalAlignment.Center);
            list_Commute.Columns.Add("작업라인", 200, HorizontalAlignment.Center);
            list_Commute.Columns.Add("책임유무", 200, HorizontalAlignment.Center);


            sql = "SELECT * FROM commuting_time";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            string[] aryID = { }, aryName = { }, aryAttend = { }, aryLeave = { }, aryYesNo = { };

            int i = 0;
            while (reader.Read())
            {
                row = ds.Tables[0].Rows[i];

                item = new ListViewItem(row["아이디"].ToString());
                item.SubItems.Add(row["이름"].ToString());
                item.SubItems.Add(row["출근시간"].ToString());
                item.SubItems.Add(row["퇴근시간"].ToString());
                item.SubItems.Add(row["작업라인"].ToString());
                item.SubItems.Add(row["책임유무"].ToString());

                list_Commute.Items.Add(item);
                i++;

                Array.Resize(ref aryID, aryID.Length + 1);
                Array.Resize(ref aryName, aryName.Length + 1);
                Array.Resize(ref aryAttend, aryAttend.Length + 1);
                Array.Resize(ref aryLeave, aryLeave.Length + 1);
                Array.Resize(ref aryYesNo, aryYesNo.Length + 1);

                aryID[aryID.Length - 1] = reader["아이디"].ToString();
                aryName[aryName.Length - 1] = reader["이름"].ToString();
                aryAttend[aryAttend.Length - 1] = reader["출근시간"].ToString();
                aryLeave[aryLeave.Length - 1] = reader["퇴근시간"].ToString();
                aryYesNo[aryYesNo.Length - 1] = reader["책임유무"].ToString();
            }
            list_Commute.EndUpdate();
            reader.Close();
            for (int k = 0; k < aryAttend.Length; k++)
            {
                if (aryAttend[k] != "" && aryLeave[k] != "")
                {
                    string[] aryAttendTime = aryAttend[k].Split(' ');
                    string AttendTime = aryAttendTime[0] + " " + aryAttendTime[2];
                    string[] aryLeaveTime = aryLeave[k].Split(' ');
                    string LeaveTime = aryLeaveTime[0] + " " + aryLeaveTime[2];

                    sql = "INSERT INTO total_commuting_time VALUES ('";
                    sql += aryID[k] + "', '" + aryName[k] + "', '";
                    sql += AttendTime + "', '" + LeaveTime + "', '" + aryYesNo[k] + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    sql = "UPDATE commuting_time SET 출근시간=NULL, 퇴근시간=NULL WHERE 아이디='" + aryID[k] + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }

            sql = "SELECT * FROM commuting_time";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            stateA1 = false; stateB1 = false; stateB2 = false;
            stateC1 = false; stateC2 = false; stateC3 = false;
            while (reader.Read())
            {
                if (reader["출근시간"].ToString() != "" && reader["퇴근시간"].ToString() == "")
                {
                    if (reader["작업라인"].ToString() == "A1" && reader["책임유무"].ToString() == "Yes")
                        stateA1 = true;
                    if (reader["작업라인"].ToString() == "B1" && reader["책임유무"].ToString() == "Yes")
                        stateB1 = true;
                    if (reader["작업라인"].ToString() == "B2" && reader["책임유무"].ToString() == "Yes")
                        stateB2 = true;
                    if (reader["작업라인"].ToString() == "C1" && reader["책임유무"].ToString() == "Yes")
                        stateC1 = true;
                    if (reader["작업라인"].ToString() == "C2" && reader["책임유무"].ToString() == "Yes")
                        stateC2 = true;
                    if (reader["작업라인"].ToString() == "C3" && reader["책임유무"].ToString() == "Yes")
                        stateC3 = true;
                }
            }
            reader.Close();
            conn.Close();
            ds.Clear();

            Array.Resize(ref aryAttend, 0);
            Array.Resize(ref aryLeave, 0);
            Array.Resize(ref aryID, 0);
            Array.Resize(ref aryName, 0);
            Array.Resize(ref aryYesNo, 0);
        }
    }
}
