using System;

namespace task_DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array :");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            if (arrayLength <= 20)
            {
                int[] inputNumbers = new int[arrayLength];

                for (int i = 0; i < arrayLength; i++)
                {
                    Console.WriteLine($"Enter an array element № {i}");
                    inputNumbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                int max = inputNumbers[0];
                int min = inputNumbers[0];
                int minIndex = 0;
                int maxIndex = 0;

                for (int i = 0; i < arrayLength; i++)
                {
                    if (inputNumbers[i] > max)
                    {
                        max = inputNumbers[i];
                        maxIndex = i;
                    }
                    if (inputNumbers[i] < min)
                    {
                        min = inputNumbers[i];
                        minIndex = i;
                    }
                    Console.WriteLine(inputNumbers[i]);
                }
                inputNumbers[maxIndex] = min;
                inputNumbers[minIndex] = max;

                for (int i = 0; i < arrayLength; i++)
                {
                    Console.WriteLine(inputNumbers[i]);
                }
            }
            else
            {
                Console.WriteLine("array cannot be >= 20");
            }
        }
    }
}
