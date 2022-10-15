using System;

namespace ch4_8 {
    class Num {
        // 필드
        private int numerator;

        // 프로퍼티
        public int Numerator {
            get { return numerator; }
            set { numerator = value; }
        }

        // 프로터피와 동등한 기능을 수행하는 메소드: getter
        public int getNumerator() {
            return numerator;
        }

        // 프로터피와 동등한 기능을 수행하는 메소드: setter
        public void setNumerator(int numerator) {
            this.numerator = numerator;
        }
    }

    class Program {
        static void Main(string[] args) {
            Num obj = new Num();

            // 프로퍼티
            obj.Numerator = 1234;
            Console.WriteLine("obj.Numerator = " + obj.Numerator);

            // getter/setter
            obj.setNumerator(5678);
            Console.WriteLine("obj.getNumerator() = " + obj.getNumerator());
        }
    }
}
