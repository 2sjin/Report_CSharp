using System;
using System.Windows.Forms;

namespace WindowsFormsApp1116 {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        private void 예제96ToolStripMenuItem_Click(object sender, EventArgs e) {
            FormEx6 frmEx6 = new FormEx6();
            frmEx6.ShowDialog();
        }

        private void 예제97ToolStripMenuItem_Click(object sender, EventArgs e) {
            FormEx7 frmEx7 = new FormEx7();
            frmEx7.ShowDialog();
        }

        private void 연습문제9645ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form frm6 = new Form6();
            frm6.ShowDialog();
        }
    }
}
