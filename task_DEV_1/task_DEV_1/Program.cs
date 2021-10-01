using System;

namespace task_DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int lastNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                if (i % 2 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("tutti-frutti");
                }
                else if ( i % 2 == 0)
                {
                    Console.WriteLine("tutti");
                }
                else if ( i % 5 == 0)
                {
                    Console.WriteLine("frutti");
                }
                else
                {
                    Console.WriteLine($"Number {i} can’t be divided on 2 or 5");
                }
            }
        }
    }
}
