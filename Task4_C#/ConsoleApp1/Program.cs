using System;
using System.Text;
namespace ConsoleApp1 {
    class Program {
        public static void Main(string[] args) {
            /* Part 01 */

            #region Problem
            //int[] arr1 = new int[3];
            //arr1[0] = 1; arr1[1] = 2; arr1[2] = 3;
            //int[] arr2 = new int[] { 1, 2, 3 };
            //int[] arr3 = { 1, 2, 3 };

            //for (int i = 0; i < arr1.Length; i++) {
            //    Console.WriteLine(arr1[i]);
            //}

            //try {
            //    Console.WriteLine(arr1[3]);
            //}
            //catch (IndexOutOfRangeException e) {
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region Question
            /*

            (1) For arrays of reference types (e.g., classes): The default value is null.

            (2) For arrays of numeric types (e.g., int, double): The default value is 0.

            (3) For arrays of bool: The default value is false.

            (4) For arrays of structs: The default value is the result of setting all value-type fields to their default values and all reference-type fields to null.
             
             */
            #endregion

            #region Problem
            //int[] arr1 = new int[3] { 1, 2, 3 };
            //int[] arr2 = new int[3] { 4, 5, 6 };

            //arr1 = arr2;
            //arr1[0] = 1;
            //foreach (var item in arr2) {
            //    Console.WriteLine(item);
            //}

            //arr1 = (int[]) arr2.Clone();
            //foreach (var item in arr2) {
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question
            /*
             
            (1) Use Array.Clone() for simple, full-array shallow copies when type casting is not an issue.

            (2) Use Array.Copy() when you need specific control over the elements being copied, such as copying a subset or inserting at a specific index in the destination array. Both methods provide shallow copies, so care should be taken with reference types.

             */
            #endregion

            #region Problem
            //int[,] arr = new int[3, 3];

            //for (int i = 0; i < arr.GetLength(0); i++) {
            //    for (int j = 0; j < arr.GetLength(1); j++) {
            //        arr[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < arr.GetLength(0); i++) {
            //    for (int j = 0; j < arr.GetLength(1); j++) {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Question
            /*
            
            (1) Use GetLength() when you need detailed control over specific dimensions of a multi-dimensional array, such as when processing data in columns or rows specifically.

            (2) Use Length when you need the total count of all elements, which can be useful for validations or when applying operations that involve every element in the array regardless of dimension.
            
             */
            #endregion

            #region Problem
            //int[] arr = new int[3] { 1, 2, 3 };
            //Array.Sort(arr);
            //foreach (var item in arr) {
            //    Console.WriteLine(item);
            //}

            //Array.Reverse(arr);
            //foreach (var item in arr) {
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(Array.IndexOf(arr, 0));

            //int[] arr1 = new int[3];
            //Array.Copy(arr, arr1, arr.Length);
            //foreach (var item in arr1) {
            //    Console.WriteLine(item);
            //}

            //Array.Clear(arr);
            //foreach (var item in arr) {
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question
            /*
            
            (1) Use Array.Copy() for general purposes where performance is a concern and the impact of a partial copy due to an exception is acceptable.
            
            (2) Use Array.ConstrainedCopy() in critical sections of code where atomicity and state integrity are paramount, ensuring that the copy operation does not partially update the destination array if an exception occurs.

             */
            #endregion

            #region Problem
            //int[] arr = { 1, 2, 3 };
            //for (int i = 0; i < arr.Length; i++) {
            //    Console.WriteLine(arr[i]);
            //}

            //foreach (var item in arr) {
            //    Console.WriteLine(item);
            //}

            //int idx = arr.Length - 1;
            //while (idx >= 0) {
            //    Console.WriteLine(arr[idx--]);
            //}
            #endregion

            #region Question
            /*
            
            While foreach may not always be the best choice for performance-critical applications, especially where complex array manipulations are required, it offers a safer, simpler, and more readable option for operations where the elements of an array are simply being read, displayed, or used in calculations without modifying the array.

             */
            #endregion

            #region Problem
            //int[] arr = { 1, 2, 3 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++) {
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);

            //sum = 0;
            //foreach (var item in arr) {
            //    sum += item;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Question
            /*
             
            for loops offer more efficiency and flexibility for summing array elements, particularly in larger arrays or performance-sensitive contexts.

             */
            #endregion

            /* Part 02 */

            #region Q2
            int day = int.Parse(Console.ReadLine());
            string dayName = Enum.GetName(typeof(DayOfWeek), day - 1);
            Console.WriteLine(dayName);

            Console.WriteLine((int) Enum.Parse(typeof(DayOfWeek), dayName));
            #endregion

            #region Q3
            /*
            
            (1) Entering a value outside the intended range without adequate validation can lead to errors or exceptions due to undefined enum values.

            (2) Implementing thorough input validation ensures the program behaves predictably and provides clear feedback to the user, enhancing the program's robustness and user-friendliness.
            
             */
            #endregion
        }
    }

    enum DayOfWeek {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}