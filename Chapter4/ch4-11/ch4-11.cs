using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_11 {
    class Fraction {
        public int numerator;       // 분자
        public int denominator;     // 분모

        // 생성자: 매개변수 없는 생성자
        public Fraction() {
            this.numerator = 1;
            this.denominator = 1;
        }

        // 생성자: 한 개의 정수를 받아 초기화
        public Fraction(int numerator) {
            this.numerator = numerator;
            this.denominator = 1;
        }

        // 생성자: 두 개의 정수를 받아 초기화
        public Fraction(int numerator, int denominator) {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        // 메소드 재정의(클래스명 대신 재정의한 문자열을 리턴함)
        override public string ToString() {
            return this.numerator + "/" + this.denominator;
        }
    }

    internal class Program {
        static void Main(string[] args) {
            Fraction f = new Fraction(2, 3);
            Console.WriteLine(f);
        }
    }
}
