using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_13 {
    class Stack {
        private int[] stack;    // 스택
        private int sp = -1;    // 스택 포인터

        // 디폴트 생성자(스택의 크기 100)
        public Stack() {
            stack = new int[100];
        }

        // 생성자
        public Stack(int size) {
            stack = new int[size];
        }

        // Push 메소드
        public void Push(int data) {
            sp++;
            stack[sp] = data;
        }

        // Pop 메소드
        public int Pop() {
            sp--;
            return stack[sp+1];
        }

        // 스택이 비었는지 확인
        public bool IsEmpty() {
            return sp <= -1;     // 스택 포인터가 -1이면 비어있는 상태
        }
    }

    internal class Program {
        static void Main(string[] args) {
            int inputNum = 0;

            // 스택 객체 생성
            Stack stack = new Stack(10);

            // 정수 0을 입력받을 때 까지 입력 및 Push 반복
            while (true) {
                // 정수 입력
                try {
                    Console.Write("Push할 정수: ");
                    inputNum = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("[입력 오류] 정수를 다시 입력해주세요.");
                    continue;
                }

                // 0 입력 시 스택 Push 종료
                if (inputNum == 0) break;

                // 입력한 정수를 스택에 Push
                stack.Push(inputNum);                
            }

            // 입력한 정수를 역순으로 Pop하여 출력함
            while (!stack.IsEmpty()) {      // 스택이 비어있지 않으면 계속 반복함
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
