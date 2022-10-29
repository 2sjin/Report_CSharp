using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_8 {
    internal class DoubleVsDecimalApp {
        static void Main(string[] args) {
            double d = 0d;  // 부동 소수점 형
            decimal m = 0m; // 10진 자료형

            for (int i = 0; i < 1000; i++) {
                d += 0.10d;
                m += 0.10m;
            }
            Console.WriteLine("0.1d * 1000 = " + d);
            Console.WriteLine("0.1m * 1000 = " + m);
        }
    }
}
