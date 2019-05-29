using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpprinting
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            double y = 3.00;
            bool z = false;
            Console.WriteLine("we have {0}, {1}, and {2}", x, y, z);
            Console.WriteLine("\n please enter an integer:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} was chosen. ", a);
            Console.ReadLine();
        }
    }
}
