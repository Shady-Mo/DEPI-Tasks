using System;
using System.Text;
namespace ConsoleApp1 {
    class Program {
        public static void Main(string[] args) {
            /* Part 01 */

            #region Problem
            //string s = Console.ReadLine();

            //try {
            //    int x = int.Parse(s);
            //    int y = Convert.ToInt32(s);
            //}
            //catch (FormatException) {
            //    Console.WriteLine("Input was not in a correct format. Please enter a number.");
            //}
            //catch (OverflowException) {
            //    Console.WriteLine("Input is too large or too small for an Int32. Please enter a valid number.");
            //}
            //catch (ArgumentNullException) {
            //    Console.WriteLine("No input was provided. Please enter a number.");
            //}
            #endregion

            #region Question
            /*
             
            (1) int.Parse: It throws an ArgumentNullException if the input is null, as it expects a valid string input and cannot handle null values.

            (2) Convert.ToInt32: It returns 0 when the input is null, providing a more forgiving approach to null handling by treating null as equivalent to zero.

             */
            #endregion

            #region Problem
            //if (int.TryParse(Console.ReadLine(), out int x)) {
            //    Console.WriteLine(x);
            //}
            //else {
            //    Console.WriteLine("Error Message");
            //}
            #endregion

            #region Question
            /*
             
            (1) Exception Handling: TryParse does not throw an exception if the conversion fails. Instead, it returns a boolean value indicating whether the parsing was successful or not. This is more efficient than handling exceptions, which can be computationally expensive.

            (2) Safety and Robustness: Using TryParse helps ensure the application remains stable and responsive even when users input invalid data. It allows the application to gracefully handle errors without crashing.

            (3) User Feedback: Since TryParse can check if the input is valid without throwing an exception, it's easier to provide immediate feedback to users about incorrect input and prompt them to correct it.

             */
            #endregion

            #region Problem
            //object obj = 4;
            //Console.WriteLine(obj.GetHashCode());

            //obj = "Shady";
            //Console.WriteLine(obj.GetHashCode());

            //obj = 4.1;
            //Console.WriteLine(obj.GetHashCode());
            #endregion

            #region Question
            /*
            
            (1) Efficiency in Hash Tables: It allows objects to be used as keys in hash tables efficiently. The hash code is used to determine the index at which the data associated with the object is stored.

            (2) Uniqueness: While not guaranteed to be globally unique, GetHashCode() aims to return a value that minimally collides with hash codes of other objects.

            (3) Consistency: The method must return the same hash code for the same object every time it is called within a single execution of an application, provided the object does not change in ways that affect equality.

             */
            #endregion

            #region Problem
            //StringBuilder s = new StringBuilder("Hello");
            //StringBuilder t = s;

            //t.Append(" World");
            //Console.WriteLine(s);
            #endregion

            #region Question
            /*
            
            (1) Resource Management: Ensuring two references actually point to the same instance can be crucial for managing resources and state, especially in complex applications where multiple references might affect the same data.

            (2) Performance Optimization: Checking for reference equality is faster than value equality, especially for large objects. It simply compares memory addresses, avoiding potentially costly operations involved in deep value comparisons.

            (3) Identity Verification: It confirms that two variables are not just equivalent in content but are indeed the same single instance. This is vital in scenarios where the identity of an object, not just its content, matters, such as in singleton patterns or managing shared resources.

            (4) Behavior Control: In multithreaded environments, knowing that two references are identical means that any synchronization mechanism applied to one reference also protects the other, as they are the same object.

             */
            #endregion

            #region Problem
            //string s = "Hello ";
            //Console.WriteLine(s.GetHashCode());

            //s += "Hi Willy";
            //Console.WriteLine(s.GetHashCode());
            #endregion

            #region Question
            /*
            
            (1) Security: Immutability ensures that once a string is created, it cannot be changed by any operation. This predictability is crucial for security purposes, as strings often store sensitive data like file paths, URLs, or passwords, which should not be altered unexpectedly.

            (2) Synchronization: Because strings cannot change once created, they are inherently thread-safe. This means multiple threads can access the same string without risking data corruption, which is particularly important in multi-threaded applications.

            (3) Memory Efficiency: Immutable strings allow for a phenomenon called string interning. .NET can keep a single copy of each distinct literal string in a pool, reducing memory usage significantly if the same string is used multiple times in the program.

            (4) Performance: Immutable objects simplify the complexity of handling modifications. When a string is "modified," a new string is created rather than altering the original. This behavior prevents the need for creating copies to preserve original values, which can be advantageous in environments where strings are frequently accessed but rarely modified.

            (5) Hash Code Caching: Since the content of a string cannot change once it is created, its hash code can be computed and cached at the time of creation. Subsequent uses of the string can use this cached hash code directly, which speeds up dictionary lookups and other hash-based operations.

             */
            #endregion

            #region Problem
            //StringBuilder s = new StringBuilder("Hi Willy");
            //Console.WriteLine(s.GetHashCode());

            //s.Append(" Hello");
            //Console.WriteLine(s.GetHashCode());
            #endregion

            #region Question
            /*
            
            (1) Mutable Object: Unlike strings, which are immutable and require a new object to be created with every concatenation operation, StringBuilder allows modifications to the same object without creating a new one each time text is added or changed.

            (2) Memory Management: StringBuilder maintains a buffer to hold the growing string. This buffer expands as needed when new characters are added, but does so in a way that minimizes the need for frequent memory allocations. It increases its capacity in larger increments to handle additional data efficiently.

            (3) Performance: By reducing the number of memory allocations and not having to create a new string instance with every modification, StringBuilder significantly decreases the computational cost associated with string concatenation, especially noticeable when concatenating large numbers of strings or in loops.

             */
            #endregion

            #region Question
            /*
            
            (1) Mutable Nature: Unlike immutable strings that require creating a new string for every modification, StringBuilder allows direct changes to its internal character array, eliminating the need for creating new objects frequently.

            (2) Memory Efficiency: StringBuilder pre-allocates a buffer that expands as needed, reducing the frequency and overhead of memory allocations. It handles increasing its capacity intelligently by doubling the current amount, which is more efficient for large data modifications.

            (3) Reduced Copy Operations: For standard strings, each concatenation involves copying the old content to a new string along with the added content, increasing processing time with the string length. StringBuilder minimizes these copy operations by modifying the existing buffer directly.

             */
            #endregion

            #region Problem
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());

            //int sum = x + y;
            //Console.WriteLine("Sum of " + x + " + " + y + " = " + sum);
            //Console.WriteLine("Sum of {0} + {1} = {2}", x, y, sum);
            //Console.WriteLine($"Sum of {x} + {y} = {sum}");
            #endregion

            #region Question
            /*
             
            Most used is string interpolation :-

            (1) Readability: String interpolation allows the insertion of variable values directly within the string literal, making the code easier to read and understand. This is simpler than concatenation or composite formatting where variables and literals are mixed separately.

            (2) Convenience: With interpolation, developers can directly embed expressions inside string literals marked by $"...", eliminating the need for placeholder indices or additional formatting arguments.

            (3) Maintainability: It reduces errors related to argument order which can occur with composite formatting. It's straightforward to modify strings without rearranging placeholders or arguments.
             
             */
            #endregion

            /* Part 02 */

            #region Q2
            /*
            
            enum (enumeration) is a data type in C# that consists of a set of named constants called the enumerator list. It's used to assign symbolic names to a set of numeric values, increasing code readability and maintainability.
            
            Commonly Used Enums:-

            (1) DayOfWeek: Represents the days of the week (Sunday, Monday, etc.).

            (2) ConsoleColor: Specifies constants that define foreground and background colors for the console.

            (3) FileAttributes: Provides attributes for files and directories (ReadOnly, Hidden, etc.).
            
             */
            #endregion

            #region Q3
            /*
            
            string :-

            (1) Immutable Data Needs: When you need immutable string data for security and thread safety.

            (2) Small or Fixed Modifications: For simple assignments or when only a few string manipulations are required, where performance is not a critical issue.

            (3) Read-Only String Operations: When performing operations that do not require modifying the string, such as reading or displaying values.

            StringBuilder :-

            (1) Large-scale Modifications: When handling strings that require frequent and complex modifications, especially within loops.

            (2) Performance Optimization: In scenarios where performance is crucial and the string undergoes many changes, to reduce memory usage and improve execution speed.

            (3) Dynamic String Construction: In applications where strings are dynamically constructed from various sources or through user input.

             */
            #endregion
        }
    }
}