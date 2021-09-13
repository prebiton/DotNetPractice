using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Shape
    {
        public double Width { get; set; }
        public double Breadth { get; set; }
    }
    class Triangle: Shape
    {
        string Type;
        static long DateOfCreation;
        
        static Triangle() // initialization
        {
            DateOfCreation = DateTime.Now.Ticks;
            Console.WriteLine(DateOfCreation);
        }

        public Triangle(double Width1, double v2): this(Width1) // parameterized constructor
        {
            Width = Width1;
            Breadth = v2;
        }
         public Triangle(double Width1):base() 
        {
            Width = Width1;
        }
        //public double Width { get; set; }
        //public double Breadth { get; set; }
    }
    class User
    {
        public string name { get; set; }  // read only
        public const int age = 10;
        public User(string name)
        {
            const int age = 100; // local constant
            //Console.WriteLine("user constructor, {0}", this.age);
            this.name = name;
        }
        public virtual void Enter()
        {
            Console.WriteLine("1");
        }
    }

    class Employee : User
    {
        public Employee(string name) : base(name)
        {
        }
        public void Enter() // overriding
        {
            Console.WriteLine("2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // BasicsOfInheritance();
            Employee e1 = new Employee("Smith");
            e1.Enter();
            Console.WriteLine(e1.name);
            User u1 = new User("John");
            u1.Enter();
        }

        private static void BasicsOfInheritance()
        {
            new Shape();
            Triangle t1 = new Triangle(12.3, 34.0); //object, reference
            Triangle t2 = t1;
            new Triangle(1, 2);
            Console.WriteLine(t1);
        }
    }
}
