using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_25 {
    internal class IsAsOperatorApp {
        static void IsOperator(object obj) {
            Console.WriteLine(obj + " is int: " + (obj is int));
            Console.WriteLine(obj + " is string: " + (obj is string));
        }

        static void AsOperator(object obj) {
            Console.Write(obj + " as string: " + (obj as string));
            if (obj as string == null)
                Console.Write(obj + " as string == null");
            Console.WriteLine();
        }

        static void Main(string[] args) {
            IsOperator(10);
            AsOperator(10);
            IsOperator("ABC");
            AsOperator("ABC");
        }
    }
}
