using System;

namespace ex4_21 {
    // 델리게이트 선언
    delegate void MultiCastDelegate(); 

    class Schedule {
        // 메소드 정의
        public void Now() {
            Console.WriteLine("Time : " + DateTime.Now.ToString());
        }

        // 메소드 정의
        public static void Today() {
            Console.WriteLine("Date : " + DateTime.Today.ToString());
        }
    }

    class MultiCastApp {
        static void Main(string[] args) {
            // 객체 생성
            Schedule obj = new Schedule();

            // 델리게이트 생성
            MultiCastDelegate mcd = new MultiCastDelegate(obj.Now);

            // 멀티캐스트
            mcd += new MultiCastDelegate(Schedule.Today);

            // 델리게이트 호출
            mcd();
        }
    }
}
