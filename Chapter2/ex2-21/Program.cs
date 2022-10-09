using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 입력한 3개의 숫자 중에서 가장 큰 숫자 출력
// Console.Read() 대신 Console.Readline() 사용

namespace ex2_21 {
    internal class Program {
        static void Main(string[] args) {
            int a, b, c;
            int readValue;
            int m;

            Console.Write("Enter three numbers : ");

            readValue = int.Parse(Console.ReadLine());  // 입력 값(string)을 int로 형변환

            a = readValue / 100;        // 예: 526 / 100 = 5
            b = readValue / 10 % 10;    // 예: 526 / 10 % 10 = 52 % 10 = 2
            c = readValue % 10;         // 예: 526 % 10 = 6

            // a = Console.Read() - '0';
            // b = Console.Read() - '0';
            // c = Console.Read() - '0';

            m = (a > b) ? a : b;    // if(a > b) m = a;    else m = b;
            m = (m > c) ? m : c;    // if(m > c) m = m;    else m = c;

            Console.WriteLine("The largest number = " + m);
        }
    }
}
