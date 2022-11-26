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
    public partial class Form11_8 : Form {
        private int index = 0;

        public Form11_8() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            index %= imageList1.Images.Count;
            label1.Image = imageList1.Images[index++];
        }
    }
}
