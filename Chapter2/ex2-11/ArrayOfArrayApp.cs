using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 배열의 배열을 정적 배열로 선언하기

namespace ex2_11 {
    internal class ArrayOfArrayApp {
        static void Main(string[] args) {

            // int[][] arrayOfArray = new int[3][];    // 배열 선언

            // 정적 배열 선언
            int[] arr1 = { 0, 0, 0 };
            int[] arr2 = { 0, 0, 0, 0 };
            int[] arr3 = { 0, 0, 0, 0, 0 };
            int[][] arrayOfArray = { arr1, arr2, arr3 };

            int i, j;

            for (i = 0; i < arrayOfArray.Length; i++)
                arrayOfArray[i] = new int[i + 3];   // 배열의 배열 선언

            for (i = 0; i < arrayOfArray.Length; i++)
                for (j = 0; j < arrayOfArray[i].Length; j++)
                    arrayOfArray[i][j] = i * arrayOfArray[i].Length + j;    // 배열의 배열에 값 저장

            for (i = 0; i < arrayOfArray.Length; i++) {
                for (j = 0; j < arrayOfArray[i].Length; j++)
                    Console.Write(" " + arrayOfArray[i][j]);    // 출력
                Console.WriteLine();
            }
        }
    }
}
