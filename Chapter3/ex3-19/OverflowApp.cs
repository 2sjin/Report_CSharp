using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_19 {
    internal class OverflowApp {
        static void Main(string[] args) {
            int i = 0;
            int max = int.MaxValue;  // (2^31)-1

            try {
                i = max + 1;
                Console.WriteLine("오버플로 검사하지 않음  \t" + i);

                unchecked {
                    i = max + 1;
                }
                Console.WriteLine("unchecked 문장 실행 완료\t" + i);

                checked {
                    i = max + 1;
                }
                Console.WriteLine("checked 문장 실행 완료\t" + i);
            }
            catch (OverflowException e) {
                Console.WriteLine("오버플로 예외 발생\t\t" + i);
            }
        }
    }
}
