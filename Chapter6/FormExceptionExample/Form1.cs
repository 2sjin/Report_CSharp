using System;
using System.Windows.Forms;

namespace FormExceptionExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                // 입력한 점수 저장
                int kor = int.Parse(textBox1.Text);
                int eng = int.Parse(textBox2.Text);
                int math = int.Parse(textBox3.Text);

                if (kor < 0 || kor > 100)
                    throw new ScoreOutOfRangeException("국어");
                if (eng < 0 || eng > 100 )
                    throw new ScoreOutOfRangeException("영어");
                if (math < 0 || math > 100)
                    throw new ScoreOutOfRangeException("수학");

                // Student 객체 생성
                Student std = new Student(kor, eng, math);

                // 평점 및 평균 출력
                textBox4.Text = std.GetGrade();
                textBox5.Text = std.GetAvg().ToString("##.##");
            } catch (Exception err) {
                MessageBox.Show(err.Message, "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }

    class ScoreOutOfRangeException : ApplicationException {
        public ScoreOutOfRangeException(string s) : base(s + " 점수는 0~100 사이의 값을 입력해야 합니다.") { }
    }
}
