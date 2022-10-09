using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_23 {
    internal class FormattedOutputApp {
        static void Main(string[] args) {
            // 자릿수의 폭 지정('-'는 좌측정렬)
            Console.WriteLine("0,-5\t[{0,-5}]", 1.2);
            Console.WriteLine("0,-5\t[{0,5}]", 1.2);
            Console.WriteLine("0,-5\t[{0,5}]", 123.45);

            Console.WriteLine();

            double d = Math.PI;
            Console.WriteLine("0\t{0}", d);         
            Console.WriteLine("0:C\t{0:C}", d);       // 통화 표시
            Console.WriteLine("0:E\t{0:E}", d);       // 지수 형태
            Console.WriteLine("0:F\t{0:F}", d);      // 고정 소수점
            Console.WriteLine("0:F5\t{0:F5}", d);      // 고정 소수점(자릿수 지정)
            Console.WriteLine("0:G\t{0:G}", d);       // 고정 소수점 또는 지수 형태 중 간략한 형태 선택
            Console.WriteLine("0:P\t{0:P}", d);       // 백분율('%' 기호 포함)
            Console.WriteLine("0:R\t{0:R}", d);       // 결과 스트링을 다시 읽었을 떼, 원 값과 동일함을 보장(부동소수점 수만 가능)
            Console.WriteLine("0:X\t{0:X}", 255);     // 정수 16진수

            // 10진수에 자릿수 구분 기호 ',' 포함
            Console.WriteLine("0:N\t{0:N}", 12345678);       
        }
    }
}
