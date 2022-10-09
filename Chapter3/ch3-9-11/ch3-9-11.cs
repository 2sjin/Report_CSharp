using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 행렬의 행과 열을 바꾸는 transpose 메소드 작성

namespace ch3_9_11 {
    internal class Program {
        public static void transpose(int[,] ary1, int[,] ary2) {
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 3; j++)
                    ary2[j, i] = ary1[i, j];
            }
        }

        public static void Main(string[] args) {
            int[,] ary1 = new int[2, 3];
            int[,] ary2 = new int[3, 2];

            Console.WriteLine("===== 2 by 3 Matrix =====");
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 3; j++) {
                    ary1[i, j] = (j + 1) + (4 * i) - (1 * i);
                    Console.Write(ary1[i, j] + " ");
                }
                Console.WriteLine();
            }

            transpose(ary1, ary2);

            Console.WriteLine("===== 3 by 2 Matrix =====");
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 2; j++)
                    Console.Write(ary2[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
