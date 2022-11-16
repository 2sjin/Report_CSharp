using System;
using System.Windows.Forms;

namespace WindowsFormsApp {
    public partial class Form3App : Form {
        public Form3App() {
            InitializeComponent();
        }

        private void btnEnable_Click(object sender, EventArgs e) {
            btnTest.Enabled = true;
        }

        private void btnDisable_Click(object sender, EventArgs e) {
            btnTest.Enabled = false;
        }

        private void btnShow_Click(object sender, EventArgs e) {
            btnEnable.Enabled = true;
            btnDisable.Enabled = true;
            // btnTest.Show();
            btnTest.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e) {
            btnEnable.Enabled = false;
            btnDisable.Enabled = false;
            // btnTest.Hide();
            btnTest.Hide();
        }
    }
}
