using System;
using System.IO;

namespace FileStreamWriteTest {
    internal class FileStreamWriteTest {
        static FileStream fs1 = null;
        static FileStream fs2 = null;
        static StreamWriter sw = null;
        static StreamReader sr = null;

        static void Main(string[] args) {
            Console.WriteLine("1. 프로그램 시작");
            String path = @"C:/sample/poet.txt";

            Console.WriteLine("\n2. 파일에 데이터 기록");
            Console.WriteLine("  - 파일 열기");
            try {
                fs1 = new FileStream(path, FileMode.Create);
            }
            catch (DirectoryNotFoundException e) {
                Console.WriteLine("\n[디렉토리 열기 실패]");
                Console.WriteLine(e.Message);
                Console.WriteLine("해결: 디렉토리를 먼저 생성한 후에 프로그램을 다시 실행하세요.");
                return;
            }

            Console.WriteLine("  - 입력 바이트스트림을 문자스트림으로 변환");
            sw = new StreamWriter(fs1, System.Text.Encoding.Default);
            Console.WriteLine("  - 파일 포인터(put pointer)를 파일의 처음으로 이동");
            sw.BaseStream.Seek(0, SeekOrigin.Begin);

            Console.WriteLine("\n========================================================");
            Console.WriteLine("\n▶ 파일에 쓸 내용 입력 (5줄)\n");
            for (int i = 0; i < 5; i++) {
                String str = Console.ReadLine();
                sw.Write(str + "\n");
            }
            Console.WriteLine("\n========================================================");

            Console.WriteLine("\n  - 버퍼 비우기");
            sw.Flush();
            Console.WriteLine("  - 스트림 쓰기 종료");
            sw.Close();

            Console.WriteLine("\n3. 파일로부터 데이터 읽기");
            Console.WriteLine("  - 파일 열기");
            try {
                fs2 = File.OpenRead(path);
            }
            catch (FileNotFoundException e) {
                Console.WriteLine("\n[파일 열기 실패]");
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("  - 파일 입력 바이트스트림을 문자스트림으로 변환");
            sr = new StreamReader(fs2, System.Text.Encoding.Default);

            Console.WriteLine("  - 파일 포인터(get pointer)를 파일의 처음으로 이동");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            Console.WriteLine("\n========================================================");
            Console.WriteLine("\n▶ " + path + "\n");
            while (sr.Peek() > -1)
                Console.WriteLine(sr.ReadLine());
            Console.WriteLine("\n========================================================");

            Console.WriteLine("\n  - 스트림 읽기 종료");
            sr.Close();
            Console.WriteLine("\n4. 프로그램 종료");
        }
    }
}
