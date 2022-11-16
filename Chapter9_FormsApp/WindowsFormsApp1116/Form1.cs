using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1116 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void 예제96ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }

        private void 예제97ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form7 frm7 = new Form7();
            frm7.ShowDialog();
        }
    }
}
