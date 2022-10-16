using System;

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

        // 메소드: 덧셈 연산
        public static Fraction AddFraction(Fraction f1, Fraction f2) {
            int a = f1.denominator;
            int b = f1.numerator;
            int c = f2.denominator;
            int d = f2.numerator;
            return new Fraction((b * c) + (a * d), a * c);
        }

        // 메소드: 뺄셈 연산
        public static Fraction SubFraction(Fraction f1, Fraction f2) {
            int a = f1.denominator;
            int b = f1.numerator;
            int c = f2.denominator;
            int d = f2.numerator;
            return new Fraction((b * c) - (a * d), a * c);
        }

        // 메소드: 곱셈 연산
        public static Fraction MulFraction(Fraction f1, Fraction f2) {
            int a = f1.denominator;
            int b = f1.numerator;
            int c = f2.denominator;
            int d = f2.numerator;
            return new Fraction(b * d, a * c);
        }

        // 메소드: 나눗셈 연산
        public static Fraction DivFraction(Fraction f1, Fraction f2) {
            int a = f1.denominator;
            int b = f1.numerator;
            int c = f2.denominator;
            int d = f2.numerator;
            return new Fraction(b * c, a * d);
        }

        // 메소드: 최대공약수 구하기(유클리드 호제법)
        public static int GCD(int n1, int n2) {
            int a, b, mod=1;

            // 둘중에 큰 수가 a, 작은 수가 b            
            if (Math.Abs(n1) > Math.Abs(n2)) {
                a = Math.Abs(n1);
                b = Math.Abs(n2);
            }
            else {
                a = Math.Abs(n2);
                b = Math.Abs(n1);
            }

            // 반복: a를 b로 나눈 나머지가 0이 되면 b 리턴
            while (true) {
                try {
                    mod = a % b;
                } catch (DivideByZeroException e) {
                    return 1;
                }

                if (mod == 0)
                    return b;
                a = b;
                b = mod;
            }
        }

        // 메소드: 기약분수 만들기
        public static Fraction Fix(Fraction f) {
            int gcd = GCD(f.numerator, f.denominator);  // 최대공약수 구하기
            f = new Fraction((f.numerator / gcd), (f.denominator / gcd));   // 약분
            return f;
        }

        // 메소드 재정의(클래스명 대신 재정의한 문자열을 리턴함)
        override public string ToString() {
            // 분모가 음수인 경우, 가독성을 위해 -1을 통분하여 분모를 양수로 변환함
            if (denominator < 0)
                return (-1*numerator) + "/" + (-1*denominator);
            else
                return numerator + "/" + denominator;
        }
    }

    internal class Program {
        // 정적 메소드: 분수 입력 및 객체 생성(기약분수)하여 리턴
        static Fraction createFraction(string name) {
            Fraction f;
            int num, denom;

            // 분자 입력
            Console.Write(name + "의 분자 : ");
            num = int.Parse(Console.ReadLine());

            // 분모 입력
            while (true) {
                Console.Write(name + "의 분모 : ");
                denom = int.Parse(Console.ReadLine());
                if (denom != 0) break;
            }

            f = new Fraction(num, denom);   // 분수 객체 생성
            f = Fraction.Fix(f);          // 기약분수 만들기

            return f;
        }

        static void Main(string[] args) {
            Fraction f1, f2, fAdd, fSub, fMul, fDiv;

            Console.WriteLine("분자는 정수, 분모는 0을 제외한 정수를 입력할 수 있습니다.\n");

            // 분수 1 입력
            f1 = createFraction("분수 1");
            Console.WriteLine("b/a = {0}\n", f1);

            // 분수 2 입력
            f2 = createFraction("분수 2");
            Console.WriteLine("d/c = {0}\n", f2);

            // 분수의 사칙연산
            fAdd = Fraction.Fix(Fraction.AddFraction(f1, f2));
            fSub = Fraction.Fix(Fraction.SubFraction(f1, f2));
            fMul = Fraction.Fix(Fraction.MulFraction(f1, f2));
            fDiv = Fraction.Fix(Fraction.DivFraction(f1, f2));

            // 분수의 사칙연산 결과 출력
            Console.WriteLine("덧셈\t ({0}) + ({1}) = {2}", f1, f2, fAdd);
            Console.WriteLine("뺄셈\t ({0}) - ({1}) = {2}", f1, f2, fSub);
            Console.WriteLine("곱셈\t ({0}) * ({1}) = {2}", f1, f2, fMul);
            Console.WriteLine("나눗셈\t ({0}) / ({1}) = {2}", f1, f2, fDiv);
        }
    }
}
