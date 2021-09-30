using System;

namespace task_DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B number");
            int lastNumber = int.Parse(Console.ReadLine());

            for (; firstNumber <= lastNumber; firstNumber++)
            {
                if (firstNumber % 2 == 0 && firstNumber % 5 == 0)
                {
                    Console.WriteLine("tutti-frutti");
                }
                else if (firstNumber % 2 == 0)
                {
                    Console.WriteLine("tutti");
                }
                else if (firstNumber % 5 == 0)
                {
                    Console.WriteLine("frutti");
                }
                else
                {
                    Console.WriteLine($"Number {firstNumber} can’t be divided on 2 or 5");
                }
            }
        }
    }
}
