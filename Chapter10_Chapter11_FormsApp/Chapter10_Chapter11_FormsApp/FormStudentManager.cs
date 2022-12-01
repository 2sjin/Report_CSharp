using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter10_Chapter11_FormsApp {
    public partial class FormStudentManager : Form {
        ControlStudent ctrl = new ControlStudent();     // 제어 클래스
        bool isListViewChanged = false;      // 리스트뷰 내용이 변경되었는지 여부 확인

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
            isListViewChanged = true;
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
                isListViewChanged = true;
            }
        }

        // [삭제] 버튼을 눌렀을 때
        private void btnDelete_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count > 0) {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                isListViewChanged = true;
            }
            FormClear();
        }

        // [종료] 버튼을 눌렀을 때
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        // [파일에 저장] 버튼을 눌렀을 때
        private void btnSaveToFile_Click(object sender, EventArgs e) {
            SaveListViewToFile();
        }

        // 현재 리스트뷰의 내용을 파일에 저장함
        private void SaveListViewToFile() {
            bool isSaved;

            ctrl.ClearList();
            foreach (ListViewItem lvi in listView1.Items)
                ctrl.AddStudentToList(lvi.SubItems[0].Text, lvi.SubItems[1].Text, lvi.SubItems[2].Text);
            isSaved = ctrl.SaveToFile();  // 실제로 파일에 데이터를 저장하는 함수가 호출됨
            if (isSaved) {
                MessageBox.Show("학생 목록을 파일에 저장하였습니다.", "파일에 저장");
                isListViewChanged = false;
            }
            else {
                MessageBox.Show("저장에 실패했습니다.", "파일에 저장");
            }
        }

        // Form이 로드될 때(파일로부터 데이터를 불러옴)
        private void FormStudentManager_Load(object sender, EventArgs e) {
            List<string[]> strList = ctrl.LoadFromFile();

            // 파일 열기에 실패한 경우 함수 종료
            if (strList == null) {
                MessageBox.Show("파일을 찾을 수 없습니다.", "파일 열기 실패");
                return;
            }

            foreach(String[] strArray in strList) {
                string[] sitems = new string[] { strArray[0], strArray[1], strArray[2] };
                ListViewItem lvi = new ListViewItem(sitems);
                listView1.Items.Add(lvi);
                listView1.EndUpdate();
                FormClear();
            }
        }

        // Form을 닫기 전에 저장할 지 물어봄
        private void FormStudentManager_FormClosing(object sender, FormClosingEventArgs e) {
            if (isListViewChanged) {
                DialogResult dr = MessageBox.Show("변경 내용을 저장하시겠습니까?", "프로그램 종료",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                if (dr == DialogResult.Yes)
                    SaveListViewToFile();
                else if (dr == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
