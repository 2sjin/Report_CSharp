using System;

namespace ex6_4 {
    // SystemException의 서브클래스 타입만 형 매개변수 T에 전달 가능함
    class GenericType<T> where T : SystemException {
        private T value;
        public GenericType(T v) {
            value = v;
        }

        override public string ToString() {
            return "Type is " + value.GetType();
        }
    }

    public class BoundedGenericApp {
        static void Main(string[] args) {
            GenericType<NullReferenceException> gNullEx = new GenericType<NullReferenceException>(new NullReferenceException());
            GenericType<IndexOutOfRangeException> gIndexEx = new GenericType<IndexOutOfRangeException>(new IndexOutOfRangeException());

            // String 타입은 SystemException의 서브클래스 타입이 아니므로 에러 발생
            // GenericType<String> gString = new GenericType<String>("Error");

            Console.WriteLine(gNullEx.ToString());
            Console.WriteLine(gIndexEx.ToString());
        }
    }
}
