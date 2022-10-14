using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_4 {
    class BaseClass {
        public void MethodA() {
            Console.WriteLine("BaseClass의 메소드 MethodA() 호출됨 ...");
        }
    }

    class DerivedClass : BaseClass {
        // 메소드 재정의(오버라이딩)
        new public void MethodA() {
            Console.WriteLine("DerivedClass의 메소드 MethodA() 호출됨 ... 메소드 재정의(오버라이딩)");
        }

        // 메소드 중복(오버로딩) : BaseClass의 MethodA() 메소드와는 관련 없음
        public void MethodA(int i) {
            Console.WriteLine("DerivedClass의 메소드 MethodA(int i) 호출됨 .... 메소드 중복(오버로딩)");
        }
    }

    internal class OverridingAndOverloadingApp {
        static void Main(string[] args) {
            BaseClass obj1 = new BaseClass();
            DerivedClass obj2 = new DerivedClass();
            obj1.MethodA();
            obj2.MethodA();
            obj2.MethodA(1);
        }
    }
}
