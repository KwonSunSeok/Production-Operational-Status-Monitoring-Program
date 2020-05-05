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
    public partial class SelectDeleteForm : MetroForm
    {
        public SelectDeleteForm()
        {
            InitializeComponent();
        }
        private SelectForm selectForm = null;
        public SelectDeleteForm(SelectForm form)
        {
            InitializeComponent();
            this.selectForm = form;
        }
        private void SelectDeleteForm_Load(object sender, EventArgs e)
        {
            // 폼 위치 중앙
            this.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2
            );
            groupBox1.Location = new Point(
                this.Size.Width / 2 - groupBox1.Size.Width / 2,
                this.Size.Height / 2 - groupBox1.Size.Height / 2
            );
            // 그룹박스 테두리 및 배경 색 변경
            groupBox1.Paint += PaintBorderlessGroupBox;
            tb_DeleteCheck.Text = SelectForm.deleteID + "님을 삭제하시겠습니까?";
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
            if (SelectForm.deleteID == "admin")
            {
                MessageBox.Show("관리자는 삭제할 수 없습니다.");
            }
            else
                this.DialogResult = DialogResult.OK;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
