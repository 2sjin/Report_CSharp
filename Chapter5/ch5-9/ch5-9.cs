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

    // ========================================================================================

    // 엔티티 클래스: 스택 (인터페이스의 파생 클래스)
    class StackEntity : IOperation {
        string[] stack;     // 스택 배열
        int sp = -1;        // 스택 포인터
        int size;           // 스택 배열의 크기

        // 생성자
        public StackEntity(int i = 10) {
            Console.WriteLine("크기가 {0}인 스택 생성됨.", i);
            stack = new string[i];
            size = i;
        }

        // 메소드: 스택 Push
        public void Insert(string str) {
            if (sp >= size-1) {
                Console.WriteLine("    스택이 가득 찼습니다.");
                return;
            }
            sp++;
            stack[sp] = str;
        }

        // 메소드: 스택 Pop
        public string delete() {
            sp--;
            return stack[sp + 1];
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
            return sp + 1;    // sp가 -1이면 0개, sp가 0이면 1개, sp가 1이면 2개, ...
        }
    }


    // 엔티티 클래스: 큐 (인터페이스의 파생 클래스)
    class QueueEntity : IOperation {
        string[] queue;     // 큐 배열
        int front = 0;      // front 포인터
        int rear = 0;       // rear 포인터
        int size;           // 큐 배열의 크기

        // 생성자
        public QueueEntity(int i = 10) {
            Console.WriteLine("크기가 {0}인 큐 생성됨.", i);
            queue = new string[i];
            size = i;
        }

        // 메소드: 큐 Push (rear)
        public void Insert(string str) {
            if (rear >= size) {
                Console.WriteLine("    큐가 가득 찼습니다.");
                return;
            }
            queue[rear] = str;
            rear++;
        }

        // 메소드: 큐 Pop (front)
        public string delete() {
            front++;
            return queue[front - 1];
        }

        // 메소드: 주어진 원소의 존재여부 반환
        public bool Search(string str) {
            bool result = false;
            for (int i = front; i <= rear; i++) {
                if (str.Equals(queue[i])) {
                    result = true;
                    break;
                }
            }
            return result;
        }

        // 메소드: 큐 front에 있는 원소 반환
        public string GetCurrentElt() {
            if (front == rear) return "";    // 큐가 비어 있으면 공백 리턴
            return queue[front];
        }

        // 메소드: 큐에 존재하는 원소 개수 반환
        public int NumOfElements() {
            return rear - front;
        }
    }

    // ========================================================================================

    // 제어 클래스의 추상 클래스
    abstract class Controller {
        abstract public void PrintInfo();
        abstract public void Push();
        abstract public void Search();
        abstract public void Pop();
    }

    // 제어 클래스: 스택(엔티티 클래스)과 UI(경계 클래스)를 중간에서 제어함
    class StackController : Controller {
        // 스택 필드
        StackEntity stack = new StackEntity();

        // 메소드 재정의: 스택 원소 개수 및 탑 원소 출력
        override public void PrintInfo() {
            Console.Write("  ({0}개 저장됨, top={1})\t",
                stack.NumOfElements(), stack.GetCurrentElt());
        }

        // 메소드 재정의: 스택 PUSH 반복
        override public void Push() {
            string inputData;

            Console.WriteLine("\n스택에 PUSH할 문자열을 입력하세요. (종료하려면 입력 없이 [Enter])");
            PrintInfo();

            while (true) {
                Console.Write("PUSH >> ");
                inputData = Console.ReadLine();
                if (inputData.Equals(""))   // 공백 입력 시
                    break;                  // 반복 종료
                stack.Insert(inputData);    // PUSH
                PrintInfo();
            }
        }

        // 메소드 재정의: 스택 검색 반복
        override public void Search() {
            string searchData;

            Console.WriteLine("\n검색할 문자열을 입력하세요. (종료하려면 입력 없이 [Enter])");

            while (true) {
                Console.Write("  SEARCH >> ");
                searchData = Console.ReadLine();
                if (searchData.Equals(""))   // 공백 입력 시
                    break;                   // 반복 종료
                else if (stack.Search(searchData))
                    Console.WriteLine("    " + searchData + " : Stack 내에 존재합니다.");
                else
                    Console.WriteLine("    " + searchData + " : Stack 내에 없습니다.");
            }
        }

        // 메소드 재정의: 스택 POP 반복
        override public void Pop() {
            Console.WriteLine("");

            while (stack.NumOfElements() > 0) {
                Console.Write("POP >> " + stack.delete() + " ");
                PrintInfo();
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
    }

    // 제어 클래스: 큐(엔티티 클래스)와 UI(경계 클래스)를 중간에서 제어함
    class QueueController : Controller {
        // 큐 필드
        QueueEntity queue = new QueueEntity();

        // 메소드 재정의: 큐 원소 개수 및 front 원소 출력
        override public void PrintInfo() {
            Console.Write("  ({0}개 저장됨, front={1})\t",
                queue.NumOfElements(), queue.GetCurrentElt());
        }

        // 메소드 재정의: 큐 PUSH 반복
        override public void Push() {
            string inputData;

            Console.WriteLine("\n큐에 PUSH할 문자열을 입력하세요. (종료하려면 입력 없이 [Enter])");
            PrintInfo();

            while (true) {
                Console.Write("PUSH >> ");
                inputData = Console.ReadLine();
                if (inputData.Equals(""))   // 공백 입력 시
                    break;                  // 반복 종료
                queue.Insert(inputData);    // PUSH
                PrintInfo();
            }
        }

        // 메소드 재정의: 큐 검색 반복
        override public void Search() {
            string searchData;

            Console.WriteLine("\n검색할 문자열을 입력하세요. (종료하려면 입력 없이 [Enter])");

            while (true) {
                Console.Write("  SEARCH >> ");
                searchData = Console.ReadLine();
                if (searchData.Equals(""))   // 공백 입력 시
                    break;                   // 반복 종료
                else if (queue.Search(searchData))
                    Console.WriteLine("    " + searchData + " : Queue 내에 존재합니다.");
                else
                    Console.WriteLine("    " + searchData + " : Queue 내에 없습니다.");
            }
        }

        // 메소드 재정의: 큐 POP 반복
        override public void Pop() {
            Console.WriteLine("");

            while (queue.NumOfElements() > 0) {
                Console.Write("POP >> " + queue.delete() + " ");
                PrintInfo();
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
    }

    // =========================================================================================

    // 경계 클래스: 사용자 인터페이스
    class BoundaryApp {
        // 메소드: Main
        static void Main(string[] args) {
            StackController stackController = new StackController();
            stackController.Push();
            stackController.Search();
            stackController.Pop();

            QueueController queueController = new QueueController();
            queueController.Push();
            queueController.Search();
            queueController.Pop();
        }
    }
}
