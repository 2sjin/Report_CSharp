using System;

namespace ex6_3 {
    internal class GenericMethodApp {
        static void Swap<DataType>(ref DataType x, ref DataType y) {
            DataType temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args) {
            Console.WriteLine("\nSwap<int>()");
            int a = 1, b = 2;
            Console.WriteLine("Before: a = {0}, b = {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine(" After: a = {0}, b = {1}", a, b);

            Console.WriteLine("\nSwap<double>()");
            double c = 1.5, d = 2.5;
            Console.WriteLine("Before: c = {0}, d = {1}", c, d);
            Swap<double>(ref c, ref d);
            Console.WriteLine(" After: c = {0}, d = {1}", c, d);

            Console.WriteLine("\nSwap<string>()");
            string str1 = "이승진", str2 = "홍길동";
            Console.WriteLine("Before: str1 = {0}, str2 = {1}", str1, str2);
            Swap<string>(ref str1, ref str2);
            Console.WriteLine(" After: str1 = {0}, str2 = {1}", str1, str2);
        }
    }
}
