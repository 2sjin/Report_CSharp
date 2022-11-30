using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chapter10_Chapter11_FormsApp {
    public partial class Form10_4 : Form {
        public Form10_4() {
            InitializeComponent();
        }

        private void Form10_4_MouseEnter(object sender, EventArgs e) {
            this.BackColor = Color.PowderBlue;
        }

        private void Form10_4_MouseLeave(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "Mouse Left";
            this.BackColor = SystemColors.Control;
        }

        private void Form10_4_MouseMove(object sender, MouseEventArgs e) {
            Point mousePoint = PointToClient(MousePosition);
            string msg = "Mouse Moved" + " (" + mousePoint.X + ", " + mousePoint.Y + ")";
            toolStripStatusLabel1.Text = msg;
        }

        private void Form10_4_MouseClick(object sender, MouseEventArgs e) {
            Point mousePoint = PointToClient(MousePosition);
            string msg = "Mouse Clicked" + " (" + mousePoint.X + ", " + mousePoint.Y + ")";
            MessageBox.Show(msg);
        }
    }
}
