using System;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
    public partial class FormManager : Form {
        public FormManager(string id) {
            InitializeComponent();
            labelUserID.Text = id;
        }
        
        private void button1_Click(object sender, EventArgs e) {
            // 입력한 점수 저장
            int kor = int.Parse(txtKor.Text);
            int eng = int.Parse(txtEng.Text);
            int math = int.Parse(txtMath.Text);

            // Student 객체 생성
            Student std = new Student(labelUserID.Text, kor, eng, math);

            // 평점 및 평균 출력
            txtGrade.Text = std.GetGrade();
            txtAvg.Text = std.GetAvg().ToString("##.##");
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
