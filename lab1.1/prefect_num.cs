using System;

namespace lab1
{
    class prefect_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start of the range:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end of the range:");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Perfect numbers between {start} and {end}:");
            FindPerfectNumbers(start, end);
        }

        static void FindPerfectNumbers(int start, int end)
        {
            for (int num = start; num <= end; num++)
            {
                if (IsPerfect(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

        static bool IsPerfect(int num)
        {
            if (num < 2) return false;

            int sum = 1;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }
    }
}
