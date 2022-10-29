using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_2 {
    internal class IntegerConstantApp {
        static void Main(string[] args) {
            int i = 255, h = 0Xff;
            long l = 0XffL;
            Console.WriteLine("i = {0}, h = {1}", i, h);
            Console.WriteLine("i = {0:X}, h = {1:X}", i, h);

            if (h == 1)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
