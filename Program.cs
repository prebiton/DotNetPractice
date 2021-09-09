using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        void paint(int stars)
        {
            for (int i = stars; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine(' ');
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.paint(20);
        }
    }
}
