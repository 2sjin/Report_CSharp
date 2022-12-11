using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsWithThreads {
    public partial class Form1 : Form {
        private Graphics g1, g2, g3, g4;        // 그래픽 선언
        private ThreadStart ts1, ts2, ts3, ts4;             // 델리게이트 선언
        private Thread thread1, thread2, thread3, thread4;  // 스레드 선언        
        private Rectangle rec1, rec2;

        public Form1() {
            InitializeComponent();
        }

        // ==========================================================================================
        // 1. 스레드 몸체 메소드 정의
        // ==========================================================================================
        private void ThreadBody1() {
            g1 = panel1.CreateGraphics();         // 그래픽 객체 생성
            rec1 = new Rectangle(100, 5, 70, 70);    // 사각형 생성(x, y, 가로길이, 세로길이)
            while (true) {
                Thread.Sleep(1000);         // 1초 대기
                g1.DrawRectangle(Pens.Lime, rec1);    // 라임색으로 사각형 그리기
                g1.RotateTransform(1);                // 사각형을 1도만큼 회전
            }
        }

        private void ThreadBody2() {
            g2 = panel2.CreateGraphics();
            rec2 = new Rectangle(30, 30, 70, 70);

            int red = 255, green=0, blue=0;
            while (true) {
                Thread.Sleep(10);
                if (red == 255 && green < 255 && blue == 0)
                    green += 5;
                else if (red > 0 && green == 255 && blue == 0)
                    red -= 5;
                else if (red == 0 && green == 255 && blue < 255)
                    blue += 5;
                else if (red == 0 && green > 0 && blue == 255)
                    green -= 5;
                else if (red < 255 && green == 0 && blue == 255)
                    red += 5;
                else if (red == 255 && green == 0 && blue > 0)
                    blue -= 5;

                SolidBrush brush = new SolidBrush(Color.FromArgb(red, green, blue));
                g2.FillEllipse(brush, 35, 30, 100, 100);
            }
        }

        private void ThreadBody3() {
            g3 = panel3.CreateGraphics();
            int red = 255, green = 0, blue = 0;

            while (true) {
                Thread.Sleep(100);
                if (red == 255 && green < 255 && blue == 0)
                    green += 5;
                else if (red > 0 && green == 255 && blue == 0)
                    red -= 5;
                else if (red == 0 && green == 255 && blue < 255)
                    blue += 5;
                else if (red == 0 && green > 0 && blue == 255)
                    green -= 5;
                else if (red < 255 && green == 0 && blue == 255)
                    red += 5;
                else if (red == 255 && green == 0 && blue > 0)
                    blue -= 5;

                SolidBrush brush = new SolidBrush(Color.FromArgb(red, green, blue));
                g3.FillRectangle(brush, 0, 0, 200, 200);
            }
        }

        private void ThreadBody4() {
            g4 = panel4.CreateGraphics();
            while(true) {
                Brush brush = new SolidBrush(Color.Green);
                Thread.Sleep(1000);
                g4.FillRectangle(brush, 0, 0, 200, 200);
                Thread.Sleep(1000);
                g4.Clear(Color.Black);
            }
        }
        // ==========================================================================================

        private void 사각형ToolStripMenuItem_Click(object sender, EventArgs e) {
            ts1 = new ThreadStart(ThreadBody1);       // 2. 작성된 메소드를 델리게이트에 연결
            thread1 = new Thread(ts1);                // 3. 델리게이트를 이용하여 스레드 객체 생성
            thread1.Start();                          // 4. 스레드 시작
        }

        private void 원ToolStripMenuItem_Click(object sender, EventArgs e) {
            ts2 = new ThreadStart(ThreadBody2);       // 2. 작성된 메소드를 델리게이트에 연결
            thread2 = new Thread(ts2);                // 3. 델리게이트를 이용하여 스레드 객체 생성
            thread2.Start();                          // 4. 스레드 시작
        }

        private void 채우기ToolStripMenuItem_Click(object sender, EventArgs e) {
            ts3 = new ThreadStart(ThreadBody3);       // 2. 작성된 메소드를 델리게이트에 연결
            thread3 = new Thread(ts3);                // 3. 델리게이트를 이용하여 스레드 객체 생성
            thread3.Start();                          // 4. 스레드 시작
        }

        private void 반짝반짝ToolStripMenuItem_Click(object sender, EventArgs e) {
            ts4 = new ThreadStart(ThreadBody4);       // 2. 작성된 메소드를 델리게이트에 연결
            thread4 = new Thread(ts4);                // 3. 델리게이트를 이용하여 스레드 객체 생성
            thread4.Start();                          // 4. 스레드 시작
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Form이 종료되면 실행중인 스레드 종료
        protected override void OnClosing(CancelEventArgs e) {
            if (thread1 != null) thread1.Abort();
            if (thread2 != null) thread2.Abort();
            if (thread3 != null) thread3.Abort();
            if (thread4 != null) thread4.Abort();
            base.OnClosing(e);
        }
    }
}
