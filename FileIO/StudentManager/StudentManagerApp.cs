using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager {
    class StudentManagerApp {
        static ControlStudent ctrl = new ControlStudent();
        static int cmd;

        static void SelectMenu() {
            Console.WriteLine("======================");
            Console.WriteLine("1. 학생정보입력");
            Console.WriteLine("2. 학생정보출력");
            Console.WriteLine("3. 종료");
            Console.WriteLine("======================\n");

            Console.Write("메뉴 입력: ");
            cmd = int.Parse(Console.ReadLine());
        }

        static void InputStudentInfo() {
            Console.Write("성명: ");
            ctrl.Std.Name = Console.ReadLine();
            Console.Write("학번: ");
            ctrl.Std.Id = int.Parse(Console.ReadLine());
            Console.Write("핸드폰: ");
            ctrl.Std.Phone = Console.ReadLine();
        }

        static void Main(string[] args) {
            while (true) {
                SelectMenu();
                switch (cmd) {
                    case 1:
                        InputStudentInfo();
                        ctrl.FileInput(ctrl.Std.Name, ctrl.Std.Id, ctrl.Std.Phone);
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine(ctrl.FileOutput());
                        break;
                    case 3:
                        Console.WriteLine("프로그램 종료");
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
