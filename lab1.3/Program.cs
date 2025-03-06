using System;

namespace ChineseZodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birth year: ");
            int birthYear;
            if (!int.TryParse(Console.ReadLine(), out birthYear) || birthYear <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a valid positive year.");
                return;
            }

            string[] zodiacAnimals = {
                "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox",
                "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep"
            };
            int index = birthYear % 12;
            string zodiacSign = zodiacAnimals[index];

            Console.WriteLine($"Your Chinese Zodiac sign is: {zodiacSign}");
        }
    }
}
