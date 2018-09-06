using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world.");

            Console.WriteLine("We're now on branch2");
            Console.ReadKey();
            NewMethod();
        }

        private static void NewMethod()
        {
            ClassOnSecondBrandch class2 = new ClassOnSecondBrandch();
        }
    }
}
