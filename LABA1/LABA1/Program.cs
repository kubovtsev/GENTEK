using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first,last;
            Console.WriteLine("Enter you first name");
            first = Console.ReadLine();
            Console.WriteLine("Enter you last name");
            last = Console.ReadLine();
            Console.WriteLine("Hello {0}{1}", first,last);
            Console.ReadKey();
        }
    }
}
