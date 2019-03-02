using System;

namespace ClassesExamples
{
    class Program
    {
        static void Main(string[] args) // Method inside class Program
        {
            var taffy = new Candy("Orange", "Orange Saltwater Taffy", CandyType.Stretchy);

            taffy.SetRating(10);
            taffy.SetRating(5, "I just kinda liked it");

            Console.WriteLine(taffy);

            Console.ReadKey();
        }
    }
}
