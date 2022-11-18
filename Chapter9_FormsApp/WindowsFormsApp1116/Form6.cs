using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1116 {
    public partial class Form6 : Form {
        FontDialog fontDialog1;

        public Form6() {
            InitializeComponent();
            fontDialog1 = new FontDialog();
        }
        
        // 경로를 받아서 텍스트박스에 출력하는 메소드
        public void PrintTextFileContent(string path) {
            FileStream file = null;
            StreamReader sr = null;
            string line;
            txtContent.Text = "";

            try {
                // 읽기 전용으로 파일 열기
                file = new FileStream(path, FileMode.Open, FileAccess.Read);

                // 스트림 리더(StreamReader) 생성 후 한 줄씩 파일 읽기
                sr = new StreamReader(file);
                while ((line = sr.ReadLine()) != null)
                    txtContent.Text += (line + "\r\n");
            } catch (FileNotFoundException e) {
                MessageBox.Show(e.Message, "FileNotFoundException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (IOException e) {
                MessageBox.Show(e.Message, "IOException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                // 스트림 리더 및 파일 닫기
                sr.Close();
                file.Close();
            }
        }

        private void btnFileDialog_Click(object sender, EventArgs e) {
            DialogResult rs;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            openFileDialog1.InitialDirectory = @"C:\";  // 초기 디렉토리
            openFileDialog1.Filter = "프레젠테이션 파일(*.ppt)|*.ppt|텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;    // 하나의 파일만 선택 가능
            rs = openFileDialog1.ShowDialog();

            // 파일 대화상자에서 파일을 정상적으로 선택했을 경우
            if (rs.ToString() == "OK") {
                txtPath.Text = openFileDialog1.FileNames[0];    // 텍스트박스에 파일 경로 출력
                PrintTextFileContent(txtPath.Text);             // 텍스트박스에 파일 내용 출력(메소드 호출)
            }
        }

        private void btnColorDialog_Click(object sender, EventArgs e) {
            fontDialog1.ShowApply = false;      // 적용 버튼 보이지 않기
            fontDialog1.ShowColor = false;      // 색 콤보박스 보이지 않기

            if (checkBox1.Checked)              // 체크박스1 체크되면
                fontDialog1.ShowApply = true;   // 적용 버튼 보이기
            if (checkBox2.Checked)              // 체크박스2 체크되면
                fontDialog1.ShowColor = true;   // 색 콤보박스 보이기

            fontDialog1.ShowDialog();           // 색 다이얼로그 띄우기

            txtContent.Font = fontDialog1.Font;
            txtContent.ForeColor = fontDialog1.Color;
        }
    }
}
