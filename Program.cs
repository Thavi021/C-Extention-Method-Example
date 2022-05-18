using System;

namespace ExtensionMethods
{
    class Program
    {
        public void Method1()
        {
            Console.WriteLine("This is method 1 communicating");
        }
        public void Method2()
        {
            Console.WriteLine("This is method 2 communicating");
        }
        static void Main(string[] args)
        { 
            Program pr = new Program();
            pr.Method1();
            pr.Method2();
            pr.Method3();
            Console.WriteLine();

            
        }
    }
}
