using System;

namespace Homeworks3
{
    class Program
    {
        /// <summary>
        ///  Gets a multidimensional array as a parameter and prints out the lower triangular elements of a matrix. Array must be a square matrix.
        /// </summary>
        /// <param name="arr"></param>
        public static void PrintLowerTriangularMatrix(int[,] arr)
        {
            if (arr.GetLength(0) != arr.GetLength(1))
            {
                Console.WriteLine("Given array must be a square matrix");
            }
            else
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(0); j++)
                    {
                        if (i >= j)
                        {
                            Console.Write($"{arr[i, j]}\t");
                        }
                        else
                        {
                            Console.Write("0\t");
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
        /// <summary>
        /// Gets a multidimensional array as a parameter and returns Jagged array as a Lower Triangular Matrix. Array must be a square matrix.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[][] MakeLowerTriangularMatrix(int[,] arr)
        {
            int[][] triangularMatrix = new int[arr.GetLength(0)][];
            if (arr.GetLength(0) != arr.GetLength(1))
            {
                Console.WriteLine("Given array must be a square matrix");
                return new int[0][];
            }
            else
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    triangularMatrix[i] = new int[i + 1];

                    for (int j = 0; j < triangularMatrix[i].Length; j++)
                    {
                        triangularMatrix[i][j] = arr[i, j];
                    }
                }
            }
            return triangularMatrix;
        }
        /// <summary>
        /// Returns an array which contains the sum of corresponding elements of two arrays. If elements of one array are less than the other duplicate the smallest array a few times.
        /// </summary>
        /// <param name="inputArray1"></param>
        /// <param name="inputArray2"></param>
        /// <returns></returns>
        public static int[] MergeTwoArraysWithSummedElements(int[] inputArray1, int[] inputArray2)
        {
            int size = inputArray1.Length >= inputArray2.Length ? inputArray1.Length : inputArray2.Length;
            int[] mergedArray = new int[size];

            if (inputArray1.Length == inputArray2.Length)
            {
                for (int i = 0; i < mergedArray.Length; i++)
                {
                    mergedArray[i] = inputArray1[i] + inputArray2[i];
                }
            }
            else if (inputArray1.Length > inputArray2.Length)
            {
                for (int i = 0; i < inputArray1.Length;)
                {
                    for (int j = 0; j < inputArray2.Length && (j + i) <= inputArray1.Length; j++)
                    {
                        mergedArray[i] = inputArray1[i] + inputArray2[j];
                        i++;
                    }

                }
            }
            else
            {
                for (int i = 0; i < inputArray2.Length;)
                {
                    for (int j = 0; j < inputArray1.Length && (j + i) <= inputArray2.Length; j++)
                    {
                        mergedArray[i] = inputArray2[i] + inputArray1[j];
                        i++;
                    }

                }
            }

            return mergedArray;
        }

        /// <summary>
        /// Deletes an element at desired position from an array
        /// </summary>
        /// <param name="InputArray"></param>
        public static void DeleteArrayELement(ref int[] InputArray, int index)
        {
            int[] temp = new int[InputArray.Length - 1];
            for (int i = 0; i < InputArray.Length; i++)
            {
                if (i == index - 1)
                {
                    continue;
                }
                else
                {
                    temp[i < index - 1 ? i : i - 1] = InputArray[i];
                }

            }
            InputArray = new int[temp.Length];
            InputArray = temp;

        }
        static void Main()
        {
            #region Excercise 1.LowerTriangularMatrix

            //Console.WriteLine("Please write some integer as a lenght and height of square matrix:");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int lenght);

            //if (isParsed)
            //{
            //    int[,] myArray = new int[lenght, lenght];

            //    Console.WriteLine("\nNow, please write the elements of array:\n");
            //    for (int i = 0; i < myArray.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < myArray.GetLength(1); j++)
            //        {
            //            Console.Write($"Write element N({i},{j}): ");
            //            myArray[i, j] = int.TryParse(Console.ReadLine(), out int z) ? z : 0;
            //        }
            //    }

            //    Console.WriteLine("\nInputed matrix:");
            //    for (int i = 0; i < myArray.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < myArray.GetLength(1); j++)
            //        {
            //            Console.Write($"{myArray[i, j]}\t");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();

            //    Console.WriteLine("Lower Triangular Matrix:");

            //    PrintLowerTriangularMatrix(myArray);

            //    int[][] MyJaggedArray = MakeLowerTriangularMatrix(myArray);

            //    Console.WriteLine("\nLower Triangular Matrix printed from jagged array:");
            //    for (int i = 0; i < MyJaggedArray.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < MyJaggedArray[i].Length; j++)
            //        {
            //            Console.Write($"{myArray[i, j]}\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("!!! Entered number is incorrect !!!");
            //}


            #endregion

            #region Exercise 2.Merge Arrays

            //Console.WriteLine("Write number of elements for the first array: ");
            //if (int.TryParse(Console.ReadLine(), out int size1))
            //{
            //    Console.WriteLine("Write number of elements for the second array: ");
            //    if (int.TryParse(Console.ReadLine(), out int size2))
            //    {
            //        int[] inputArray1 = new int[size1];
            //        int[] inputArray2 = new int[size2];

            //        Console.WriteLine("\nWrite the elements of the first array:\n");
            //        for (int i = 0; i < inputArray1.Length; i++)
            //        {
            //            Console.Write($"Element N = {i + 1}: ");
            //            inputArray1[i] = int.TryParse(Console.ReadLine(), out int z) ? z : 0;
            //        }
            //        Console.WriteLine("\nWrite the elements of the second array:\n");
            //        for (int i = 0; i < inputArray2.Length; i++)
            //        {
            //            Console.Write($"Element N = {i + 1}: ");
            //            inputArray2[i] = int.TryParse(Console.ReadLine(), out int z) ? z : 0;
            //        }
            //        Console.WriteLine();

            //        int[] mergedSumArray = MergeTwoArraysWithSummedElements(inputArray1, inputArray2);

            //        Console.WriteLine("first Array:");

            //        for (int i = 0; i < inputArray1.Length; i++)
            //        {
            //            Console.Write(inputArray1[i] + "\t");
            //        }
            //        Console.WriteLine("\n");

            //        Console.WriteLine("second Array:");
            //        for (int i = 0; i < inputArray2.Length; i++)
            //        {
            //            Console.Write(inputArray2[i] + "\t");
            //        }
            //        Console.WriteLine("\n");

            //        Console.WriteLine("\nMerged Array with summed elements:");
            //        for (int i = 0; i < mergedSumArray.Length; i++)
            //        {
            //            Console.Write(mergedSumArray[i] + "\t");
            //        }
            //        Console.WriteLine("\n");
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Entered number is incorrect");
            //    }
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Entered number is incorrect");
            //}

            #endregion

            #region Excercise 3.Delete element from Array


            //Console.WriteLine("Write number of elements for the second array: ");
            //if (int.TryParse(Console.ReadLine(), out int size3))
            //{
            //    int[] inputArray3 = new int[size3];

            //    Console.WriteLine("\nWrite the elements of the first array:\n");
            //    for (int i = 0; i < inputArray3.Length; i++)
            //    {
            //        Console.Write($"Element N = {i + 1}: ");
            //        inputArray3[i] = int.TryParse(Console.ReadLine(), out int z) ? z : 0;
            //    }
            //    Console.WriteLine("Write the number of element that you want to delete:");
            //    if (int.TryParse(Console.ReadLine(), out int index))
            //    {
            //        DeleteArrayELement(ref inputArray3, index);
            //    }
            //    Console.WriteLine("Array elements after delete:");
            //    for (int i = 0; i < inputArray3.Length; i++)
            //    {

            //        Console.Write(inputArray3[i] + "\t");
            //    }

            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Entered number is incorrect");
            //}
            #endregion

        }
    }
}
