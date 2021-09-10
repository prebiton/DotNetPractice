using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Add(x, y);
        }

        private static void Add(int x, int y)
        {
            Console.WriteLine("Sum = {0}", x + y);
        }
    }
}
