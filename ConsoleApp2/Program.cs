using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public string Name { get; set; }
    }
    class Program
    {
        // Function for painting

        void Paint(int stars)
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
            //takeInputFromConsole();
           // ArrayDemo();

            string = null;
            int result;
            bool ifSuccess = int.TryParse(ValueType, out result);
            // initializing variables

            int num = 100;
            float rate = 10.2f;
            decimal amount = 100.50M;
            char code = 'C';
            bool isValid = true;
            string name = "Steve";

            Console.WriteLine(num);
            Console.WriteLine(rate);
            Console.WriteLine(amount);
            Console.WriteLine(code);
            Console.WriteLine(isValid);
            Console.WriteLine(name);

            // Class method

            MyCar c1 = new MyCar();
            c1.Seats = 4;
            Console.WriteLine($"No. of seats = {c1.Seats}");


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

            // Calling Paint function

            Program p1 = new Program();
            p1.Paint(20);

            // Integer types

            byte b1 = 25;
            sbyte b2 = 25;
            // b2 = b1 as sbyte
            Console.WriteLine(typeof(byte));
            Object obj = new Object();
            User u1 = new User();
            obj = u1;
            int i1 = b1; // implicit type casting
            dynamic Data = 10;
            Console.WriteLine(Data is string);
            Data = "word"; // dynamic type
            Console.WriteLine(Data is string);
            Console.WriteLine(typeof(User));

            var names = "Welcome";
            var a = 34;
            Console.WriteLine("name={0} a={1}", names, a);

            const int months = 12, weeks = 52, days = 365; // read only

            int x1 = 2;
            double y1 = 12.2;
            double z1;
            z1 = x1 + y1; // implicit conversion - no loss
            Console.WriteLine(z1);



        }

        private static void takeInputFromConsole()
        {
            string input = Console.ReadLine();
            Console.WriteLine(input);
        }

        private static void ArrayDemo()
        {
            int[] array = { 1, 2, 4, 5, 6 };
            var a = from i in array where i % 2 == 0 select i;
            foreach(var _a in a)
            {
                Console.WriteLine("{0}\n", _a);

            }
            //Console.Read();
        }
    }
}