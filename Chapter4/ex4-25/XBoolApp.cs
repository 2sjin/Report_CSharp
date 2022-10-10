using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_25 {
    class XBool {
        public bool b;

        // 묵시적 형 변환 연산자 중복
        public static implicit operator bool(XBool x) {
            Console.WriteLine("묵시적 형 변환 연산자 호출");
            return x.b;
        }

        /*
        // 명시적 형 변환 연산자 중복
        public static explicit operator bool(XBool x) {
            Console.WriteLine("명시적 형 변환 연산자 호출");
            return x.b;
        }

        // true 연산자 중복
        public static bool operator true(XBool x) {
            Console.WriteLine("XBool 타입의 true 연산자 호출");
            return x.b ? true : false;
        }

        // false 연산자 중복
        public static bool operator false(XBool x) {
            Console.WriteLine("XBool 타입의 false 연산자 호출");
            return x.b ? false : true;
        }
        */
    }

    internal class XBoolApp {
        static void Main(string[] args) {
            XBool xb = new XBool();
            xb.b = false;

            if (xb)
                Console.WriteLine("fb is True.\n");
            else
                Console.WriteLine("fb is False.\n");

            Console.WriteLine(xb);
            Console.WriteLine((bool)xb);
        }
    }
}
