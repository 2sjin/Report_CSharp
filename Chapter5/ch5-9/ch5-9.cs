using System;

// 코드가 길어지는 관계로 아래와 같이 클래스를 나누어 보았음
// 인터페이스, 엔티티 클래스(스택/큐), 제어 클래스(스택/큐), 경계 클래스

namespace ch5_9 {
    // 인터페이스
    interface IOperation {
        void Insert(string str);
        string delete();
        bool Search(string str);
        string GetCurrentElt();
        int NumOfElements();
    }

    // 엔티티 클래스: 스택 (인터페이스의 파생 클래스)
    class StackEntity : IOperation {
        string[] stack;     // 스택
        int sp = -1;        // 스택 포인터

        // 생성자
        public StackEntity(int i=100) {
            Console.WriteLine("크기가 {0}인 스택 생성됨.", i);
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
            for (int i = 0; i <= sp; i++) {
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
    
    // 제어 클래스: 스택(엔티티 클래스)과 UI(경계 클래스)를 중간에서 제어함
    class StackController {
        // 자동 프로퍼티
        StackEntity stack = new StackEntity();

        // 메소드: 스택 원소 개수 및 탑 원소 출력
        public void PrintStackInfo() {
            Console.WriteLine("{0}개 저장됨, top={1}", stack.NumOfElements(), stack.GetCurrentElt());
        }

        // 메소드: 스택 PUSH 반복
        public void PushStack() {
            string inputData;

            Console.WriteLine("\n스택에 PUSH할 문자열을 입력하세요. (종료하려면 입력 없이 [Enter])");

            while (true) {
                Console.Write("PUSH >> ");
                inputData = Console.ReadLine();
                if (inputData.Equals(""))   // 공백 입력 시
                    break;                  // 반복 종료
                stack.Insert(inputData);    // PUSH
                PrintStackInfo();
            }
        }

        // 메소드: 스택 검색 반복
        public void SearchStack() {
            string searchData;

            Console.WriteLine("\n검색할 문자열을 입력하세요. (종료하려면 입력 없이 [Enter])");

            while (true) {
                Console.Write("SEARCH >> ");
                searchData = Console.ReadLine();
                if (searchData.Equals(""))   // 공백 입력 시
                    break;                   // 반복 종료
                else if (stack.Search(searchData))
                    Console.WriteLine(searchData + " : Stack 내에 존재합니다.");
                else
                    Console.WriteLine(searchData + " : Stack 내에 없습니다.");
            }
        }

        // 메소드: 스택 POP 반복
        public void PopStack() {
            Console.WriteLine("");

            while (stack.NumOfElements() > 0) {
                Console.WriteLine("POP >> " + stack.delete());
                PrintStackInfo();
            }
        }
    }


    // 경계 클래스: 사용자 인터페이스
    class BoundaryApp {
        // 메소드: Main
        static void Main(string[] args) {
            StackController stackController = new StackController();
            stackController.PrintStackInfo();
            stackController.PushStack();
            stackController.SearchStack();
            stackController.PopStack();
        }
    }
}
