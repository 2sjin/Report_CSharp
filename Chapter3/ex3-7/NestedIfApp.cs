using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_7 {
    internal class NestedIfApp {
        static void Main(string[] args) {
            int day;
            Console.Write("요일을 숫자로 입력하세요(1 ~ 7) : ");

            day = (int)Console.Read() - '0';
            // day = (int)Console.Read() - 48;
            // day = int.Parse(Console.ReadLine());

            switch (day) {
                case 1: Console.Write("일"); break;
                case 2: Console.Write("월"); break;
                case 3: Console.Write("화"); break;
                case 4: Console.Write("수"); break;
                case 5: Console.Write("목"); break;
                case 6: Console.Write("금"); break;
                case 7: Console.Write("토"); break;
                default: Console.Write("[Error] 잘못된 "); break;
            }
            Console.WriteLine("요일");
        }
    }
}
