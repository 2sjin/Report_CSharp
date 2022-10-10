using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_26 {
    class Mile {
        public double distance;

        public Mile(double distance) {
            this.distance = distance;
        }

        // 묵시적 형 변환 연산자: double to Mile
        public static implicit operator Mile(double d) {
            Mile m = new Mile(d);
            Console.WriteLine("  묵시적 형 변환: double({0}) -> Mile", d);
            return m;
        }

        // 명시적 형 변환 연산자: Mile to double (to Kilometer)
        public static explicit operator KiloMeter(Mile m) {
            double d = m.distance * 1.609;
            Console.WriteLine("  명시적 형 변환: Mile -> double({0})", d);
            return d;  // double 타입 리턴 후, 묵시적 형 변환될 예정
        }
    }

    class KiloMeter {
        public double distance;

        public KiloMeter(double distance) {
            this.distance = distance;
        }

        // 묵시적 형 변환 연산자: double to Kilometer
        public static implicit operator KiloMeter(double d) {
            KiloMeter k = new KiloMeter(d);
            Console.WriteLine("  묵시적 형 변환: double({0}) -> KiloMeter", d);
            return k;
        }
        // 명시적 형 변환 연산자: Kilometer to double (to Mile)
        public static explicit operator Mile(KiloMeter k) {
            double d = k.distance / 1.609;
            Console.WriteLine("  명시적 형 변환: KiloMeter -> double({0})", d);
            return d;  // double 타입 리턴 후, 묵시적 형 변환될 예정
        }
    }

    internal class UserDefinedTypeConversionApp {
        static void Main(string[] args) {
            KiloMeter k = new KiloMeter(50.0);
            Mile m;

            k = 100.0;  // double 값인 100.0을 k에 대입할 때 Mile로 묵시적 형 변환됨
            Console.WriteLine("{0} km \n", k.distance);

            m = (Mile)k;    // double 값이 리턴되지만, m에 대입할 때 Mile로 묵시적 형 변환됨
            Console.WriteLine("{0} km = {1} mile \n", k.distance, m.distance);

            m = 65.0;   // double 값인 65.0을 m에 대입할 때 Mile로 묵시적 형 변환됨
            Console.WriteLine("{0} mile \n", m.distance);

            k = (KiloMeter)m;   // double 값이 리턴되지만, k에 대입할 때 KiloMeter로 묵시적 형 변환됨
            Console.WriteLine("{0} mile = {1} km \n", m.distance, k.distance);
        }
    }
}
