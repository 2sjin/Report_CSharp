using System;
using System.Windows.Forms;

namespace FormExceptionExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // 입력한 점수 저장
            int kor = int.Parse(textBox1.Text);
            int eng = int.Parse(textBox2.Text);
            int math = int.Parse(textBox3.Text);

            // Student 객체 생성
            Student std = new Student(kor, eng, math);

            // 평점 및 평균 출력
            textBox4.Text = std.GetGrade();
            textBox5.Text = std.GetAvg().ToString("##.##");
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
