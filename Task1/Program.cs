using System;
class Program
{
    static void Main() {
        while (true) {
            Console.Write("Enter number of 'q' to exit: ");
            string input = Console.ReadLine();
            if (input == "q") {
                break;
            }
            int number;
            if (int.TryParse(input, out number)) {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if (sum % 2 == 0)
                {
                    Console.WriteLine("[STOP]");
                    break;
                }
            }
            else {
                Console.WriteLine("Incotrrect enter. Please, enter integer number or 'q'.");
            }
        }
    }
};