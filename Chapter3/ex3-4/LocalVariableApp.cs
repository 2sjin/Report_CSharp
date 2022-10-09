using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_4 {
    internal class LocalVariableApp {
        static int x;  // static 없애면 오류 발생(non-static 필드는 객체 생성 필요)

        static void Main(string[] args) {
            int x = (LocalVariableApp.x = 2) * 2;
            Console.WriteLine("static x = " + LocalVariableApp.x);
            Console.WriteLine("local x = " + x);
        }
    }
}
