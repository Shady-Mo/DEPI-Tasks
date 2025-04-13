using System;
using System.Text;
using System.Diagnostics;
namespace ConsoleApp1 {
    class Program {
        public static void Main(string[] args) {
            /* Part 01 */

            #region Problem
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //try {
            //    int result = x / y;
            //    Console.WriteLine(result);
            //}
            //catch(DivideByZeroException ex) {
            //    Console.WriteLine(ex.Message);
            //}
            //finally {
            //    Console.WriteLine("Operation complete");
            //}
            #endregion

            #region Question
            /*
            
            The finally block is crucial for cleanup actions that must be performed regardless of the outcome of the code in the try block, ensuring that no resources are left hanging or locked.
            Its use leads to more robust and reliable code by safeguarding against unintended resource retention.

             */
            #endregion

            #region Problem
            //int x, y;
            //do
            //    Console.WriteLine("enter first number :");
            //while (!int.TryParse(Console.ReadLine(), out x) || x < 0);
            //do
            //    Console.WriteLine("enter second number :");
            //while (!int.TryParse(Console.ReadLine(), out y) || y < 1);
            #endregion

            #region Question
            /*
            
            int.TryParse() is preferred when the input might not be a valid integer or when performance and error handling are concerns.
            It allows for cleaner, safer, and potentially faster code by handling parsing failures gracefully without exceptions.
            This method is especially useful in user-input scenarios where there's a high likelihood of encountering non-numeric data.

             */
            #endregion

            #region Problem
            //int? x = null;
            //x ??= 0;

            //if (x.HasValue) {
            //    Console.WriteLine(x.Value);
            //}
            //else {
            //    Console.WriteLine("x not has a value");
            //}
            #endregion

            #region Question
            /*
            
            The InvalidOperationException serves as a protective mechanism in C# to prevent runtime errors that could occur from assuming a non-existent value exists in a nullable variable. It enforces the safe use of nullable types by explicitly requiring checks for the presence of a value (using HasValue) before accessing Value.

             */
            #endregion

            #region Problem
            //int[] arr = new int[5];

            //try {
            //    Console.WriteLine(arr[10]);
            //}
            //catch(IndexOutOfRangeException ex) {
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Question
            /*
            
            checking array bounds before accessing elements is a fundamental safety measure in programming that prevents errors, protects data integrity, ensures security, and contributes to overall application robustness.

             */
            #endregion

            #region Problem
            //int[,] arr = new int[3, 3] {
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};
            //int sum = 0;
            //for (int i = 0; i < arr.GetLength(0); i++) {
            //    for (int j = 0; j < arr.GetLength(1); j++) {
            //        sum += arr[i, j];
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Question
            /*
            
            (1) Flexibility: GetLength allows developers to write more flexible code that can handle arrays of varying sizes without hardcoding array dimensions.

            (2) Safety: Using GetLength to control loop bounds helps prevent IndexOutOfRangeException by ensuring that indices used in loops are valid.

            (3) Clarity: It clearly indicates which dimension's length is being accessed, improving code readability, especially in complex operations involving multi-dimensional data structures.

             */
            #endregion

            #region Problem
            //int[][] arr = new int[][] {
            //    new int[3],
            //    new int[5],
            //    new int[6]
            //};

            //for (int i = 0; i < arr.GetLength(0); i++) {
            //    for (int j = 0; j < arr[i].Length; j++) {
            //        arr[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < arr.GetLength(0); i++) {
            //    for (int j = 0; j < arr[i].Length; j++) {
            //        Console.Write(arr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Question
            /*
            
            (1) Jagged array: the memory for each sub-array is allocated separately. This means when you initialize a jagged array, you allocate memory for the array of references first, and each reference points to another independently allocated array in memory.

            (2) Rectangular array: The memory for a rectangular array is allocated as a single contiguous block. This simplifies memory management and can improve access speed due to locality of reference and fewer pointer dereferences (only one is needed to access any element).

             */
            #endregion

            #region Problem
            //string? s;

            //s = Console.ReadLine();

            //if (s != null) {
            //    Console.WriteLine(s);
            //}
            //else {
            //    Console.WriteLine("Null value");
            //}
            #endregion

            #region Question
            /*
            
            (1) Improved Code Safety: By explicitly indicating which variables may or may not hold null values, developers can write safer code that is less prone to errors at runtime. This makes it easier to catch potential null dereferences during compile time.

            (2) Better Communication: The syntax for nullable reference types allows developers to clearly document their intent regarding whether or not a variable should be able to contain null. This improves the readability of the code and the communication of its design, making it clearer to other developers who work on the same codebase.

            (3) Easier Maintenance: Code that handles null values explicitly is generally easier to maintain because the flow of nulls through the code is more predictable and controlled. This can lead to fewer bugs related to null values as the application evolves.

            (4) Tooling and Compiler Support: The C# compiler uses static flow analysis to check for possible null reference dereferences and provides warnings during development, helping developers address potential issues proactively rather than dealing with them after deployment. 
             
             */
            #endregion

            #region Problem
            //int x = 5;
            //object obj = x;

            //try {
            //    char c = (char) obj;
            //    Console.WriteLine(c);
            //}
            //catch(InvalidCastException ex) {
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Question
            /*
            
            (1) Performance Overhead of Boxing:-
                
                1- Memory Allocation: Boxing a value type allocates memory on the heap rather than the stack. This allocation incurs a performance cost, especially if it occurs frequently within a tight loop or in a performance-critical path of the application.

                2- Copying Cost: When a value type is boxed, a full copy of the value is made into the newly allocated heap memory. This copying process also adds to the overhead.

            (2) Performance Overhead of Unboxing:-
                
                1- Type Checking: Unboxing requires a runtime type check. The CLR must verify that the object instance can be legitimately converted to the desired value type. This check is necessary to ensure type safety but incurs a runtime cost.

                2- Copying Cost: Similar to boxing, unboxing involves copying the data from the heap back to a stack-allocated value type. This copying process, while generally faster than allocation, still represents additional work compared to operations that do not require unboxing.

             */
            #endregion

            #region Problem
            //SumAndMultiply(out _, out _);
            #endregion

            #region Question
            /*
            
            The initialization requirement for out parameters in C# is a safety feature designed to prevent errors related to uninitialized variables and to ensure that methods fulfill their contracts regarding output parameters.
            This leads to more robust and maintainable code.

             */
            #endregion

            #region Problem
            //PrintString(s: "Hello");
            #endregion

            #region Question
            /*
            
            Requiring optional parameters to be at the end of the parameter list is a design choice made to improve code readability and maintainability, prevent ambiguous calls, and simplify the language's syntax and compiler design.
            This makes method calls predictable and the codebase easier to understand and maintain.
            
             */
            #endregion

            #region Problem
            //int?[] arr = null;

            //Console.WriteLine(arr?[0]);
            #endregion

            #region Question
            /*
            
            (1) Reduces Boilerplate: Avoids the need for repetitive null checks before accessing members or invoking methods, making the code more concise and readable.

            (2) Improves Safety: Directly addresses the common error of attempting to access members of null objects, which is a frequent source of runtime exceptions in many applications.

            (3) Easier Chain Calls: Particularly useful for chaining multiple member accesses together safely, such as person?.Manager?.Name.

             */
            #endregion

            #region Problem
            //Console.Write("Enter the day of week: ");
            //string dayOfWeek = Console.ReadLine();

            //switch(dayOfWeek) {
            //    case "Monday":
            //        Console.WriteLine(1);
            //        break;
            //    case "Tuesday":
            //        Console.WriteLine(2);
            //        break;
            //    case "Wednesday":
            //        Console.WriteLine(3);
            //        break;
            //    case "Thursday":
            //        Console.WriteLine(4);
            //        break;
            //    case "Friday":
            //        Console.WriteLine(5);
            //        break;
            //    case "Saturday":
            //        Console.WriteLine(6);
            //        break;
            //    case "Sunday":
            //        Console.WriteLine(7);
            //        break;
            //    default:
            //        Console.WriteLine("Wrong day");
            //        break;
            //}
            #endregion

            #region Question
            /*
            
            (1) Clarity and Readability: When dealing with numerous discrete values of a single variable, a switch statement can be clearer and more readable than a long series of if-else statements.

            (2) Simplicity: Switch statements can simplify code by eliminating the need for multiple if conditions, making it easier to understand at a glance.

            (3) Performance: In some languages, switch statements can be more efficient than if statements when dealing with a large number of cases, as switch might be implemented with a jump table in the backend.

            (4) Maintenance: It’s generally easier to add new conditions to a switch statement as you just need to add a new case, often without needing to adjust existing logic.

            (5) Error Prevention: Using a switch statement helps to ensure that each value is handled once and only once, which can prevent logic errors that sometimes occur with complex if-else chains where conditions might overlap.

             */
            #endregion

            #region Problem
            //Console.WriteLine(SumArray(1, 2, 3, 4, 5));

            //Console.WriteLine(SumArray(new int[] { 1, 2, 3, 4, 5 }));
            #endregion

            #region Question
            /*
            
            (1) Single params per Method: Only one params keyword is allowed per method, and it must be the last parameter in the method's parameter list.

            (2) Only Last Parameter: Since params must be the last parameter, you cannot follow it with additional parameters. This restriction can limit the method's flexibility in requiring a mix of fixed and variable parameters.

            (3) Type Restriction: All elements passed to the params parameter must be of the same type, or be implicitly convertible to the type declared in the params array.

            (4) Overload Ambiguity: Methods that are overloaded and include a version with a params parameter can lead to ambiguity in method selection at compile time, which can complicate the use of such methods.

            (5) Performance Consideration: Using params can create a new array each time the method is called, which might not be efficient, especially in high-performance scenarios or in tight loops.

            (6) Default Values: You cannot use params with ref or out keywords. Also, methods with params do not support passing arguments by named parameters in a way that skips the params array.

             */
            #endregion

            /* Part 02 */

            #region Q1
            //int end = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= end; i++) {
            //    Console.Write(i + (i < end ? ", " : ""));
            //}
            #endregion

            #region Q2
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++) {
            //    Console.Write(num * i + (i < 12 ? ", " : ""));
            //}
            #endregion

            #region Q3
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= num; i += 2) {
            //    Console.Write(i + (i < num - 1 ? ", " : ""));
            //}
            #endregion

            #region Q4
            //int x = int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine());
            //Console.WriteLine(Math.Pow(x, y));
            #endregion

            #region Q5
            //string s = Console.ReadLine();
            //s.Reverse().ToList().ForEach(x => Console.Write(x));
            #endregion

            #region Q6
            //List<int> list = Console.ReadLine().ToCharArray().Select(x => Convert.ToInt32(x - '0')).ToList();
            //list.Reverse();
            //foreach (var item in list) {
            //    Console.Write(item);
            //}
            #endregion

            #region Q7
            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Dictionary<int, int> dict = new Dictionary<int, int>();
            //int ans = 0;
            //for (int i = 0; i < arr.Length; i++) {
            //    if (dict.ContainsKey(arr[i])) {
            //        ans = Math.Max(ans, i - dict[arr[i]]);
            //    }
            //    else dict.Add(arr[i], i);
            //}
            //Console.WriteLine(ans);
            #endregion

            #region Q8
            string[] arr = Console.ReadLine().Split();
            Array.Reverse(arr);
            foreach (var item in arr) {
                Console.Write(item + " ");
            }
            #endregion
        }

        public static void SumAndMultiply(out int num1, out int num2) {
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2, mul = num1 * num2;
            Console.WriteLine(sum);
            Console.WriteLine(mul);
        }

        public static void PrintString(string s, int op = 5) {
            for (int i = 0; i < op; i++) {
                Console.WriteLine(s);
            }
        }

        public static int SumArray(params int[] arr) {
            int sum = 0;
            foreach (var item in arr) {
                sum += item;
            }
            return sum;
        }
    }
}