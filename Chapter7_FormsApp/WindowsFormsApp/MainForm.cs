using System;
using System.Windows.Forms;

namespace WindowsFormsApp {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void btnEx7_5_Click(object sender, EventArgs e) {
            new PaintEventApp().Show();
        }

        private void btnEx7_6_Click(object sender, EventArgs e) {
            new MoveResizeApp().Show();
        }

        private void btnCh7_6_2_Click(object sender, EventArgs e) {
            new Form2App().Show();
        }

        private void btnCh7_6_3_Click(object sender, EventArgs e) {
            new Form3App().Show();
        }

        private void btnDateTime_Click(object sender, EventArgs e) {
            labelDateTime.Text = DateTime.Now.ToString();
        }
    }
}
