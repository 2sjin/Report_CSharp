using System;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void 예제87ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form7 frm7 = new Form7();
            // frm7.Show();
            frm7.ShowDialog();
        }

        private void 예제89ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form9 frm9 = new Form9();
            frm9.ShowDialog();
        }

        private void 학생관리프로그램ToolStripMenuItem_Click(object sender, EventArgs e) {
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
        }
    }
}
