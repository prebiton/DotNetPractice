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

            //Multi - dimensional array
            int[,,] arr3d1 = new int[1, 2, 2]{ { { 1, 2 }, { 3, 4 } } };

            int[,,] arr3d2 = new int[2, 2, 2]{ { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

            int[,,] arr3d3 = new int[2, 2, 3]{ { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            //Console.WriteLine(arr3d2[0, 1, 1]);

            // findall
            string[] names = { "Steve", "Bill", "James", "Mohan", "Salman", "Boski" };

            string[] findResult = Array.FindAll(names, element => element.StartsWith("B")); // return Bill, Boski

            foreach (var item in findResult)
            {
                //Console.WriteLine(item.ToString());
            }

            //count
            string[] animals = { "Cat", "Alligator", "fox", "donkey", "Cat", "alligator" };
            var totalCats = animals.Count(s => s == "Cat");
            //Console.WriteLine(totalCats);
            var animalsStartsWithA = animals.Count(s => s.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
            //Console.WriteLine(animalsStartsWithA);
            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2 };
            var totalEvenNums = nums.Count(n => n % 2 == 0);
            //Console.WriteLine(totalEvenNums);

            //union
            int[] num1 = { 1, 2, 3, 4, 3, 55, 23, 2 };
            int[] num2 = { 55, 23, 45, 50, 80 };

            var all = num1.Union(num2).ToArray();

            foreach (var item in all)
            {
                //Console.WriteLine(item.ToString());
            }

            //joining string elements
            int[] numsJoin = { 1, 2, 3, 4 };
            var str = String.Join(",", numsJoin);
            //Console.WriteLine(str);

            //removing duplicates
            int[] numsDistinct = { 1, 2, 3, 4, 3, 55, 23, 2 };
            int[] dist = numsDistinct.Distinct().ToArray();
            //Console.WriteLine(String.Join(",", dist));

            //array sorting

            int[] numbers = { 2, 1, 4, 3 };
            String[] numberNames = { "two", "one", "four", "three" };

            Array.Sort(numbers, numberNames);

            //Array.ForEach<int>(numbers, n => Console.WriteLine(n));//[1,2,3,4]
            //Array.ForEach<string>(numberNames, s => Console.WriteLine(s));//["one", "two", "three", "four"]

            //reverse
            string[] animalsReverse = { "Cat", "Alligator", "Fox", "Donkey", "Bear", "Elephant", "Goat" };

            //Array.Reverse(animalsReverse);// Result: ["Goat", "Fox", "Elephant", "Donkey", "Cat", "Bear", "Alligator"]



            //eqn x=y2+2y+1
            //repeatEquation();


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

        private static void repeatEquation()
        {
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
