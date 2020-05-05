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
    public partial class CheckForm : MetroForm
    {
        public CheckForm()
        {
            InitializeComponent();
        }
        private GotoWork gotoWorkForm = null;
        public CheckForm(GotoWork form)
        {
            InitializeComponent();
            this.gotoWorkForm = form;
        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
