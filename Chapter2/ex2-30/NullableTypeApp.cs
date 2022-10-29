using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_30 {
    internal class NullableTypeApp {
        static void Main(string[] args) {
            // ? 기호 : null이 가능한 실수형
            double? num1 = null;
            double? num2 = 10.0;

            if (num1.HasValue)
                Console.WriteLine("num1 = " + num1);
            else
                Console.WriteLine("num1 does not have value. (null)");

            if (num2.HasValue)
                Console.WriteLine("num2 = " + num2);
            else
                Console.WriteLine("num2 does not have value. (null)");

        }
    }
}
