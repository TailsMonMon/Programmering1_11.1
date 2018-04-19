using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_11._1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Hello("this is working!")); // The string is sent to the method Hello()
            Console.ReadLine();
        }

        //      A method to combine two strings 
        static string Hello(string fromMain) {
            string myMethod = "Hey ho lets go, " + fromMain;
            return myMethod;
        }
    }
}
