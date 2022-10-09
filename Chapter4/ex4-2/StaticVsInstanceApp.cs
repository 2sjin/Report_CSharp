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
            StaticVsInstanceApp instance = new StaticVsInstanceApp();

            instance.instanceNum = 10;
            // instance.staticNum = 10;

            // StaticVsInstanceApp.instanceNum = 20;
            StaticVsInstanceApp.staticNum = 20;

            Console.WriteLine("instance Number={0}, static Number={1}",
                                instance.instanceNum, StaticVsInstanceApp.staticNum);
        }
    }
}
