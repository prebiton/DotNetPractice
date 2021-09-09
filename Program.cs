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
            // if example
            int i = 10, j = 20;

            if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }

            // ternary operator

            int x = 20, y = 10;

            var result = x > y ? "x is greater than y" : "x is less than y";

            Console.WriteLine(result);

            // switch

            x = 5;

            switch (x)
            {
                case 1:
                    Console.WriteLine("x = 1");
                    break;
                case 2:
                    Console.WriteLine("x = 2");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("x = 4 or x = 5");
                    break;
                default:
                    Console.WriteLine("x > 5");
                    break;
            }

            Program p1 = new Program();
            p1.paint(20);
        }
    }
}
