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
    public partial class SelectForm : MetroForm
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public SelectForm()
        {
            InitializeComponent();
        }
        private MainForm mainForm = null;
        public SelectForm(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void SelectForm_Load(object sender, EventArgs e)
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

            btn_Select.PerformClick();
        }
        // 그룹박스 테두리 및 배경 색 변경 함수
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        DataSet ds = new DataSet();
        MySqlDataAdapter adt = new MySqlDataAdapter();
        string uid, upw, uname, ubirth, ugender, uadress, uphone;

        private void btn_Select_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            String sql = "SELECT uid, upw, uname, ubirth, ugender, uadress, uphone1, uphone2, uphone3 FROM user_info";
            adt = new MySqlDataAdapter(sql, conn);
            adt.Fill(ds, "Tab1");

            DataRow row;
            ListViewItem item = new ListViewItem();

            list_UserInfo.Clear();
            list_UserInfo.BeginUpdate();
            list_UserInfo.View = View.Details;
            list_UserInfo.Columns.Add("아이디", 150, HorizontalAlignment.Center);
            list_UserInfo.Columns.Add("비밀번호", 150, HorizontalAlignment.Center);
            list_UserInfo.Columns.Add("이름", 150, HorizontalAlignment.Center);
            list_UserInfo.Columns.Add("생년월일", 150, HorizontalAlignment.Center);
            list_UserInfo.Columns.Add("성별", 120, HorizontalAlignment.Center);
            list_UserInfo.Columns.Add("주소", 530, HorizontalAlignment.Center);
            list_UserInfo.Columns.Add("핸드폰번호", 200, HorizontalAlignment.Center);

            sql = "SELECT * FROM user_info";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                row = ds.Tables[0].Rows[i];
                uid = row["uid"].ToString();
                for (int k = 0; k < row["upw"].ToString().Length; k++)
                {
                    upw += "*";
                }
                uname = row["uname"].ToString();
                ubirth = row["ubirth"].ToString();
                ugender = row["ugender"].ToString();
                uadress = row["uadress"].ToString();
                uphone = row["uphone1"].ToString() + "-" + row["uphone2"].ToString() + "-" + row["uphone3"].ToString();

                item = new ListViewItem(uid);
                item.SubItems.Add(upw);
                item.SubItems.Add(uname);
                item.SubItems.Add(ubirth);
                item.SubItems.Add(ugender);
                item.SubItems.Add(uadress);
                item.SubItems.Add(uphone);

                list_UserInfo.Items.Add(item);

                i++;
                upw = "";
            }
            ds.Clear();                 // 데이터셋 초기화
            reader.Close();
            list_UserInfo.EndUpdate();
            conn.Close();

        }

        public static string updateID;
        private void btn_Update_Click(object sender, EventArgs e)
        {
            bool state = false;
            updateID = tb_userID.Text;

            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            string sql = "SELECT uid FROM user_info";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string uid = reader["uid"].ToString();
                if (uid == tb_userID.Text)
                    state = true;
            }
            if (state == true)
            {
                SelectUpdateForm dlgUpdate = new SelectUpdateForm(this);
                dlgUpdate.ShowDialog();

                if (dlgUpdate.DialogResult == DialogResult.OK)
                {
                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    cmd = new MySqlCommand("", conn);

                    sql = "UPDATE user_info SET uid='" + dlgUpdate.tb_userID.Text;
                    sql += "', upw='" + dlgUpdate.tb_PwChange.Text + "', uname='" + dlgUpdate.tb_Uname.Text;
                    sql += "', ubirth='" + dlgUpdate.combo_birth1.Text + "." + dlgUpdate.combo_birth2.Text + "." + dlgUpdate.combo_birth3.Text;
                    sql += "', ugender='" + dlgUpdate.combo_Gender.Text + "', uadress='" + dlgUpdate.tb_Adress.Text;
                    sql += "', uphone1='" + dlgUpdate.tb_Phone1.Text + "', uphone2='" + dlgUpdate.tb_Phone2.Text + "', uphone3='" + dlgUpdate.tb_Phone3.Text;
                    sql += "' WHERE uid='" + tb_userID.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    tb_userID.Text = "";
                    MessageBox.Show("회원정보수정이 완료되었습니다.");

                    conn.Close();
                }
                else
                    tb_userID.Text = "";
            }
            else
                MessageBox.Show("아이디를 확인해주세요.");
        }

        public static string deleteID;
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool state = false;
            deleteID = tb_userID.Text;

            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            string sql = "SELECT uid FROM user_info";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string uid = reader["uid"].ToString();
                if (uid == tb_userID.Text)
                    state = true;
            }
            if (state == true)
            {
                deleteID = tb_userID.Text;
                SelectDeleteForm dlgDelete = new SelectDeleteForm(this);
                dlgDelete.ShowDialog();

                if (dlgDelete.DialogResult == DialogResult.OK)
                {
                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    cmd = new MySqlCommand("", conn);

                    sql = "DELETE FROM user_image WHERE fid='" + tb_userID.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    sql = "DELETE FROM user_info WHERE uid='" + tb_userID.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    tb_userID.Text = "";
                    MessageBox.Show("회원삭제가 완료되었습니다.");

                    conn.Close();
                }
                else
                    tb_userID.Text = "";
            }
            else
                MessageBox.Show("아이디를 확인해주세요.");
        }
        // 리스트 뷰 더블클릭 이벤트
        private void list_UserInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list_UserInfo.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = list_UserInfo.SelectedItems;
                ListViewItem lvitem = items[0];
                tb_userID.Text = lvitem.SubItems[0].Text;
            }
        }
        // 텍스트 박스 클릭 이벤트
        private void tb_userID_Click(object sender, EventArgs e)
        {
            tb_userID.Text = "";
            tb_userID.Font = new Font("맑은 고딕", 15, FontStyle.Bold);
            tb_userID.ForeColor = Color.Black;
        }
    }
}
