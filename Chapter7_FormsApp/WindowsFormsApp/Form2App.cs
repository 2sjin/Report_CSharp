using System;
using System.Windows.Forms;

namespace WindowsFormsApp {
    public partial class Form2App : Form {
        public Form2App() {
            InitializeComponent();
        }

        private void btnBringToFront_Click(object sender, EventArgs e) {
            button2.BringToFront();
            btnBringToFront.Enabled = false;
            btnSendToBack.Enabled = true;
        }

        private void btnSendToBack_Click(object sender, EventArgs e) {
            button2.SendToBack();
            btnBringToFront.Enabled = true;
            btnSendToBack.Enabled = false;
        }
    }
}
