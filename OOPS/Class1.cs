using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Calculator
    {
        public int num1, num2;

        public Calculator(int v1, int v2)
        {
            num1 = v1;
            num2 = v2;
        }

        public static Calculator operator -( Calculator c1)
        {
            c1.num1 = -c1.num1;
            c1.num2 = -c1.num2;
            return c1;
        }
        public void print()
        {
            Console.WriteLine(num1.ToString()+", "+ num2.ToString());
        }
    }

    class OperatorOverload
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(15, -25);
            calc = -calc;
            calc.print();
        }
    }

    class Class1
    {
        public static void Main(string[] args)
        {
            //OutDemo();
            //RefDemo();
        }

        private static void RefDemo()
        {
            string str1 = "John";
            SetValue(ref str1);
            Console.WriteLine(str1);
        }

        private static void SetValue(ref string str1)
        {
            str1 = "Smith"; //only locally without ref
        }

        private static void OutDemo()
        {
            int result;
            bool returnedValue = Add(25, out result); // returns 2 values
            Console.WriteLine(result);
        }

        public static bool Add(int a, out int b)
        {
            // a = 20;
            b = a + a;
            return true;
        }
    }
}
