using System;

namespace ex5_5 {
    class BaseClass {
        virtual public void MethodA() {
            Console.WriteLine("BaseClass의 가상 메소드 MethodA() 호출됨.");
        }
        virtual public void MethodB() {
            Console.WriteLine("BaseClass의 가상 메소드 MethodB() 호출됨.");
        }
        virtual public void MethodC() {
            Console.WriteLine("BaseClass의 가상 메소드 MethodC() 호출됨.");
        }
    }

    class DerivedClass : BaseClass {
        new public void MethodA() {
            Console.WriteLine("DerivedClass의 new 메소드 MethodA() 호출됨.");
        }
        override public void MethodB() {
            Console.WriteLine("BaseClass의 override 메소드 MethodB() 호출됨.");
        }
        public void MethodC() {
            Console.WriteLine("BaseClass의 메소드 MethodC() 호출됨.");
        }
    }

    internal class VirtualMethodApp {
        static void Main(string[] args) {
            BaseClass s = new DerivedClass();
            s.MethodA();    // 객체 타입인 BaseClass의 메소드가 호출됨
            s.MethodB();    // 객체 참조가 가리키는 객체의 타입 DerivedClass의 메소드가 호출됨
            s.MethodC();    // 객체 타입인 BaseClass의 메소드가 호출됨 
        }
    }
}
