using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Class.External.Extension
{
    public static class ExtensionClass
    {
        public static void StringExtension(this TestClass text)
        {
            Console.WriteLine(text);
        }
    }
}
