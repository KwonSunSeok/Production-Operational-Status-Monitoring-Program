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
    public partial class GotoWork : MetroForm
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public GotoWork()
        {
            InitializeComponent();
        }
        private CommutingTime commuteForm = null;
        public GotoWork(CommutingTime form)
        {
            InitializeComponent();
            this.commuteForm = form;
        }

        private void GotoWork_Load(object sender, EventArgs e)
        {
            string[] aryWorkLine = { "A1", "B1", "B2", "C1", "C2", "C3" };
            combo_workLine.Items.AddRange(aryWorkLine);
            string[] aryYesNo = { "Yes", "No" };
            combo_yesNo.Items.AddRange(aryYesNo);
        }
        public static string strWorkLine, strYesNo;
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if ((combo_workLine.Text == "A1" && CommutingTime.stateA1 == true) ||
                (combo_workLine.Text == "B1" && CommutingTime.stateB1 == true) ||
                (combo_workLine.Text == "B2" && CommutingTime.stateB2 == true) ||
                (combo_workLine.Text == "C1" && CommutingTime.stateC1 == true) ||
                (combo_workLine.Text == "C2" && CommutingTime.stateC2 == true) ||
                (combo_workLine.Text == "C3" && CommutingTime.stateC3 == true))
            {
                CheckForm dlgCheck = new CheckForm(this);
                dlgCheck.ShowDialog();

                if (dlgCheck.DialogResult == DialogResult.OK)
                {
                    conn = new MySqlConnection(strConn);
                    conn.Open();
                    cmd = new MySqlCommand("", conn);

                    string sql = "SELECT * FROM commuting_time WHERE 작업라인='" + combo_workLine.Text;
                    sql += "'AND 책임유무='Yes'";
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();

                    // 책임자의 아이디를 읽어옴
                    string preID = "";
                    while (reader.Read())
                    {
                        preID = reader["아이디"].ToString();
                    }
                    reader.Close();

                    sql = "UPDATE commuting_time SET 책임유무='No' WHERE 아이디='" + preID + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    this.DialogResult = DialogResult.OK;
                    strWorkLine = combo_workLine.Text;
                    strYesNo = "Yes";
                    conn.Close();
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                strWorkLine = combo_workLine.Text;
                strYesNo = combo_yesNo.Text;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
