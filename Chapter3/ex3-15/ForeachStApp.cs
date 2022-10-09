using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_15 {
    internal class ForeachStApp {
        static void Main(string[] args) {
            string[] color = { "red", "green", "blue" };
            foreach (string s in color)     // Python에서는 for s in color:
                Console.WriteLine(s);
        }
    }
}
