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
    public partial class DeleteCheckForm : MetroForm
    {
        public DeleteCheckForm()
        {
            InitializeComponent();
        }
        private DeleteForm deleteForm = null;
        public DeleteCheckForm(DeleteForm form)
        {
            InitializeComponent();
            this.deleteForm = form;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void DeleteCheckForm_Load(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(
                this.Size.Width / 2 - groupBox1.Size.Width / 2,
                this.Size.Height / 2 - groupBox1.Size.Height / 2
            );
            groupBox1.Paint += PaintBorderlessGroupBox;
        }
        // 그룹박스 테두리 및 배경 색 변경 함수
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(Color.White);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }
    }
}
