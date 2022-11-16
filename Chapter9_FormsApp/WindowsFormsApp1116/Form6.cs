using System;
using System.Windows.Forms;

namespace WindowsFormsApp1116 {
    public partial class Form6 : Form {
        public Form6() {
            InitializeComponent();
        }

        private void Form6_Click(object sender, EventArgs e) {
            MessageBox.Show("Form6 was clicked.", "Title Bar",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult rs = MessageBox.Show("Form6을 종료합니다. 데이터를 저장하시겠습니까?", "Title Bar",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button3);

            if (rs == DialogResult.Yes)
                MessageBox.Show("데이터 저장 중 오류가 발생하였습니다.", "Title Bar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            if (rs == DialogResult.No)
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            while (true) {
                DialogResult rs = MessageBox.Show("데이터를 불러올 수 없습니다.", "Title Bar",
                        MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button2);

                if (rs == DialogResult.Abort) {
                    MessageBox.Show("데이터 로드를 중단합니다.", "Title Bar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;
                }
                else if (rs == DialogResult.Retry) {
                    continue;
                }
                else {
                    break;
                }
            }         
        }
    }
}
