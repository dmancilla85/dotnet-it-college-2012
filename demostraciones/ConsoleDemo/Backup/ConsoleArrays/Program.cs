// arrays.cs
using System;
class DeclareArraysSample
{
    public static void Main()
    {
        // Single-dimensional array
        int[] numbers = new int[5];

        // Multidimensional array
        string[,] names = new string[5, 4];

        // Array-of-arrays (jagged array)
        int[][] scores = new int[5][];

        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = new int[i + 3];
        }

        // Print length of each row
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            Console.WriteLine("Longitud de una determinada dimención: {1}",i,scores[i].GetLength(0));
            Console.ReadLine();
        }
    }
}