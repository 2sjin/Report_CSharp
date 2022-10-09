using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_9 {
    class MethodOverloadingApp {
        int x, y;

        /*
        void SomeThing() {
            this.x = 1;
            this.y = 1;
            Console.WriteLine("Something() is called.");
            Console.WriteLine("(x = {0}, y = {1})\n", this.x, this.y);
        }

        void SomeThing(int i) {
            this.x = i;
            this.y = 1;
            Console.WriteLine("Something(int) is called.");
            Console.WriteLine("(x = {0}, y = {1})\n", this.x, this.y);
        }

        void SomeThing(int i, int j) {
            this.x = i;
            this.y = j;
            Console.WriteLine("Something(int, int) is called.");
            Console.WriteLine("(x = {0}, y = {1})\n", this.x, this.y);
        }
        */

        // 디폴트 매개변수를 활용하여 메소드 중복을 간소화할 수 있음
        void SomeThing(int i=1, int j=1) {
            this.x = i;
            this.y = j;
            Console.WriteLine("Something(int, int) is called.");
            Console.WriteLine("(x = {0}, y = {1})\n", this.x, this.y);
        }

        void SomeThing(double d) {
            Console.WriteLine("Something(double) is called. ({0})", d);
        }

        static void Main(string[] args) {
            MethodOverloadingApp obj = new MethodOverloadingApp();
            obj.SomeThing();
            obj.SomeThing(526);
            obj.SomeThing(54, 526);
            obj.SomeThing(5.26);
        }
    }
}
