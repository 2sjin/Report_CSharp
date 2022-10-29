using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_9 {
    enum Color { Red, Green, Blue };
    enum Number { Zero, One, Two, Three, Four, Five }

    internal class EnumTypeApp {
        static void Main(string[] args) {
            Color c = Color.Red;    // 0 (Red)
            c++;                    // 1 (Green)
            int i = (int)c;
            Console.WriteLine(c + " = " + i);

            Number num = Number.Five;
            num = num - 3;
            int n = (int)num;
            Console.WriteLine(num + " = " + n);
        }
    }
}
