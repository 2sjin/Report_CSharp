using System;
using System.Threading;

namespace ex6_24 {
    class ThreadProperty {
        // 1. 스레드 몸체 메소드 정의
        public void ThreadBody() {
            Thread myself = Thread.CurrentThread;   // 현재 실행중인 스레드 반환

            // lock 블록 내의 코드는 하나의 스레드가 수행을 완료해야만 다른 스레드가 접근 가능함
            // lock 블록을 없애면, 여러 스레드가 동시에 코드에 접근할 수 있음
            lock (this) {
                for (int i = 1; i <= 5; i++) {
                    Console.WriteLine("{0} is activated => {1}", myself.Name, i);
                    Thread.Sleep(1000);
                }
            }
        }
    }

    internal class LockStApp {
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
