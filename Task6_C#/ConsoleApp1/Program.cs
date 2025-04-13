using System;
using System.Text;
using System.Diagnostics;
namespace ConsoleApp1 {
    class Program {
        public static void Main(string[] args) {
            /* Part 01 */

            #region Problem
            //Point point = new Point(1, 5);
            //Console.WriteLine(point);
            #endregion

            #region Question
            /*
            
            (1) Value Type Semantics: A struct is a value type, and when a struct is passed around, it is copied. Allowing inheritance would break the intended behavior of value types, potentially introducing ambiguity in how inheritance should work with the copying mechanism.

            (2) Memory Efficiency: Inheritance typically requires additional memory to manage base class references and related structures. Since structs are designed to be lightweight and memory-efficient, introducing inheritance would go against their core purpose, leading to unnecessary overhead.

            (3) Immutability and Inheritance Conflict: structs are typically designed to be immutable. Allowing inheritance would create conflicts between immutability and the need to change or extend a type through inheritance.

            (4) Inheritance Complexity: The C# design philosophy separates structs and classes, ensuring that structs remain simple and efficient, while classes can handle more complex inheritance scenarios.

             */
            #endregion

            #region Problem
            //TypeA typeA = new TypeA();
            //Console.WriteLine(typeA.G);
            //Console.WriteLine(typeA.H);
            //typeA.PrintPrivateField();
            #endregion

            #region Question
            /*
            
            (1) Public provides the widest visibility and access.

            (2) Private offers the narrowest visibility, ensuring encapsulation.

            (3) Protected allows access within the class and by derived classes.

            (4) Internal restricts access to within the same assembly.

            (5) Protected Internal combines protected and internal, allowing access from derived classes and within the same assembly.

            (6) Private Protected provides access only to the class and derived classes within the same assembly.

             */
            #endregion

            #region Problem
            //Employee employee = new Employee();
            //employee.EmpId = 1;
            //employee.Salary = 15.5m;
            //employee.Name = "shady";
            //employee.GetName();
            #endregion

            #region Question
            /*
            
            Encapsulation is critical because it promotes data security, modularity, flexibility, ease of maintenance, and reusability in software design.
            It helps in creating software systems that are more robust, maintainable, and easier to modify and extend over time, making it a cornerstone of good object-oriented design.
             
             */
            #endregion

            #region Problem
            //Point2 point = new Point2(5);
            //point.Print();

            //Point2 point2 = new Point2(1, 2);
            //point2.Print();
            #endregion

            #region Question
            /*
            
            (1) Parameterless Constructor:

                1- A parameterless constructor (one without parameters) is automatically provided by the compiler for a struct if you don't define one. This constructor initializes all the struct fields to their default values (e.g., 0 for numeric types, false for boolean, null for reference types).

                2- You cannot define a parameterless constructor manually in structs. If you define any constructor, you must provide the parameters for it.

            (2) Parameterized Constructor:

                You can define parameterized constructors to allow setting specific values when the struct is instantiated. These constructors must be explicitly defined, and you can initialize one or more fields with values provided during the struct's creation.

            (3) No Default Constructor:

                Unlike classes, structs do not allow you to define a default constructor (one that takes no arguments) manually. However, a default parameterless constructor is automatically provided by the C# compiler to initialize fields with their default values.

            (4) Initialization:

                When you create a struct instance, constructors can be used to initialize the fields with values other than their default values.

             */
            #endregion

            #region Problem
            //Employee2 employee = new Employee2();
            //Point3 point = new Point3();

            //employee.Id = 1;
            //employee.Name = "Mohamed";
            //employee.Salary = 2500m;

            //point.X = 1;
            //point.Y = 2;

            //Console.WriteLine("Before passing to method :-");
            //Console.WriteLine(employee);
            //Console.WriteLine(point);

            //Edit(employee, point);

            //Console.WriteLine("\nAfter passing to method :-");
            //Console.WriteLine(employee);
            //Console.WriteLine(point);
            #endregion

            #region Question
            /*
            
            (1) Structs are value types and are stored in the stack, leading to fast allocation and automatic memory release when they go out of scope.

            (2) Classes are reference types and are stored in the heap, leading to flexibility but requiring garbage collection for memory management.

             */
            #endregion

            /* Part 02 */

            #region Q1
            /*
            
            Copy constructor is a useful tool for duplicating an object in C#.
            It ensures that a new instance is created with the same data as an existing object, preventing the accidental sharing of references, especially in cases involving complex data structures or objects.

             */
            #endregion

            #region Q2
            /*
            
            Indexer in C# is a special type of property that allows an object to be accessed using array-like syntax.
            An indexer allows instances of a class or struct to be indexed in a similar way to arrays.

            Indexers are used in scenarios like:-

                (1) Custom Collection Classes: When creating a custom collection, an indexer allows clients of your class to access data in a familiar way, just like working with arrays or lists.

                (2) Matrix-like Data Structures: When building objects that represent multi-dimensional data (like grids, tables, etc.), indexers allow easy access to elements based on their positions.

                (3) Simplifying Access: For any object where you want to provide indexed access to internal data, indexers can simplify the code for the user.

             */
            #endregion
        }

        public static void Edit(Employee2 emp, Point3 point) {
            emp.Id = 2;
            emp.Salary = 3000.5m;
            emp.Name = "Shady";

            point.X = 10;
            point.Y = 20;
        }
    }

    struct Point {
        private int x;
        private int y;

        public Point() { }
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public override string ToString() {
            return $"({x}, {y})";
        }
    }

    class TypeA {
        private int f;
        internal int G;
        public int H;

        public TypeA() {
            f = 1;
            G = 2;
            H = 3;
        }
        public void PrintPrivateField() {
            Console.WriteLine(f);
        }
    }

    struct Employee {
        private int empId;
        private decimal salary;
        private string name;

        public int EmpId { get { return empId; } set { empId = value; } }
        public decimal Salary { get { return salary; } set { salary = value; } }
        public string Name { get { return name; } set { name = value; } }

        public void GetName() {
            Console.WriteLine(name);
        }
        public void SetName(string name) {
            this.name = name;
        }
    }

    struct Point2 {
        private int x;
        private int y;

        public Point2(int x) {
            this.x = x;
            y = 0;
        }
        public Point2(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public void Print() {
            Console.WriteLine($"({x}, {y})");
        }
    }

    class Employee2 {
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public string Name { get; set; }

        public override string ToString() {
            return $"{{{Id}, {Salary}, {Name}}}";
        }
    }
    
    struct Point3 {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString() {
            return $"{{{X} {Y}}}";
        }
    }
}