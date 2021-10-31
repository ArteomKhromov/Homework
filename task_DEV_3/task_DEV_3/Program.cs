using System;

namespace task_DEV_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array :");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            if (arrayLength <= 5)
            {
                int[] numberArray = new int[arrayLength];

                for (int i = 0; i < arrayLength; i++)
                {
                    Console.WriteLine($"Enter an array element № {i}");
                    numberArray[i] = Convert.ToInt32(Console.ReadLine());
                }               
                for (int i = 0; i < arrayLength; i++)
                {
                    bool isPrimeNumber = true;
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
                        Console.WriteLine($"{numberArray[i]} is prime number");
                    }
                    else
                    {
                        Console.WriteLine($"{numberArray[i]} is not prime number");
                    }
                }               
            }
            else
            {
                Console.WriteLine("Array size cannot exceed 5");
            }
        }
    }
}
