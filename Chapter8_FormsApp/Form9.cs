using System;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
    public partial class Form9 : Form {
        public Form9() {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            string strTemp = "";
            foreach (Object obj in checkedListBox1.CheckedItems)
                strTemp += obj.ToString() + "\n";
                MessageBox.Show("당신이 사용할 수 있는 프로그래밍 언어입니다.\n\n" + strTemp);
        }
    }
}
