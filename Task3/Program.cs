using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[9];
            Random random = new Random();
            Console.WriteLine("The sourse array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100, 1000);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Inverted array:");
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - i - 1];
                numbers[numbers.Length - i - 1] = temp;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
};