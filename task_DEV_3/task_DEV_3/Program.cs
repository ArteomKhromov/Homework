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
                    if (numberArray[i] < 0)
                    {
                        Console.WriteLine("This is a negative number");
                        break;
                    }
                }
                bool isPrimeNumber = true;



                for (int i = 0; i < arrayLength; i++)
                {
                    if (numberArray[i] == 1 || numberArray[i] == 2)
                    {
                        Console.WriteLine($"{numberArray[i]} is prime number");
                    }
                    for (int j = 2; j < numberArray[i]; j++)
                    {
                        if (numberArray[i] % j == 0)
                        {
                            isPrimeNumber = false;
                            Console.WriteLine($"{numberArray[i]} is not prime number");
                            break;
                        }
                        else
                        {                            
                            Console.WriteLine($"{numberArray[i]} is prime number");
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Array has exceeded the allowed value");
            }
        }
    }
}