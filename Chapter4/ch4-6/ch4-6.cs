
///////////////////////////////////////////////////////
// 에러 찾기 문제이므로, 해당 소스 코드는 실행할 수 없음 //
///////////////////////////////////////////////////////

using System;

namespace ch4_6 {
    class Dummy {
        const int MIN = MAX - 100;   // 상수 MAX가 정의되지 않았으므로, MAX를 참조할 수 없음.
        const int MAX = MIN + 100;
        public static readonly int NORMAL;
        public int instanceVariable;
        static int staticVariable;
    }

    class Program {
        static void Main() {
            Dummy d = new Dummy();
            Dummy.NORMAL = 5;               // 읽기 전용 필드이므로 값 변경 불가
            d.staticVariable = 10;          // 정적 변수는 클래스 Dummy를 참조하여야 함
            Dummy.instanceVariable = 10;    // 인스턴스 변수는 객체 d를 참조하여야 함
            Dummy.staticVariable = 10;      // 접근 지정자가 private(생략)이므로 접근 불가
        }
    }
}
