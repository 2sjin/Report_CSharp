using System;
using System.IO;

namespace FileStreamReadTest {
    internal class FileStreamReadTest {
        static StreamReader sr = null;

        static void Main(string[] args) {
            Console.WriteLine("1. 프로그램 시작");
            Console.WriteLine("\n2. 파일스트림 생성");

            Console.WriteLine("  - 파일 열기 및 파일 입력 바이트스트림을 문자스트림으로 변환");
            try {
                // FileStream과 StreamReader를 함께 사용
                sr = new StreamReader(new FileStream("Hello.cs", FileMode.Open));
            } catch (FileNotFoundException e) {
                Console.WriteLine("\n[파일 열기 실패]");
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("  - 파일 포인터(get pointer)를 파일의 처음으로 이동");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            Console.WriteLine("\n3. 파일 읽어와서 화면에 출력하기");

            // 파일 포인터가 스트림의 끝에 도달하지 않으면, 파일에서 다음 한 줄을 읽어옴
            Console.WriteLine("\n========================================================");
            Console.WriteLine("\n▶ Hello.cs\n");
            // while (sr.Peek() > -1)
            while (sr.EndOfStream == false)
                Console.WriteLine(sr.ReadLine());
            Console.WriteLine("\n========================================================");

            Console.WriteLine("  - 스트림 읽기 종료");
            sr.Close();
            Console.WriteLine("\n4. 프로그램 종료");
        }
    }
}
