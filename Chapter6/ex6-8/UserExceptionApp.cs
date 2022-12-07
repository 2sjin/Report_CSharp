using System;

// 예제 6-8을 크게 변형하였음

namespace ex6_8 {
    class UserErrException : ApplicationException {
        public UserErrException(string s) : base(s) {}
    }

    class UserExceptionApp {
        static void Main(string[] args) {
            string str;
            Console.WriteLine("5회 입력 완료 시, 예외 발생 없이 프로그램 종료");
            Console.WriteLine("입력 없이 [Enter] 키 입력 시, 예외 발생으로 프로그램 종료\n");

            try {
                for (int i = 0; i < 5; i++) {
                    Console.Write(" Input[{0}]: ", i);
                    str = Console.ReadLine();
                    if (str == "")
                        throw new UserErrException("\n예외가 발생하여 입력을 종료합니다.");
                    Console.WriteLine("Output[{0}]: " + str + "\n", i);
                }                
            } catch (UserErrException e) {
                Console.WriteLine(e.Message);
                return;
            } finally {
                Console.WriteLine("Finally");
            }
            Console.WriteLine("End Of Program");
        }
    }
}
