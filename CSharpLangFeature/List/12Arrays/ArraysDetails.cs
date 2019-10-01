using System;

namespace CSharpLangFeature.List.Arrays
{
    public static class ArraysDetails
    {
        public static void ArrayDeclaration()
        {
            int[] x;  // can store int values
            string[] s; // can store string values
            double[] d; // can store double values
            Student[] stud1; // can store instances of Student class which is custom class
        }


        public static void ArrayInitialization()
        {
            // defining array with size 5. 
            // But not assigns values
            int[] intArray1 = new int[5];

            // defining array with size 5 and assigning
            // values at the same time
            int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };

            // defining array with 5 elements which 
            // indicates the size of an array
            int[] intArray3 = { 1, 2, 3, 4, 5 };
        }


        public static void AccessingArrayElements()
        {
            //declares & initializes int type array
            int[] intArray = new int[5];

            // assign the value 10 in array on its index 0
            intArray[0] = 10;

            // assign the value 30 in array on its index 2
            intArray[2] = 30;

            // assign the value 20 in array on its index 1
            intArray[1] = 20;

            // assign the value 50 in array on its index 4
            intArray[4] = 50;

            // assign the value 40 in array on its index 3
            intArray[3] = 40;

            // Accesing array elements using index
            var result1 = intArray[0];  //returns 10
            var result2 = intArray[2];  //returns 30
        }

        public static void ArrayElementsUsingDifferentLoops()
        {
            // declares an Array of integers. 
            int[] intArray;

            // allocating memory for 5 integers. 
            intArray = new int[5];

            // initialize the first elements 
            // of the array 
            intArray[0] = 10;

            // initialize the second elements 
            // of the array 
            intArray[1] = 20;

            // so on... 
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            // accessing the elements 
            // using for loop 
            Console.Write("For loop :");
            for (int i = 0; i < intArray.Length; i++)
                Console.Write(" " + intArray[i]);

            Console.WriteLine("");
            Console.Write("For-each loop :");

            // using for-each loop 
            foreach (int i in intArray)
                Console.Write(" " + i);

            Console.WriteLine("");
            Console.Write("while loop :");

            // using while loop 
            int j = 0;
            while (j < intArray.Length)
            {
                Console.Write(" " + intArray[j]);
                j++;
            }

            Console.WriteLine("");
            Console.Write("Do-while loop :");

            // using do-while loop 
            int k = 0;
            do
            {
                Console.Write(" " + intArray[k]);
                k++;
            } while (k < intArray.Length);
        }


        public static void OneDimensionalArray()
        {
            // declares an 1D Array of string. 
            string[] weekDays;

            // allocating memory for days. 
            weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            // Displaying Elements of array 
            foreach (string day in weekDays)
                Console.Write(day + " ");
        }

        public static void MultidimensionalArrays()
        {
            // Two-dimensional array 
            int[,] intarray = new int[,] { { 1, 2 },
                                         { 3, 4 },
                                         { 5, 6 },
                                         { 7, 8 } };

            // The same array with dimensions  
            // specified 4 row and 2 column. 
            int[,] intarray_d = new int[4, 2] { { 1, 2 }, { 3, 4 },
                                             { 5, 6 }, { 7, 8 } };

            // A similar array with string elements. 
            string[,] str = new string[4, 2] { { "one", "two" },
                                            { "three", "four" },
                                            { "five", "six" },
                                            { "seven", "eight" } };

            // Three-dimensional array. 
            int[,,] intarray3D = new int[,,] { { { 1, 2, 3 },
                                             { 4, 5, 6 } },
                                             { { 7, 8, 9 },
                                           { 10, 11, 12 } } };


            // The same array with dimensions  
            // specified 2, 2 and 3. 
            int[,,] intarray3Dd = new int[2, 2, 3] { { { 1, 2, 3 },
                                                  { 4, 5, 6 } },
                                                  { { 7, 8, 9 },
                                                { 10, 11, 12 } } };

            // Accessing array elements. 
            Console.WriteLine("2DArray[0][0] : " + intarray[0, 0]);
            Console.WriteLine("2DArray[0][1] : " + intarray[0, 1]);
            Console.WriteLine("2DArray[1][1] : " + intarray[1, 1]);
            Console.WriteLine("2DArray[2][0] " + intarray[2, 0]);

            Console.WriteLine("2DArray[1][1] (other) : "
                                     + intarray_d[1, 1]);

            Console.WriteLine("2DArray[1][0] (other)"
                                 + intarray_d[1, 0]);

            Console.WriteLine("3DArray[1][0][1] : "
                               + intarray3D[1, 0, 1]);

            Console.WriteLine("3DArray[1][1][2] : "
                              + intarray3D[1, 1, 2]);

            Console.WriteLine("3DArray[0][1][1] (other): "
                                 + intarray3Dd[0, 1, 1]);

            Console.WriteLine("3DArray[1][0][2] (other): "
                                 + intarray3Dd[1, 0, 2]);

            // using nested loop show string elements 
            Console.WriteLine("To String element");
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(str[i, j] + " ");

        }


        public static void JaggedArrays()
        {
            /*----------2D Array---------------*/
            // Declare the array of two elements: 
            int[][] arr = new int[2][];

            // Initialize the elements: 
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Another way of Declare and 
            // Initialize of elements 
            int[][] arr1 = { new int[] { 1, 3, 5, 7, 9 },
                         new int[] { 2, 4, 6, 8 } };

            // Display the array elements: 
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element [" + i + "] Array: ");
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Another Array");

            // Display the another array elements: 
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Element [" + i + "] Array: ");
                for (int j = 0; j < arr1[i].Length; j++)
                    Console.Write(arr1[i][j] + " ");
                Console.WriteLine();
            }
        }


    }
}
