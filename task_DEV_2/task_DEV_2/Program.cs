using System;

namespace task_DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array :");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            if (arrayLength <= 20)
            {
                int[] inputNumbers = CreateNumbersArray(arrayLength);
                PrintNumberArraryToConsole(inputNumbers, arrayLength);
                SwapMinMaxElements(inputNumbers, arrayLength);
                PrintNumberArraryToConsole(inputNumbers, arrayLength);
            }
            else
            {
                Console.WriteLine("array cannot be > 20");
            }
        }

        static int CreateNumbersArray(int arrayLength)
        {
            int[] inputNumbers = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Enter an array element № {i}");
                inputNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return inputNumbers;
        }

        static int[] SwapMinMaxElements(int[] inputNumbers, int arrayLength)
        {
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

            return inputNumbers[minIndex];
        }

        static void PrintNumberArraryToConsole(int[] inputNumbers, int arrayLength)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(inputNumbers[i]);
            }
        }
    }
}
