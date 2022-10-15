using System;

// Before: x = 1, y = 1
//    Inc: x = 2, y = 2
//  After: x = 2, y = 1

namespace ch4_7_1 {
    class Program {
        static void Inc(ref int x, int y) {
            ++x; ++y;
            Console.WriteLine("   Inc: x = {0}, y = {1}", x, y);
        }

        public static void Main() {
            int x = 1, y = 1;
            Console.WriteLine("Before: x = {0}, y = {1}", x, y);

            // x는 call by reference: 함수 내부에서 변경된 값이 함수 외부에 반영됨
            // y는 call by value: 함수 내부에서 변경된 값이 함수 외부에 반영되지 않음

            Inc(ref x, y);
            Console.WriteLine(" After: x = {0}, y = {1}", x, y);
        }
    }
}
