using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_24 {
    class Complex {
        private double realPart;    // 실수부
        private double imagePart;   // 허수부

        public Complex() {
            this.realPart = 0;
            this.imagePart = 0;
        }

        public Complex(double rVal, double iVal) {
            this.realPart = rVal;
            this.imagePart = iVal;
        }

        // 연산자 중복(리턴타입: Complex)
        public static Complex operator +(Complex x1, Complex x2) {
            Complex temp = new Complex();   // new Complex(0, 0)
            temp.realPart = x1.realPart + x2.realPart;
            temp.imagePart = x1.imagePart + x2.imagePart;
            return temp;
        }

        // ToString() 재정의
        // override 하지 않으면 프로젝트명.객체타입(deu20194146.Complex) 출력됨
        override public string ToString() {
            return "(" + this.realPart + " + " + this.imagePart + "i)";
        }
    }

    class OperatorOverloadingApp {
        static void Main(string[] args) {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(3, 4);
            Complex c = c1 + c2;

            Console.WriteLine("{0} + {1} = {2}", c1, c2, c);
        }
    }

}
