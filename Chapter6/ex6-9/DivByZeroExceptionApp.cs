using System;

namespace ex6_9 {
    internal class DivByZeroExceptionApp {
        static void Main(string[] args) {
            int result;

            Console.WriteLine("정수 나눗셈 (a / b)");
            Console.Write("정수 a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("정수 b : ");
            int b = int.Parse(Console.ReadLine());

            try {
                result = a / b;
            } catch (DivideByZeroException e) {
                Console.WriteLine("[예외 발생] " + e.Message);
                return;
            } finally {
                Console.WriteLine("나눗셈 연산 종료");
            }
            Console.WriteLine("a / b = " + result);
        }
    }
}
