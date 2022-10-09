using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 예제 4-14 변형
// 1) 분수 클래스 대신 실수 두개를 합하는 클래스 정의
// 2) 프로퍼티를 자동 프로퍼티로 변경

namespace ex4_14 {
    class Number {
        // 필드(자동 프로퍼티 사용 시 불필요)
        double num1;
        double num2;

        // 속성 코드 조각: prop [tab] [tab]
        // public int MyProperty { get; set; }

        // 속성 코드 조각: propfull [tab] [tab]
        // private int myVar;
        // public int MyProperty {
        //     get { return myVar; }
        //     set { myVar = value; }
        // }

        // 프로퍼티
        public double Num1 {
            get { Console.WriteLine("get Num1"); return num1; }
            set { Console.WriteLine("set Num1"); num1 = value; }
        }

        // 프로퍼티
        public double Num2 {
            get { Console.WriteLine("get Num2"); return num2; }
            set { Console.WriteLine("set Num2"); num2 = value; }
        }

        // 자동 프로퍼티
        public double AutoNum1 { get; set; }
        public double AutoNum2 { get; set; }

        // Java 스타일의 getter, setter
        public double getNum1() { return num1; }
        public double getNum2() { return num2; }
        public void setNum1(double num1) { this.num1 = num1; }
        public void setNum2(double num2) { this.num2 = num2; }

        // 메소드
        public double Add() {
            return num1 + num2;
        }

        // 메소드(자동 구현 프로퍼티)
        public double AutoAdd() {
            return AutoNum1 + AutoNum2;     // 자동 구현 프로퍼티는 필드 사용 불가
        }
    }

    class Program {
        static void Main(string[] args) {
            Number n = new Number();

            Console.Write("num1 입력: ");
            // n.setNum1(double.Parse(Console.ReadLine()));
            // n.Num1 = double.Parse(Console.ReadLine());
            n.AutoNum1 = double.Parse(Console.ReadLine());

            Console.Write("num2 입력: ");
            // n.setNum2(double.Parse(Console.ReadLine()));
            // n.Num2 = double.Parse(Console.ReadLine());
            n.AutoNum2 = double.Parse(Console.ReadLine());

            // Console.WriteLine("{0} + {1} = {2}", n.getNum1(), n.getNum2(), n.Add());
            // Console.WriteLine("{0} + {1} = {2}", n.Num1, n.Num2, n.Add());
            Console.WriteLine("Correct: {0} + {1} = {2}", n.AutoNum1, n.AutoNum2, n.AutoAdd());
        }
    }
}
