using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_9 {
    // 인터페이스
    interface IOperation {
        void Insert(string str);
        string delete();
        bool Search(string str);
        string GetCurrentElt();
        int NumOfElements();
    }

    class Stack : IOperation {
        string[] stack;     // 스택
        int sp = -1;        // 스택 포인터

        // 생성자
        public Stack(int i=100) {
            stack = new string[i];
        }

        // 메소드: 스택 Push
        public void Insert(string str) {
            sp++;   
            stack[sp] = str;
        }

        // 메소드: 스택 Pop
        public string delete() {
            sp--;
            return stack[sp+1];
        }

        // 메소드: 주어진 원소의 존재여부 반환
        public bool Search(string str) {
            bool result = false;
            for (int i = 0; i < sp; i++) {
                if (str.Equals(stack[i])) {
                    result = true;
                    break;
                }
            }
            return result;
        }

        // 메소드: 스택 탑에 있는 원소 반환
        public string GetCurrentElt() {
            if (sp <= -1) return "";    // 스택이 비어 있으면 공백 리턴
            return stack[sp];
        }

        // 메소드: 스택에 존재하는 원소 개수 반환
        public int NumOfElements() {
            return sp+1;    // sp가 -1이면 0개, sp가 0이면 1개, sp가 1이면 2개, ...
        }
    }
    


    internal class Program {
        static void PrintStackInfo(Stack stack) {
            Console.WriteLine("{0}개 저장됨, top={1}", stack.NumOfElements(), stack.GetCurrentElt());
        }

        static void Main(string[] args) {
            string inputData;

            Stack stack = new Stack();

            Console.WriteLine("스택에 PUSH할 문자열을 입력하세요\n(종료는 입력 없이 Enter)");
            while(true) {

                Console.Write("PUSH >> ");
                inputData = Console.ReadLine();
                if (inputData.Equals(""))
                    break;
                stack.Insert(inputData);    // PUSH
                PrintStackInfo(stack);
            }

            Console.WriteLine("");
            while(stack.NumOfElements() > 0) {
                Console.WriteLine("POP >> " + stack.delete());
                PrintStackInfo(stack);
            }

        }
    }
}
