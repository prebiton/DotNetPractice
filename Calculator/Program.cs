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
            //eqn x=y2+2y+1
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (input == "q")
                    {
                        break;
                    }
                    int x = equation(int.Parse(input));
                    Console.WriteLine("Equation result = {0}", x);
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                }
            }


            //parsing
            string val = "100.1";
            int result;
            bool ifSuccess = int.TryParse(val, out result);
            //Console.WriteLine(ifSuccess);

            //unboxing
            Object MyObj = 30;
            int i = (int)MyObj;
            //Console.WriteLine(i);
            
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //Add(x, y);
        }

        private static int equation(int y)
        {
            return (int) Math.Pow(y, 2) + 2 * y + 1;
        }

        private static void Add(int x, int y)
        {
            Console.WriteLine("Sum = {0}", x + y);
        }
    }
}
