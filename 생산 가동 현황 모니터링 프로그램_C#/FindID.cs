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

namespace 생산_가동_현황_모니터링_프로그램
{
    public partial class FindID : MetroForm
    {
        public FindID()
        {
            InitializeComponent();
        }
        private LoginForm loginForm = null;
        public FindID(LoginForm form)
        {
            InitializeComponent();
            this.loginForm = form;
        }
        private void FindID_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
                   Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2,
                   Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2
               );
            gb_FindID.Location = new Point(
                this.Size.Width / 2 - gb_FindID.Size.Width / 2,
                this.Size.Height / 2 - gb_FindID.Size.Height / 2
            );
            // 그룹박스 테두리 및 배경 색 변경
            gb_FindID.Paint += PaintBorderlessGroupBox;
        }
        // 그룹박스 테두리 및 배경 색 변경 함수
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        int confirmNum;
        bool state_rnd = false;
        bool state_confirm = false;
        Random rnd = new Random();

        private void btn_rnd_Click(object sender, EventArgs e)
        {
            if (tb_Phone1.Text != "" && tb_Phone2.Text != "" && tb_Phone3.Text != "")
            {
                confirmNum = rnd.Next(1, 99);
                MessageBox.Show(confirmNum.ToString());
                state_rnd = true;
            }
            else
                MessageBox.Show("휴대폰 번호를 입력해주세요.");
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            // 입력한 인증번호가 맞는 경우
            if (tb_Confirm.Text == confirmNum.ToString())
            {
                MessageBox.Show("인증이 완료 되었습니다.");
                state_confirm = true;
            }
            else if (state_rnd == false)
                MessageBox.Show("인증번호 발송 버튼을 눌러주세요.");
            else
                MessageBox.Show("인증번호를 확인해주세요.");
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (tb_Confirm.Text != "" && tb_Phone1.Text != "" && tb_Phone2.Text != ""
                && tb_Phone3.Text != "" && tb_Uname.Text != "" && state_confirm == true)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("다시 확인해주세요.");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tb_Phone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지 Key 입력불가
            {
                e.Handled = true;
            }
        }
    }
}
