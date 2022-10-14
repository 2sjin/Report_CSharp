using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_6 {
    abstract class AbstractClass {          // 추상 클래스: 추상 메소드가 1개 이상인 클래스
        public abstract void MethodA();     // 추상 메소드: 구현 없이 선언만 있는 메소드

        // 구현된 메소드
        public void MethodB() {
            Console.WriteLine("AbstractClass에서 구현된 메소드 MethodB() 호출됨.");
        }
    }

    class ImpClass : AbstractClass {        // 파생 클래스
        override public void MethodA() {    // 추상 메소드 재정의(구현)
            Console.WriteLine("ImpClass에서 재정의(구현)된 메소드 MethodA() 호출됨.");
        }
    }

    internal class AbstractClassApp {
        static void Main(string[] args) {
            ImpClass obj = new ImpClass();
            obj.MethodA();
            obj.MethodB();
        }
    }
}
