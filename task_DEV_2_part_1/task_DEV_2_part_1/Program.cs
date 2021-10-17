using System;

namespace task_DEV_2_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array :");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] numberArray = new int[arrayLength];
            int sum = 0;
            int result = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Enter an array element № {i}");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (numberArray[i] < 20)
            {
                break;
            }
        }
    }
}
