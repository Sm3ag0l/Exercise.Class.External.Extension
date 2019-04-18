using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Class.External.Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();

            testClass.StringExtension();

            Console.ReadKey();
        }
    }
}
