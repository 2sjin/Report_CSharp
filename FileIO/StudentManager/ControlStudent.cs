using System;
using System.IO;

namespace StudentManager {
    class ControlStudent {
        public Student Std { get; set; }

        public ControlStudent() {
            Std = new Student();
        }

        public void FileInput(string name, int id, string phone) {
            FileStream file = new FileStream("std.txt", FileMode.OpenOrCreate);     // 파일이 있으면 열고, 없으면 생성
            StreamWriter sr = new StreamWriter(file, System.Text.Encoding.Default);
            sr.BaseStream.Seek(0, SeekOrigin.End);      // 스트림의 맨 끝부분 찾기
            sr.Write(name + " " + id + " " + phone);    // 파일 쓰기
            sr.WriteLine();     // 파일 쓰기(개행문자 포함)
            sr.Close();
        }

        public string FileOutput() {
            string txt = "";
            FileStream file = new FileStream("std.txt", FileMode.OpenOrCreate);     // 파일이 있으면 열고, 없으면 생성
            StreamReader sr = new StreamReader(file, System.Text.Encoding.Default);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);    // 스트림의 맨 첫부분 찾기
            while (sr.Peek() > -1)      // 읽을 데이터가 있을 경우(읽을 데이터가 없으면 -1 반환됨)
                txt += sr.ReadLine() + "\n";    // 파일 읽기(한 줄 단위)
            sr.Close();
            return txt;
        }
    }
}
