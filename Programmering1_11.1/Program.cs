using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_11._1 {
    class Program {
        static void Main(string[] args) {
            Hello("test");
        }

        static string Hello(string fromMain) {
            string myMethod = "Hey ho lets go" + fromMain;
            return myMethod;
        }
    }
}
