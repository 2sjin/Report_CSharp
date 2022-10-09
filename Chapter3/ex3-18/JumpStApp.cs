using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_18 {
    internal class JumpStApp {
        static void Main(string[] args) {
            int n, s, i;

            Console.WriteLine("1부터 n까지의 누적합 출력, 0 입력 시 종료\n");

            for (; ; ) {    // 무한 루프
                Console.Write("Enter a number : ");
                n = Int32.Parse(Console.ReadLine());
                if (n == 0) break;
                else if (n < 0) continue;
                for (s = 0, i = 1; i <= n; ++i)
                    s = sum(s, i);
                Console.WriteLine("n = {0}, sum = {1}", n, s);
            }
            Console.WriteLine("End of Main");
        }

        static int sum(int s, int i) {
            return s + i;
        }
    }
}
