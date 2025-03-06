using System;

namespace ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Array.Sort(arr);

            Console.WriteLine("\nSorted array:");
            foreach (int num in arr)
                Console.Write(num + " ");

            Console.WriteLine();
        }
    }
}
