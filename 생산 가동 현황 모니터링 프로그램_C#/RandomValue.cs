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
    public partial class RandomValue : MetroForm
    {
        string strConn = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=sscompany;CHARSET=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        //MySqlDataReader reader;
        Random rndVal = new Random();
        Timer delay = new Timer();

        public RandomValue()
        {
            InitializeComponent();
        }
        private MainForm mainForm = null;
        public RandomValue(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }
        private void RandomValue_Load(object sender, EventArgs e)
        {
            // 폼 위치 중앙
            this.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2
            );
        }

        private void btn_randomValue_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
            cmd = new MySqlCommand("", conn);

            int rndStr = rndVal.Next(1, 3);
            string eqState1 = "";
            if (rndStr == 1)
                eqState1 = "가동";
            else
                eqState1 = "비가동";

            rndStr = rndVal.Next(1, 3);
            string eqState2 = "";
            if (rndStr == 1)
                eqState2 = "가동";
            else
                eqState2 = "비가동";

            rndStr = rndVal.Next(1, 3);
            string eqState3 = "";
            if (rndStr == 1)
                eqState3 = "가동";
            else
                eqState3 = "비가동";

            rndStr = rndVal.Next(1, 3);
            string eqState4 = "";
            if (rndStr == 1)
                eqState4 = "가동";
            else
                eqState4 = "비가동";

            rndStr = rndVal.Next(1, 3);
            string eqState5 = "";
            if (rndStr == 1)
                eqState5 = "가동";
            else
                eqState5 = "비가동";

            rndStr = rndVal.Next(1, 3);
            string eqState6 = "";
            if (rndStr == 1)
                eqState6 = "가동";
            else
                eqState6 = "비가동";


            string sql = "UPDATE pro_info SET 설비상태='" + eqState1 + "', ";
            sql += "품목번호='SS-" + rndVal.Next(10000000, 99999999);
            sql += "', 작업시간='" + rndVal.Next(0, 23) + "시간" + rndVal.Next(0, 59) + "분";
            sql += "', 목표량=" + 10000 + ", 생산수량=" + rndVal.Next(0, 20000) + ", 불량수량=" + rndVal.Next(0, 10) + " ";
            sql += " WHERE 설비번호='A1'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            sql = "UPDATE pro_info SET 설비상태='" + eqState2 + "', ";
            sql += "품목번호='SS-" + rndVal.Next(10000000, 99999999);
            sql += "', 작업시간='" + rndVal.Next(0, 23) + "시간" + rndVal.Next(0, 59) + "분";
            sql += "', 목표량=" + 20000 + ", 생산수량=" + rndVal.Next(0, 30000) + ", 불량수량=" + rndVal.Next(0, 10) + " ";
            sql += " WHERE 설비번호='B1'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            sql = "UPDATE pro_info SET 설비상태='" + eqState3 + "', ";
            sql += "품목번호='SS-" + rndVal.Next(10000000, 99999999);
            sql += "', 작업시간='" + rndVal.Next(0, 23) + "시간" + rndVal.Next(0, 59) + "분";
            sql += "', 목표량=" + 15000 + ", 생산수량=" + rndVal.Next(0, 25000) + ", 불량수량=" + rndVal.Next(0, 10) + " ";
            sql += " WHERE 설비번호='B2'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            sql = "UPDATE pro_info SET 설비상태='" + eqState4 + "', ";
            sql += "품목번호='SS-" + rndVal.Next(10000000, 99999999);
            sql += "', 작업시간='" + rndVal.Next(0, 23) + "시간" + rndVal.Next(0, 59) + "분";
            sql += "', 목표량=" + 19000 + ", 생산수량=" + rndVal.Next(0, 29000) + ", 불량수량=" + rndVal.Next(0, 10) + " ";
            sql += " WHERE 설비번호='C1'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            sql = "UPDATE pro_info SET 설비상태='" + eqState5 + "', ";
            sql += "품목번호='SS-" + rndVal.Next(10000000, 99999999);
            sql += "', 작업시간='" + rndVal.Next(0, 23) + "시간" + rndVal.Next(0, 59) + "분";
            sql += "', 목표량=" + 13000 + ", 생산수량=" + rndVal.Next(0, 23000) + ", 불량수량=" + rndVal.Next(0, 10) + " ";
            sql += " WHERE 설비번호='C2'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            sql = "UPDATE pro_info SET 설비상태='" + eqState6 + "', ";
            sql += "품목번호='SS-" + rndVal.Next(10000000, 99999999);
            sql += "', 작업시간='" + rndVal.Next(0, 23) + "시간" + rndVal.Next(0, 59) + "분";
            sql += "', 목표량=" + 17000 + ", 생산수량=" + rndVal.Next(0, 27000) + ", 불량수량=" + rndVal.Next(0, 10) + " ";
            sql += " WHERE 설비번호='C3'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        private void btn_randomAuto_Click(object sender, EventArgs e)
        {
            delay.Interval = 5000;
            delay.Tick += btn_randomValue_Click;
            delay.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delay.Stop();
        }

        private void RandomValue_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            try
            {
                delay.Stop();
            }
            catch { }
        }
    }
}
