using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_2 {
    public class StaticVsInstanceApp {
        public int instanceNum;
        public static int staticNum;
    }

    class Program {
        static void Main(string[] args) {
            StaticVsInstanceApp obj = new StaticVsInstanceApp();

            obj.instanceNum = 10;
            // app.staticNum = 10;

            // StaticVsInstanceApp.instanceNum = 20;
            StaticVsInstanceApp.staticNum = 20;

            Console.WriteLine("object Number={0}, static Number={1}",
                                obj.instanceNum, StaticVsInstanceApp.staticNum);
        }
    }
}
