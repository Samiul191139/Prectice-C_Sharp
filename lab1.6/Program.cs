using System;

namespace ArraySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter the element to search: ");
            int searchElement = int.Parse(Console.ReadLine());

            bool found = false;
            foreach (int num in arr)
            {
                if (num == searchElement)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("Element found");
            else
                Console.WriteLine("Element not found");
        }
    }
}
