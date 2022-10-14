using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_8 {
    abstract class figure {     // 도형 클래스: 추상 클래스
        public abstract void Area();   // 넓이를 구하는 메소드(추상 메소드)
        public abstract void Girth();  // 둘레를 구하는 메소드(추상 메소드)
        public abstract void Draw();   // 도형을 그리는 메소드(추상 메소드)
    }

    class Square : figure {     // 사각형 클래스: 추상 메소드의 파생 클래스
        double width;       // 가로 길이
        double height;      // 세로 길이

        // 생성자
        public Square(double width=1, double height=1) {
            this.width = width;
            this.height = height;
        }

        // 메소드 재정의: 사각형의 넓이
        override public void Area() {
            Console.WriteLine("사각형의 넓이: {0:F2}", width * height);
            return;
        }

        // 메소드 재정의: 사각형의 둘레
        override public void Girth() {
            Console.WriteLine("사각형의 둘레: {0:F2}", (width + height) * 2);
            return;
        }

        // 메소드 재정의: 사각형 그리기
        public override void Draw() {
            Console.WriteLine("사각형 그리기 완료");
            return;
        }
    }

    class Circle : figure {     // 원 클래스: 추상 메소드의 파생 클래스
        double radius;      // 원의 반지름

        // 생성자
        public Circle (double radius=1) {
            this.radius = radius;
        }

        // 메소드 재정의: 원의 넓이
        override public void Area() {
            Console.WriteLine("원의 넓이: {0:F2}", 2 * Math.PI * radius);
            return;
        }

        // 메소드 재정의: 원의 둘레
        override public void Girth() {
            Console.WriteLine("원의 둘레: {0:F2}", Math.PI * Math.Pow(radius, 2));
            return;
        }

        // 메소드 재정의: 원 그리기
        public override void Draw() {
            Console.WriteLine("원 그리기 완료");
            return;
        }
    }

    internal class Program {
        static void Main(string[] args) {
            double w, h, r;
            
            Console.Write("사각형의 가로 길이 입력: ");
            w = double.Parse(Console.ReadLine());
            Console.Write("사각형의 세로 길이 입력: ");
            h = double.Parse(Console.ReadLine());

            Square square = new Square(w, h);
            square.Area();
            square.Girth();
            square.Draw();

            Console.Write("\n원의 반지름 입력: ");
            r = double.Parse(Console.ReadLine());
            
            Circle circle = new Circle(r);
            circle.Area();
            circle.Girth();
            circle.Draw();
        }
    }
}
