using System;

namespace ex5_3 {
    class BaseClass {
        public int a, b;
        
        public BaseClass() {
            Console.WriteLine("생성자 호출: BaseClass()");
            a = 1;
            b = 1;
        }

        public BaseClass(int a, int b) {
            Console.WriteLine("생성자 호출: BaseClass(int a, int b)");
            this.a = a;
            this.b = b;
        }
    }

    class DeriverClass : BaseClass {
        public int c;
        
        public DeriverClass() {
            Console.WriteLine("생성자 호출: DeriverClass()");
            c = 1;
        }

        public DeriverClass(int a, int b, int c) : base(a, b) { // 부모 클래스의 생성자 호출
            Console.WriteLine("생성자 호출: DeriverClass(int a, int b, int c) : base(int a, int b)");
            this.c = c;
        }
    }

    internal class BaseCallApp {
        static void Main(string[] args) {
            DeriverClass obj1 = new DeriverClass();
            Console.WriteLine("a = {0}, b = {1}, c = {2}\n", obj1.a, obj1.b, obj1.c);

            DeriverClass obj2 = new DeriverClass(100, 200, 300);
            Console.WriteLine("a = {0}, b = {1}, c = {2}\n", obj2.a, obj2.b, obj2.c);
        }
    }
}
