using System;

namespace ex6_15 {
    internal class FinallyClauseApp {
        static int count = 0;
        static void Main(string[] args) {
            while (true) {
                try {
                    if (++count == 1) throw new Exception();
                    if (count == 3) break;
                    Console.WriteLine(count + ") 예외가 발생하지 않음");
                } catch (Exception e) {
                    Console.WriteLine(count + ") " + e.Message);
                } finally {
                    Console.WriteLine(count + ") finally 절 내부 코드 실행됨");
                }
            }
            Console.WriteLine("메인 프로그램 끝부분");
        }
    }
}
