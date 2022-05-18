using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
   static class Statclass
    {
        public static void Method3(this Program p)
        {
            Console.WriteLine("This is method 3");
        }
    }
}
