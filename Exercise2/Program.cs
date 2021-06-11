using System;
using System.Collections.Generic;

namespace Exercise2
{
    public class Solution
    {
        public int solution(int[] A)
        {
            var dict = new Dictionary<int, int>();
            foreach (int i in A)
            {
                if (!dict.ContainsKey(i)) 
                    dict.Add(i, 1);
                else
                    dict[i]++;
            }

            int res = 0, max = 0;
            foreach (int i in dict.Values)
            {
                 max = Math.Max(i, max);
            }

            foreach (int i in dict.Keys)
            {
                if (max == dict[i]) res = i;
            }

            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of array size");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1 || n > 1000) Console.WriteLine("number of array size beyond the range");
            int[] arr = new int[n];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter value of {i}th number");
                arr[i - 1] = Convert.ToInt32(Console.ReadLine());
                if (arr[i - 1] < 0 || arr[i - 1] > 10000)
                {
                    Console.WriteLine("number of array value beyond the range");
                    break;
                }
            }

            Solution s = new Solution();
            int res = s.solution(arr);
            Console.WriteLine($"The most often value in array is {res}");
        }
    }
}
