using System;
using System.Threading;

namespace ex6_23 {
    internal class SchedulerApp {
        static int interval;

        // 1. 스레드 몸체 메소드 정의
        static void ThreadBody() {
            Thread myself = Thread.CurrentThread;   // 현재 실행중인 스레드 반환
            Console.WriteLine("Starting Thread : " + myself.Name);
            for (int i = 1; i <= 3 * interval; i++) {
                if (i % interval == 0)
                    Console.WriteLine(myself.Name + " : " + i);
            }
            Console.WriteLine("Ending Thread : " + myself.Name);
        }

        static void Main(string[] args) {
            // 가중치 값을 사용자로부터 입력받음
            Console.Write("Interval value : ");
            interval = int.Parse(Console.ReadLine());

            Thread.CurrentThread.Name = "Main Thread";  // 메인 스레드 이름 설정

            // 2. 작성된 메소드를 델리게이트에 연결
            ThreadStart ts = new ThreadStart(ThreadBody);

            // 3. 델리게이트를 이용하여 스레드 객체 생성
            Thread worker = new Thread(ts);

            worker.Priority = ThreadPriority.Highest;   // worker 스레드의 우선순위를 가장 높게 솔정
            worker.Name = "Worker Thread";              // worker 스레드 이름 설정

            // 4. 스레드 시작
            worker.Start();
            ThreadBody();
        }
    }
}
