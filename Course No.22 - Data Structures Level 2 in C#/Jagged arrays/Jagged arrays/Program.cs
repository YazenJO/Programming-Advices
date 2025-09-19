using System;

namespace Jagged_arrays
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int [][]jaggedarray = new int[3][];
            jaggedarray[0] = new int[] { 1, 2 };
            jaggedarray[1] = new int[] { 3, 4};
            jaggedarray[2] = new int[] { 5, 6 , 7,8};

            for (int i = 0; i < jaggedarray.Length; i++)
            {
                for (int j = 0; j < jaggedarray[i].Length; j++)
                {
                    Console.Write(jaggedarray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}