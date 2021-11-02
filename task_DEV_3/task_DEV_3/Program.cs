using System;

namespace task_DEV_3
{
    class Program
    {
        static void InputOfArrayElements(int[] numberArray, int arrayLength)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Enter an array element № {i}");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void ExaminationNumberArray(int[] numberArray, int arrayLength)
        {
            bool isPrimeNumber;
            for (int i = 0; i < arrayLength; i++)
            {
                isPrimeNumber = true;
                for (int j = 2; j < numberArray[i]; j++)
                {
                    if (numberArray[i] % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    Console.WriteLine($"{ numberArray[i]} is prime numbr");
                }
                else
                {
                    Console.WriteLine($"{ numberArray[i]} is not prime number");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array :");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            if (arrayLength <= 5)
            {
                int[] numberArray = new int[arrayLength];

                InputOfArrayElements(numberArray, arrayLength);
                ExaminationNumberArray(numberArray, arrayLength);
            }
            else
            {
                Console.WriteLine("Array length cannot exceed 5");
            }
        }
    }
}
