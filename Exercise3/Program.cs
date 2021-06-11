using System;

namespace Exercise3
{
    public class Solution
    {
        public int solution(int A, int B) {
            int res = 0;
            for (int i = A; i <= B; i++)
            {
                if (Math.Sqrt(i) == (int)Math.Sqrt(i))
                    res++;
            }

            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter 1st number of range");
            int start = Convert.ToInt32(Console.ReadLine());
            if(start < -10000) Console.WriteLine("number of value beyond the range");
            Console.WriteLine("please enter 2nd number of range");
            int end = Convert.ToInt32(Console.ReadLine());
            if (end > 10000) Console.WriteLine("number of value beyond the range");
            if(end < start) Console.WriteLine("number of end can not smaller than start");
            Solution s = new Solution();
            Console.WriteLine($"The result is   {s.solution(start, end)}");

        }
    }
}
