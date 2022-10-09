using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_9_9 {
    internal class Program {
        static void PrintStars(int i) {
            for (int j = 4 - i; j >= 0; j--)
                Console.Write(" ");
            for (int j = 1; j <= 2 * i - 1; j++)
                Console.Write("*");
            Console.WriteLine();
        }

        static void Main(string[] args) {

            // (1)
            for (int i = 1; i <= 5; i++)
                PrintStars(i);
            for (int i = 4; i >= 1; i--)
                PrintStars(i);
            Console.WriteLine();

            // (2)
            for (int i = 1; i <= 9; i++) {
                for (int j = 9 - i; j >= 1; j--)
                    Console.Write(" ");
                for (int j = i; j > 1; j--)
                    Console.Write(j);
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
            Console.WriteLine();

            // (3)
            for (int i = 1; i <= 9; i++) {
                for (int j = 0; j < i-1; j++)
                    Console.Write(" ");
                for (int j = i; j < i + 10; j++) {
                    if (j % 10 == 0) continue;
                    Console.Write(j % 10);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
