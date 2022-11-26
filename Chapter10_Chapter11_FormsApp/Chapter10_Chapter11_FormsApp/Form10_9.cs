using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter10_Chapter11_FormsApp {
    public partial class Form10_9 : Form {
        public int xPt, yPt;
        public static readonly int MOVE = 20;

        public Form10_9() {
            InitializeComponent();
        }

        private void button1_KeyUp(object sender, KeyEventArgs e) {
            this.xPt = this.button1.Location.X;
            this.yPt = this.button1.Location.Y;
            switch (e.KeyCode) {
                case Keys.Left:
                    xPt -= MOVE;
                    this.button1.Text = "◀";
                    break;
                case Keys.Right:
                    xPt += MOVE;
                    this.button1.Text = "▶";
                    break;
                case Keys.Up:
                    yPt -= MOVE;
                    this.button1.Text = "▲";
                    break;
                case Keys.Down:
                    yPt += MOVE;
                    this.button1.Text = "▼";
                    break;
            }
            this.label1.Text = e.KeyCode.ToString();
            this.button1.Location = new Point(xPt, yPt);
        }
    }
}
