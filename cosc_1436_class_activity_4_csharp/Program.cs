using System;

namespace cosc_1436_class_activity_4_csharp
{
    static class Program
    {
        private static void Main()
        {
            var sumOfSquares = 0;
            
            Console.WriteLine("How many numbers should be in the table?");
            var numberOfSquares = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Number       Square");
            Console.WriteLine("===================");
            
            for (int i = 1; i <= numberOfSquares; i++)
            {
                var square = i * i;
                Console.WriteLine($"{i}         {square}");
                sumOfSquares += square;
            }
            
            Console.WriteLine($"The sum of the squares is {sumOfSquares}.");
        }
    }
}