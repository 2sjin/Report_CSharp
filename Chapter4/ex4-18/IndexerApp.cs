using System;
using System.Collections;

namespace ex4_18 {
    internal class IndexerApp {
        class Color {
            Hashtable color = new Hashtable();

            // 인덱서
            // 속성 코드 조각: indexer [tab] [tab]
            public string this[string index] {
                get { return (string)color[index]; }
                set { color[index] = value; }
            }
        }

        class Program {
            public static void Main(string[] args) {
                Color c = new Color();

                c["하양"] = "WHITE";
                c["빨강"] = "RED";
                c["노랑"] = "YELLOW";
                c["파랑"] = "BLUE";
                c["검정"] = "BLACK";

                string[] colorKor = { "검정", "노랑", "빨강", "파랑", "하양" };
                foreach (string s in colorKor)
                    Console.WriteLine(s + " = " + c[s]);
            }
        }
    }
}
