using System;

// 구구단 출력

namespace ch3_9_8 {
    internal class Program {
        static void Main(string[] args) {
            for (int line = 0; line <= 4; line+=4) { 
                for (int i = 1; i <= 9; i++) {
                    for (int dan = line + 2; dan <= line + 5; dan++) {
                        Console.Write("{0} * {1} = {2}", dan, i, dan * i);  // 구구단 출력
                        if (dan != 9 || i != 9)     // 마지막 9 * 9 가 아닐 경우
                            Console.Write(",");     // 쉼표 추가
                        Console.Write("\t");        // 탭 하나 띄우기
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
