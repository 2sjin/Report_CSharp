using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 객체 호출(참조 호출)

namespace ex4_6 {
    class Number {
        public int num;
        public Number(int num) {
            this.num = num;
        }
    }

    internal class CallByObjectReferenceApp {
        static void Swap(Number x, Number y) {
            int temp;
            temp = x.num;
            x.num = y.num;
            y.num = temp;
            Console.WriteLine("Swap:\t x = {0}, y = {1}", x.num, y.num);
        }

        static void Main(string[] args) {
            Number x = new Number(1);
            Number y = new Number(2);

            Console.WriteLine("Before:\t x = {0}, y = {1}", x.num, y.num);
            Swap(x, y);
            Console.WriteLine("After:\t x = {0}, y = {1}", x.num, y.num);
        }
    }
}
