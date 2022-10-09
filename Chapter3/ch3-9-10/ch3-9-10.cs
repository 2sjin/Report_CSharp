using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 거스름돈 동전의 개수가 최소가 되도록 계산하는 프로그램

namespace ch3_9_10 {
    internal class Program {
        static void Main(string[] args) {
            int price, pay, change;

            // 동전(순서대로 1원, 5원, 10원, 50원, 100원, 500원)
            int[] coinCount = { 0, 0, 0, 0, 0, 0 };         // 거스름돈 동전의 개수
            int[] coinPrice = { 1, 5, 10, 50, 100, 500 };   // 동전 하나 당 가격

            Console.Write("물건의 금액: ");
            price = int.Parse(Console.ReadLine());

            pay = 1000;
            Console.WriteLine("낸 돈: " + pay);

            change = pay - price;
            Console.WriteLine("거스름돈: " + change + "\n");

            for (int i = coinCount.Length-1; i >= 0; i--) {
                coinCount[i] = change / coinPrice[i];
                change -= coinPrice[i] * coinCount[i];
                Console.WriteLine("{0} 원\t\t{1} 개", coinPrice[i], coinCount[i]);
            }
        }
    }
}
