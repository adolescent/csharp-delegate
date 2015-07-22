using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        //delegate declaration
        public delegate void printString(string s);

        //one method
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("screen " + str);
        }

        //two method
        public static void WriteToFile(string str)
        {
            Console.WriteLine("file "+str);
        }

        static void Main(string[] args)
        {
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);

            ps1("Hello World");
            ps2("Hello World");

            Console.ReadKey();
        }
    }
}

