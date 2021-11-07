using System;

namespace task_DEV_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array :");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            if (arrayLength <= 5)
            {
                int[] numbersArray = CreateNumbersArray(arrayLength);
                for (int i = 0; i < arrayLength; i++)
                {
                    if (CheckNumbersForPrime(numbersArray[i]))
                    {
                        Console.WriteLine($"{ numbersArray[i]} is prime numbr");
                    }
                    else
                    {
                        Console.WriteLine($"{ numbersArray[i]} is not prime number");
                    }
                }
            }
            else
            {
                Console.WriteLine("Array length cannot exceed 5");
            }
        }

        static int[] CreateNumbersArray(int arrayLength)
        {
            int[] numbersArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Enter an array element № {i}");
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numbersArray;
        }

        static bool CheckNumbersForPrime(int number)
        {
            bool isPrimeNumber = true;

            for (int j = 2; j < number; j++)
            {
                if (number % j == 0)
                {
                    isPrimeNumber = false;
                    break;
                }
            }
            return (isPrimeNumber);
        }
    }
}
