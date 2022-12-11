using System;
using System.Threading;

namespace ex6_18 {
    internal class SimpleThreadApp {
        // 1. 스레드 몸체 메소드 정의
        static void ThreadBody() {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(DateTime.Now.Second + " : " + i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args) {
            // 2. 작성된 메소드를 델리게이트에 연결
            ThreadStart ts = new ThreadStart(ThreadBody);

            // 3. 델리게이트를 이용하여 스레드 객체 생성
            Thread t = new Thread(ts);

            // 4. 스레드 시작
            Console.WriteLine("*** Start of Main");
            t.Start();
            Console.WriteLine("*** End of Main");
        }
    }
}
