using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[,] matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int num = matrix.Length;
            int left = 0, right = matrix.GetLength(1) - 1, top = 0, bottom = matrix.GetLength(0) - 1;
            var res = new List<int>();
            while (num > 0)
            {
                for (int i = left; i <= right; i++)
                {
                    res.Add(matrix[top, i]);
                    num--;
                }
                top++;
                if (num < 1) break;
                for (int i = top; i <= bottom; i++)
                {
                    res.Add(matrix[i, right]);
                    num--;
                }
                right--;
                if (num < 1) break;
                for (int i = right; i >= left; i--)
                {
                    res.Add(matrix[bottom, i]);
                    num--;
                }
                bottom--;
                if (num < 1) break;
                for (int i = bottom; i >= top; i--)
                {
                    res.Add(matrix[i, left]);
                    num--;
                }
                if (num < 1) break;
                left++;
            }
            Console.WriteLine("The result is:");
            foreach (int i in res)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
