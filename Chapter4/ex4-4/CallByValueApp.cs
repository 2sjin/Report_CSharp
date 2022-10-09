using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 값 호출

namespace ex4_4 {
    internal class CallByValueApp {
        static void Swap(int x, int y) {
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Swap:\t x = {0}, y = {1}", x, y);
        }
        
        static void Main(string[] args) {
            int x = 1, y = 2;
            Console.WriteLine("Before:\t x = {0}, y = {1}", x, y);
            Swap(x, y);
            Console.WriteLine("After:\t x = {0}, y = {1}", x, y);
        }
    }
}
