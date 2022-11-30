using System.Collections.Generic;
using System.IO;

namespace Chapter10_Chapter11_FormsApp {
    class ControlStudent {
        static string FILE_NAME = "data.csv";

        List<Student> stdList = new List<Student>();

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

        // 학생 정보를 파일로부터 불러옴
        public void LoadFromFile() {
            fs = File.OpenRead(FILE_NAME);
            sr = new StreamReader(fs);      // 바이트 스트림을 문자 스트림으로 변환
            
            if (File.Exists(FILE_NAME) == false) {
                return;
            }
            while (sr.EndOfStream == false) {
                string data = sr.ReadLine();
                if (data == null)
                    break;
                string[] items = data.Split(',');
                // student.ID = items[0].ToString(), items[1].ToString(), items[2].ToString());
            }

            sr.Close();
            fs.Close();
        }

        // 학생 정보를 파일에 저장
        public void SaveToFile() {
            fs = File.Create(FILE_NAME);
            sw = new StreamWriter(fs);

            foreach (Student std in stdList)
                sw.WriteLine("{0},{1},{2}", std.Id, std.Name, std.Email);

            sw.Close();
            fs.Close();
        }
    }
}
