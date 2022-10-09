using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_17 {
    class Vector {
        private int[] v;

        // 생성자
        public Vector(int size) {
            v = new int[size];
        }

        // 인덱서
        public int this[int index] {
            get { return v[index]; }
            set { v[index] = value; }
        }

        // 연산자 중복(++): 모든 원소 1씩 증가
        static public Vector operator ++(Vector vector) {
            Console.WriteLine("클래스 Vector의 ++ 연산자가 호출됨");
            for (int i = 0; i < vector.v.Length; i++)
                vector[i]++;
            return vector;
        }

        // 연산자 중복(--): 모든 원소 1씩 감소
        static public Vector operator --(Vector vector) {
            Console.WriteLine("클래스 Vector의 -- 연산자가 호출됨");
            for (int i = 0; i < vector.v.Length; i++)
                vector[i]--;
            return vector;
        }

    }

    class Program {
        static int VECTOR_SIZE = 5;

        // 벡터 출력 메소드
        static void PrintVector(Vector vector) {
            for (int i = 0; i < VECTOR_SIZE; i++)
                Console.Write(vector[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args) {
            // 벡터 객체 생성
            Vector vector = new Vector(VECTOR_SIZE);

            // 벡터 초기화
            for (int i = 0; i < VECTOR_SIZE; i++)
                vector[i] = 10 + i;

            PrintVector(vector);    // 벡터 출력
            vector++;   // 벡터 ++ 연산 수행
            PrintVector(vector);    // 벡터 출력
            vector--;   // 벡터 -- 연산 수행
            PrintVector(vector);    // 벡터 출력
        }
    }
}
