using System;
using System.Threading;

namespace ex6_20 {

    class ThreadState {
        // 1. 스레드 몸체 메소드 정의
        public void ThreadBody() {
            while (true) { }
        }
    }

    class ThreadStateApp {
        static void Main(string[] args) {
            ThreadState obj = new ThreadState();

            // 2. 작성된 메소드를 델리게이트에 연결
            ThreadStart ts = new ThreadStart(obj.ThreadBody);

            // 3. 델리게이트를 이용하여 스레드 객체 생성
            Thread t = new Thread(ts);

            Console.WriteLine("Step 1: " + t.ThreadState);

            // 4. 스레드 상태: 시작
            t.Start();
            Thread.Sleep(100);

            Console.WriteLine("Step 2: " + t.ThreadState);

            // 스레드 상태: 대기
            t.Suspend();
            Thread.Sleep(100);

            Console.WriteLine("Step 3: " + t.ThreadState);

            // 스레드 상태: 대기 -> 실행
            t.Resume();
            Thread.Sleep(100);

            Console.WriteLine("Step 4: " + t.ThreadState);

            // 스레드 상태: 종료
            t.Abort();
            Thread.Sleep(100);

            Console.WriteLine("Step 5: " + t.ThreadState);
        }
    }
}
