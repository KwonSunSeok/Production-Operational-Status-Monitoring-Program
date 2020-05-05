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
    public partial class DeleteForm : MetroForm
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        private MainForm mainForm = null;
        public DeleteForm(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }
        private void DeleteForm_Load(object sender, EventArgs e)
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

            pb_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            tb_userID.Text = LoginForm.uid;
        }
        // 그룹박스 테두리 및 배경 색 변경 함수
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (tb_Pw.Text == LoginForm.upw && tb_Birth.Text == LoginForm.ubirth)
            {
                DeleteCheckForm dlgDeleteCheck = new DeleteCheckForm(this);
                dlgDeleteCheck.ShowDialog();

                if (dlgDeleteCheck.DialogResult == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else if (tb_Pw.Text != LoginForm.upw)
                MessageBox.Show("비밀번호가 틀렸습니다.");
            else if (tb_Birth.Text != LoginForm.ubirth)
                MessageBox.Show("생년월일이 틀렸습니다.");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
