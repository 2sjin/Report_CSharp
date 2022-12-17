using System;

namespace ex6_16 {
    class PropagateApp {
        void Orange() {
            Console.WriteLine("Beginning of Orange method");
            int i = 25, j = 0;
            i = i / j;
            Console.WriteLine("End of Orange method");
        }

        void Apple() {
            Console.WriteLine("Beginning of Apple method");
            Orange();
            Console.WriteLine("End of Apple method");
        }

        static void Main(string[] args) {
            Console.WriteLine("Beginning of Main");
            PropagateApp p = new PropagateApp();
            try {
                p.Apple();  // 예외는 Orange() 메소드에서 발생하였지만, Main으로 예외를 전파하여 처리함
            } catch (ArithmeticException) {
                Console.WriteLine("ArithmeticException is processed");
            }
            Console.WriteLine("End of Main");
        }
    }
}
