using System;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

namespace Task6_CSharp
{
    internal class Program
    {
        #region Problem1
        public struct Point
        {
            public int X;
            public int Y;
            public Point()
            {
                this.X = 0;
                this.Y = 0;
            }
            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public override string ToString()
            {
                return $"(x,y) = ({X}, {Y})";
            }
        }
        //Question: Why can't a struct inherit from another struct or class in C#? 
        //Answer: 
        // A struct is a value type in C# and it cannot inherit from another 
        // struct or class. This is because C# structs already implicitly 
        // derive from System.ValueType, which itself derives from Object. 
        // Allowing structs to inherit from another struct or class would 
        // create multiple inheritance problems and unnecessary complexity. 

        #endregion

        #region Problem2
        public class TypeA
        {
            private int F;
            internal int G;
            public int H;
        }
        public static void Main(string[] args)
        {
            TypeA typeA = new TypeA();

            typeA.F = 10; // Error: private AM
            typeA.G = 20; // Accessible: internal AM
            typeA.H = 30; // Accessible: public AM
        }
        //Question: How do access modifiers impact the scope and visibility of a class member?  
        // Access modifiers control where a class member can be accessed.

        #endregion

        #region Problem3
        public struct Employee
        {
            private int EmpId;
            private string Name;
            private int Salary;

            public string GetName()
            {
                return Name;
            }
            public void SetName(string name)
            {
                this.Name = name;
            }
        }

        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.SetName("John Doe");
            Console.WriteLine(emp.GetName()); // Output: John Doe
        }
        //Question: Why is encapsulation critical in software design?  
        // Answer: 
        // Encapsulation is important because it protects the internal state 
        // of an object and prevents direct access to its data.  
        // It allows us to control how data is accessed and modified. 
        // This improves security, maintainability, data validation, 
        // and reduces unintended changes to the object's state.
        #endregion

        #region Problem4
        public struct Point01
        {
            public int x;
            public int y;
            public Point01(int x)
            {
                this.x = x;
                this.y = 0;
            }
            public Point01(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public override string ToString()
            {
                return $"(x,y) = ({x}, {y})";
            }
        }

        //test program 
        public static void Main(string[] args)
        {
            Point01 p1 = new Point01(5);
            Point01 p2 = new Point01(5,9);
           
  
            Console.WriteLine(p1.ToString()); // Output: (x,y) = (5, 0)
            Console.WriteLine(p2.ToString()); // Output: (x,y) = (5, 9)
        }
        //Question: what is constructors in structs?
        //=> It's a special method that is used to initialize the fields of a struct(attributes) when an instance of the struct is created.
        //Structs can have parameterized constructors, but they cannot have a parameterless constructor (except for the default constructor provided by C#).
        #endregion

        #region Problem5

        public struct Point
        {
            public int X;
            public int Y;
            public Point()
            {
                this.X = 0;
                this.Y = 0;
            }
            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public override string ToString()
            {
                return $"Point: X = {X}, Y = {Y}";
           
             }
        }

        //Question: How does overriding methods like ToString() improve code readability?
        // Answer: 
        //Overriding ToString() allows us to provide a meaningful 
        // string representation of an object.
        public static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(5, 15);
            Point p3 = new Point(7, 30);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
        #endregion

        #region Problem6
        public struct Point
        {
            public int X;
            public int Y;
        }

        public class Employee
        {
            public string Name;
        };
        static void ChangePoint(Point p)
        {
            p.X = 100;
            p.Y = 200;
        }

        static void ChangeEmployee(Employee e)
        {
            e.Name = "Ahmed";
        }
    public static void Main(string[] args)
    {
        Point point = new Point();
        point.X = 10;
        point.Y = 20;
        Console.WriteLine($"Before ChangePoint: X = {point.X}, Y = {point.Y}");
        ChangePoint(point);
        Console.WriteLine($"After ChangePoint: X = {point.X}, Y = {point.Y}"); // no change => value type
        Employee employee = new Employee();
        employee.Name = "John";
        Console.WriteLine($"Before ChangeEmployee: Name = {employee.Name}");
        ChangeEmployee(employee);
        Console.WriteLine($"After ChangeEmployee: Name = {employee.Name}"); //output : Ahmed, change => reference type
    }
        //Question: How does memory allocation differ for structs and classes in C#? 
        //struct acts as a value type in memory allocation => in change of the struct in a method, it does not affect the original struct outside the method
        //class acts as a reference type in memory allocation => in change of the class in a method, it affects the original class outside the method
        #endregion


        //part 2
        //What is copy constructor? 
        // A copy constructor is a constructor that creates a new object 
        // by copying the values from an existing object of the same type.
        // Example:
        // EmployeeCopy emp1 = new EmployeeCopy(1, "Rawan", 5000);
        // EmployeeCopy emp2 =  new EmployeeCopy(emp1); 
        // emp2 is a new object with the same values as emp1.

        //-----------------------------------------------

        //What is Indexer, when used, as business mention cases u have to utilize it?
        // An indexer allows an object to be accessed like an array, using an index.
        // Indexers are useful when a class represents a collection of objects or data.

        //-----------------------------------------------


        //Summarize keywords we have learnt last lecture
        //Access Modifiers: public, private, protected, internal, protected internal, private protected => in details
        //structs: value types, cannot inherit from other structs or classes, can implement interfaces, can have constructors (parameterized), cannot have destructors, cannot have default parameterless constructor
        //constructors: special methods used to initialize fields of a struct or class, can be parameterized, cannot have a parameterless constructor in structs (except default)
        // overloading: ability to define multiple methods with the same name but different parameters (number, type, or order)
        // overriding: ability to provide a new implementation of a method in a derived class that is already defined in the base class, requires the use of 'virtual' in base class and 'override' in derived class
        //encapsulation: principle of hiding the internal state and requiring all interaction to be performed through an object's methods, helps in maintaining integrity and security of data
    }
}
