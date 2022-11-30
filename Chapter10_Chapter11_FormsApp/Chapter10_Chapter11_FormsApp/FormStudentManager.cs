using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter10_Chapter11_FormsApp {
    public partial class FormStudentManager : Form {
        ControlStudent ctrl = new ControlStudent();

        public FormStudentManager() {
            InitializeComponent();
        }

        // 텍스트박스 초기화 (입력 성공 시 호출됨)
        private void FormClear() {
            txtId.Clear();      // 텍스트박스 공백 처리
            txtName.Clear();
            txtEmail.Clear();
            txtId.Focus();      // 학번 텍스트박스에 포커싱됨
        }

        // [입력] 버튼을 눌렀을 때
        private void btnInsert_Click(object sender, EventArgs e) {
            // 텍스트박스가 하나라도 공백이면 학생을 추가하지 않음
            bool isBlank = txtId.Text.Trim().Equals("")
                || txtName.Text.Trim().Equals("")
                || txtEmail.Text.Trim().Equals("");
            if (isBlank) {           
                MessageBox.Show("모든 학생정보를 입력해주세요.", "입력");
                return;
            }
            
            string[] sitems = new string[] { txtId.Text, txtName.Text, txtEmail.Text };
            ListViewItem lvi = new ListViewItem(sitems);
            listView1.Items.Add(lvi);
            listView1.EndUpdate();
            FormClear();
        }

        // 리스트뷰에서 항목을 선택했을 때(정확히는 포커싱되지 않은 항목을 선택했을 때)
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count > 0) {
                txtId.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtEmail.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        // [수정] 버튼을 눌렀을 때
        private void btnUpdate_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count > 0) {
                listView1.SelectedItems[0].SubItems[0].Text = txtId.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtName.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtEmail.Text;
            }
        }

        // [삭제] 버튼을 눌렀을 때
        private void btnDelete_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        // [종료] 버튼을 눌렀을 때
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        // [파일에 저장] 버튼을 눌렀을 때
        private void btnSaveToFile_Click(object sender, EventArgs e) {
            ctrl.ClearList();
            foreach (ListViewItem lvi in listView1.Items)
                ctrl.AddStudentToList(lvi.SubItems[0].Text, lvi.SubItems[1].Text, lvi.SubItems[2].Text);
            ctrl.SaveToFile();
        }
    }
}
