using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 연습문제 4.16을 해결하기 위해 연습문제 4.12를 선행하였음

namespace ch4_16 {
    class Complex {
        // 필드 대신 프로퍼티 사용(Readonly)
        public double Real { get; }     // 실수부
        public double Image { get; }    // 허수부

        // 디폴트 생성자(실수 0, 허수 0)
        public Complex() {
            this.Real = 0;
            this.Image = 0;
        }

        // 생성자: 매개변수 1개 (허수가 0이므로 실수임)
        public Complex(double real) {
            this.Real = real;
            this.Image = 0;
        }

        // 생성자: 매개변수 2개
        public Complex(double real, double image) {
            this.Real = real;
            this.Image = image;
        }

        // 메소드 재정의(클래스명 대신 재정의한 문자열을 리턴함)
        override public string ToString() {
            string result = this.Real.ToString();   // 실수 출력(여기서 ToString()은 원래의 메소드)

            if (this.Image >= 0)    // 허수가 음수가 아닐 경우
                result += "+";      // '+' 부호 출력

            result += this.Image.ToString() + "i";  // 허수 출력

            return result;
        }

        // '+' 연산자 중복: 복소수 덧셈
        public static Complex operator+(Complex c1, Complex c2) {
            double tempReal = c1.Real + c2.Real;                // 실수끼리 덧셈
            double tempImage = c1.Image + c2.Image;             // 허수끼리 덧셈
            Complex result = new Complex(tempReal, tempImage);  // 덧셈 결과로 복소수 객체 생성
            return result;
        }

        // '-' 연산자 중복: 복소수 뺄셈
        public static Complex operator-(Complex c1, Complex c2) {
            double tempReal = c1.Real - c2.Real;                // 실수끼리 뺄셈
            double tempImage = c1.Image - c2.Image;             // 허수끼리 뺄셈
            Complex result = new Complex(tempReal, tempImage);  // 뺄셈 결과로 복소수 객체 생성
            return result;
        }

        // '*' 연산자 중복: 복소수 곱셈
        public static Complex operator*(Complex c1, Complex c2) {
            double a = c1.Real;
            double b = c1.Image;
            double c = c2.Real;
            double d = c2.Image;

            double tempReal = (a * c) - (b * d);
            double tempImage = (a * d) + (b * c);

            Complex result = new Complex(tempReal, tempImage);  // 곱셈 결과로 복소수 객체 생성
            return result;
        }

        // '/' 연산자 중복: 복소수 나눗셈
        public static Complex operator/(Complex c1, Complex c2) {
            double a = c1.Real;
            double b = c1.Image;
            double c = c2.Real;
            double d = c2.Image;

            double tempReal = ((a * c) + (b * d)) / ((c * c) + (d * d));
            double tempImage = ((b * c) - (a * d)) / ((c * c) + (d * d));

            Complex result = new Complex(tempReal, tempImage);  // 곱셈 결과로 복소수 객체 생성
            return result;
        }

    }

    internal class Program {
        static void Main(string[] args) {
            Console.Write("복소수 1의 실수부 : a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("복소수 1의 허수부 : b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("복소수 2의 실수부 : c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("복소수 2의 허수부 : d = ");
            double d = double.Parse(Console.ReadLine());

            Complex complex1 = new Complex(a, b);
            Complex complex2 = new Complex(c, d);

            Console.WriteLine();
            Console.WriteLine("복소수 1 : (a+bi) = {0}", complex1);
            Console.WriteLine("복소수 2 : (c+di) = {0}", complex2);

            Console.WriteLine("\n두 복소수의 사칙연산");
            Console.WriteLine("덧셈 : ({0}+{1}i) + ({2}+{3}i) = {4}", a, b, c, d, complex1 + complex2);
            Console.WriteLine("뺄셈 : ({0}+{1}i) - ({2}+{3}i) = {4}", a, b, c, d, complex1 - complex2);
            Console.WriteLine("곱셈 : ({0}+{1}i) * ({2}+{3}i) = {4}", a, b, c, d, complex1 * complex2);
            Console.WriteLine("나눗셈 : ({0}+{1}i) / ({2}+{3}i) = {4}", a, b, c, d, complex1 / complex2);
        }
    }
}
