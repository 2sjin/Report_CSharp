using System;

delegate void MultiDelegate();  // 델리게이트 선언

namespace ex4_22 {
    class DelegateClass {
        public void MethodA() {
            Console.WriteLine("In the DelegateClass.MethodA ...");
        }

        public void MethodB() {
            Console.WriteLine("In the DelegateClass.MethodB ...");
        }

        public void MethodC() {
            Console.WriteLine("In the DelegateClass.MethodC ...");
        }

    }

    internal class DelegateOperationApp {
        static void Main(string[] args) {
            DelegateClass obj = new DelegateClass();

            // 델리게이트 객체 생성
            MultiDelegate dg1 = new MultiDelegate(obj.MethodA);
            MultiDelegate dg2 = new MultiDelegate(obj.MethodB);
            MultiDelegate dg3 = new MultiDelegate(obj.MethodC);

            // 델리게이트에 메소드 추가
            dg1 = dg1 + dg2;
            dg1 += dg3;

            // 델리게이트에서 메소드 제거
            dg2 = dg1 - dg2;

            Console.WriteLine("dg1 call ...");
            dg1();
            Console.WriteLine("After dg1 call ...\n");

            Console.WriteLine("dg2 call ...");
            dg2();
            Console.WriteLine("After dg2 call ...\n");

            Console.WriteLine("dg3 call ...");
            dg3();
            Console.WriteLine("After dg3 call ...\n");
        }
    }
}
