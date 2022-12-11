using System;
using System.Threading;

namespace ex6_25 {
    class ThreadProperty {
        // 1. 스레드 몸체 메소드 정의
        public void ThreadBody() {
            Thread myself = Thread.CurrentThread;   // 현재 실행중인 스레드 반환

            Monitor.Enter(this);    // 현재 실행중인 스레드가 아래 문장을 선점함
            for (int i = 1; i <= 5; i++) {
                Console.WriteLine("{0} is activated => {1}", myself.Name, i);
                Thread.Sleep(1000);
            }
            Monitor.Exit(this);     // 위 문장을 다른 스레드가 선점할 수 있도록, 현재 스레드의 선점 해지함
        }
    }

    internal class MonitorApp {
        static void Main(string[] args) {
            ThreadProperty obj = new ThreadProperty();

            // 2. 작성된 메소드를 델리게이트에 연결
            ThreadStart ts = new ThreadStart(obj.ThreadBody);

            // 3. 델리게이트를 이용하여 스레드 객체 생성
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);

            // 스레드 이름 지정
            t1.Name = "Apple";
            t2.Name = "Orange";

            // 4. 스레드 시작
            t1.Start();
            t2.Start();
        }
    }
}
