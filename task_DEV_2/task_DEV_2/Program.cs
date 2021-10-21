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
                int[] numberArray = new int[arrayLength];

                for (int i = 0; i < arrayLength; i++)
                {
                    Console.WriteLine($"Enter an array element № {i}");
                    numberArray[i] = Convert.ToInt32(Console.ReadLine());
                }
                int max = numberArray[0];
                int min = numberArray[0];
                int minIndex = 0;
                int maxIndex = 0;

                for (int i = 0; i < arrayLength; i++)
                {
                    if (numberArray[i] > max)
                    {
                        max = numberArray[i];
                        maxIndex = i;
                    }
                    if (numberArray[i] < min)
                    {
                        min = numberArray[i];
                        minIndex = i;
                    }
                    Console.WriteLine(numberArray[i]);
                }
                numberArray[maxIndex] = min;
                numberArray[minIndex] = max;

                for (int i = 0; i < arrayLength; i++)
                {
                    Console.WriteLine(numberArray[i]);
                }
            }
            else
            {
                Console.WriteLine("array cannot be <= 20");
            }

        }
    }
}
