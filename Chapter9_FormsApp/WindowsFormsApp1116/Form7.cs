using System;
using System.IO;
using System.Windows.Forms;

// 예제 9-7 응용 : 파일 대신 폴더를 찾는 다이얼로그를 띄워 폴더의 디렉토리를 리턴받음

namespace WindowsFormsApp1116 {
    public partial class Form7 : Form {
        public Form7() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();

            // 폴더가 성공적으로 선택되었을 경우, 폴더의 절대 경로를 텍스트박스에 출력
            // 해당 if문이 없으면, 폴더 선택을 취소하였을 때 텍스트박스가 초기화됨
            if (result.ToString() == "OK")  
                textBox1.Text = folderBrowser.SelectedPath;

            // 폴더를 선택하지 않고 취소한 경우, 메시지 출력
            else if (result.ToString() == "Cancel")
                MessageBox.Show("폴더가 선택되지 않았습니다.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
