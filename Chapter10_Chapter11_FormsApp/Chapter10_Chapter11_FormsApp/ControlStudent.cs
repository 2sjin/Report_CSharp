using System;
using System.Collections.Generic;
using System.IO;

namespace Chapter10_Chapter11_FormsApp {
    class ControlStudent {
        List<Student> stdList = new List<Student>();

        static string FILE_NAME = "data.csv";
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;

        // 학생 정보를 학생 리스트에 추가
        public void AddStudentToList(string id, string name, string email) {
            stdList.Add(new Student(id, name, email));
        }

        // 학생 리스트 초기화
        public void ClearList() {
            stdList.Clear();
        }

        // 학생 정보를 파일로부터 불러온 후, 문자열 리스트에 저장하여 리턴함
        public List<string[]> LoadFromFile() {
            List<string[]> strList = new List<string[]>();
            try {
                fs = File.OpenRead(FILE_NAME);
                sr = new StreamReader(fs);      // 바이트 스트림을 문자 스트림으로 변환

                // 파일이 존재하지 않으면 리턴
                if (File.Exists(FILE_NAME) == false)
                    return null;

                // 파일의 끝을 만날 때까지 한 줄씩 읽기
                stdList.Clear();
                while (sr.EndOfStream == false) {
                    string data = sr.ReadLine();
                    if (data == null)
                        break;
                    string[] sitems = data.Split(',');
                    stdList.Add(new Student(sitems[0], sitems[1], sitems[2]));
                }
            } catch(Exception e) {
                return null;
            } finally {
                sr.Close();
                fs.Close();
            }

            foreach (Student std in stdList) {
                string[] tempStd = { std.Id, std.Name, std.Email };
                strList.Add(tempStd);
            }
            return strList;
        }

        // 학생 정보를 파일에 저장
        public bool SaveToFile() {
            try {
                fs = File.Create(FILE_NAME);
                sw = new StreamWriter(fs);

                foreach (Student std in stdList)
                    sw.WriteLine("{0},{1},{2}", std.Id, std.Name, std.Email);
            } catch (Exception e) {
                return false;
            } finally {
                sw.Close();
                fs.Close();
            }
            return true;
        }
    }
}
