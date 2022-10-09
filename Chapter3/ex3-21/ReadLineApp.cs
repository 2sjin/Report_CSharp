using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_21 {
    internal class ReadLineApp {
        static void Main(string[] args) {
            int time, hour, minute, second;

            Console.WriteLine("*** Enter an integral time: ");
            time = int.Parse(Console.ReadLine());   // 입력 값(string)을 int로 형변환

            hour = time / 10000;            // 예: 102030 / 10000 = 10
            minute = time / 100 % 100;      // 예: 102030 / 100 % 100 = 1020 % 100 = 20
            second = time % 100;            // 예: 102030 % 100 = 30

            Console.WriteLine("*** Time is " + hour + ":" + minute + ":" + second);
            Console.WriteLine("*** Time is {0}:{1}:{2}", hour, minute, second);
        }
    }
}
