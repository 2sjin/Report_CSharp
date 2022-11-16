using System;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
    public partial class FormLogin : Form {
        Account user;

        public FormLogin() {
            InitializeComponent();
            user = new Account("test", "1234");
        }

        public void Login() {
            // 아이디 또는 비밀번호 공백
            if (textID.Text.Trim().Equals("")) {
                MessageBox.Show("아이디를 입력하세요.", "로그인");
                this.textID.Focus();
            }

            // 비밀번호 공백
            else if (textPW.Text.Trim().Equals("")) {
                MessageBox.Show("비밀번호를 입력하세요.", "로그인");
                this.textPW.Focus();
            }

            // 아이디 일치
            else if (textID.Text.Equals(user.Id)) {
                // 비밀번호 일치
                if (textPW.Text.Equals(user.Pw)) {
                    toolStripStatusLabel1.Text = "로그인 성공";
                    this.Hide();
                    FormManager frmManager = new FormManager(textID.Text);
                    frmManager.ShowDialog();
                }
                // 비밀번호 불일치
                else {
                    toolStripStatusLabel1.Text = "비밀번호가 틀렸습니다.";
                    this.textPW.Focus();
                }
            }

            // 아이디 불일치
            else {
                toolStripStatusLabel1.Text = "존재하지 않는 아이디입니다.";
                this.textID.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            Login();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textID_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void textPW_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                Login();
        }
    }
}
