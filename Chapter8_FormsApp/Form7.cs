using System;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
    public partial class Form7 : Form {
        public Form7() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (!comboBox1.Text.Trim().Equals(""))   // 공백 체크
                listBox1.Items.Add(comboBox1.Text);
        }

        private void btnDel_Click(object sender, EventArgs e) {
            listBox1.Items.Remove(listBox1.SelectedItem);   // 리스트 상자에서 선택 중인 항목 삭제
        }

        private void btnClr_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (txtSearch.Text != String.Empty) {
                int index = listBox1.FindString(txtSearch.Text);
                if (index != -1)
                    listBox1.SetSelected(index, true);
                else
                    MessageBox.Show("일치하는 데이터가 없습니다.");
            } 
        }
    }
}
