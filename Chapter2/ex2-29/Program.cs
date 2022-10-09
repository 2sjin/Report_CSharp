using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_29 {
    internal class Program {
        static void Main(string[] args) {
            double foo = 526.34;
            object bar = foo;       // 박싱(값형 -> 참조형)
            Console.WriteLine("Boxed Value: " + bar);

            try {
                // double d = bar;       // 형변환 없으면 오류 발생
                double d = (double)bar;  // 언박싱(참조형 -> 값형)
                Console.WriteLine("Unboxed Value: " + d);
            }
            catch (InvalidCastException e) {
                Console.WriteLine(e + "Error");
            }
        }
    }
}
