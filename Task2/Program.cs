using System;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100, 1000);
                Console.Write(numbers[i] + " ");
            }

            int evenNumbersCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbersCount++;
                }
            }

            Console.WriteLine("The number of even numbers in the array: {0}", evenNumbersCount);
        }
    }
};