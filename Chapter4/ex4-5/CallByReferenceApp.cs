using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 참조(주소) 호출 : 매개 변수 앞에 ref 또는 out 지정

namespace ex4_5 {
    internal class CallByReferenceApp {
        static void Swap(ref int x, ref int y) {    // 참조 호출(ref)
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Swap:\t x = {0}, y = {1}", x, y);
        }

        static void Main(string[] args) {
            int x = 1, y = 2;
            Console.WriteLine("Before:\t x = {0}, y = {1}", x, y);
            Swap(ref x, ref y);     // 참조 호출(ref)
            Console.WriteLine("After:\t x = {0}, y = {1}", x, y);
        }
    }
}
