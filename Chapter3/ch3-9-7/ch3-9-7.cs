using System;

namespace ch3_9_7 {
    internal class Program {
        static void Main(string[] args) {
            int result1 = 0;
            int tempMul = 1;

            for (int i = 1; i <= 10; i++) {
                Console.Write("{0}!", i);    // 피연산자 출력

                // 각 항의 팩토리얼 결과 구하기
                tempMul = 1;
                for (int j = 1; j <= i; j++)
                    tempMul *= j;

                result1 += tempMul;         // 각 항의 팩토리얼 결과를 최종 결과에 합산
                if (i < 10)                 // 마지막 항이 아닐 경우
                    Console.Write(" + ");   // 뒤에 덧셈 기호 출력
            }

            Console.WriteLine("\nresult = {0}\n", result1);

            // ========================================================

            double result2 = 1.0;

            Console.Write("1");     // 초기값 1

            for (int i = 2; i <= 10; i++) {
                if (i % 2 == 0) {
                    Console.Write(" - ");     // 분모가 짝수면 음수
                    result2 -= (double)1 / i;
                }
                else {
                    Console.Write(" + ");     // 분모가 홀수면 양수
                    result2 += (double)1 / i;
                }

                Console.Write("(1/{0})", i);
            }
            Console.WriteLine("\nresult = " + result2);
        }
    }
}
