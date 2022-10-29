using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_1 {
    internal class IdentifierApp {
        static void Main(string[] args) {
            int MyVar = 1;
            int myVar = 2;
            int @int = 10;      // 지정어 int 앞에 @ 기호를 붙여 변수명으로 사용   
            int 변수 = 20;
            // int @변수 = 20;    // 일반 변수명일 경우, '변수'와 '@변수'는 같은 명칭(함께 선언 불가)

            Console.WriteLine("MyVar = " + MyVar);
            Console.WriteLine("myVar = " + myVar);
            Console.WriteLine("@int = " + @int);
            Console.WriteLine("변수 = " + 변수);
            Console.WriteLine("@변수 = " + @변수);
        }
    }
}
