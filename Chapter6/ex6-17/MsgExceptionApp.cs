using System;

namespace ex6_17 {
    class MyException : ApplicationException {
        public int value;
        public MyException() { }
        public MyException(string msg, int i) : base(msg) {
            value = i;
        }
    }

    internal class MsgExceptionApp {
        static void F() {
            throw new MyException();
        }

        static void G(int k) {
            if (k > 200)
                throw new MyException("Too Many", k);
            if (k < 50)
                throw new MyException("Too Less", k);
        }

        static void Main(string[] args) {
            try {
                F();    // 메소드 F에서 Main으로 예외 전파
            } catch (MyException e) {
                Console.WriteLine("e.Message : " + e.Message);
                Console.WriteLine("========== StackTrace ==========");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("================================\n\n");
            }

            try {
                G(250);     // 메소드 G에서 Main으로 예외 전파
            } catch (MyException e) {
                Console.WriteLine("e.Message : " + e.Message);
                Console.WriteLine("========== StackTrace ==========");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("================================");
                Console.WriteLine("Data value is {0}.\n", e.value);
            }
        }
    }
}
