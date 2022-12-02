using System;

namespace ex6_1 {
    class SimpleGeneric<T> {
        private T[] values;
        private int index;

        // 생성자
        public SimpleGeneric(int len) {
            values = new T[len];
            index = 0;
        }

        public void Add(params T[] args) {
            foreach (T e in args) {
                values[index++] = e;
            }
        }

        public void Print() {
            foreach (T e in values)
                Console.Write(e + " ");
            Console.WriteLine();
        }
    }

    public class GenericClassApp {
        static void Main(string[] args) {
            SimpleGeneric<Int32> gInteger = new SimpleGeneric<Int32>(10);
            gInteger.Add(1, 2);
            gInteger.Add(1, 2, 3, 4, 5, 6, 7);
            gInteger.Add(0);
            gInteger.Print();

            SimpleGeneric<Double> gDouble = new SimpleGeneric<Double>(10);
            gDouble.Add(10.1, 20.0, 30.0);
            gDouble.Add(36.5);
            gDouble.Print();

            SimpleGeneric<String> gString = new SimpleGeneric<String>(10);
            gString.Add("C++", "C#", "자바(Java)");
            gString.Add("파이썬(Python)");
            gString.Print();
        }
    }
}
