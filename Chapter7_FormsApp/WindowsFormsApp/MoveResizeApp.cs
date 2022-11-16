using System;
using System.Windows.Forms;

namespace WindowsFormsApp {
    public partial class MoveResizeApp : Form {
        public MoveResizeApp() {
            InitializeComponent();
        }

        public void SetButtonText() {
            button1.Text = "Location = " + Location + "\n" +
            "Left/Right/Width = " + Left + ", " + Right + ", " + Width + "\n" +
            "Top/Bottom/Height = " + Top + ", " + Bottom + ", " + Height;
        }

        private void MoveResizeApp_Load(object sender, EventArgs e) {
            SetButtonText();
        }

        private void MoveResizeApp_Move(object sender, EventArgs e) {
            SetButtonText();
        }

        private void MoveResizeApp_Resize(object sender, EventArgs e) {
            SetButtonText();
        }
    }
}
