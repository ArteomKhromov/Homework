﻿using System;

namespace task_DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array :");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arrayLength;i++)
            {
                if (arrayLength <= 20) 
                    
                    break;
                
                Console.WriteLine("array cannot be <= 20");
            }
            int[] numberArray = new int[arrayLength];

            for (int i = 0; i < arrayLength;i++)
            {
                Console.WriteLine($"Enter an array element № {i}");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = numberArray[0];
            int min = numberArray[0];
            int lessImputNumber = 0;
            int moreImputNumber = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                if (numberArray[i] > max)
                {
                    max = numberArray[i];
                    moreImputNumber = i;
                }
                if (numberArray[i] < min)
                {
                    min = numberArray[i];
                    lessImputNumber = i;
                }
                Console.WriteLine(numberArray[i]);
            }
            numberArray[moreImputNumber] = min;
            numberArray[lessImputNumber] = max;

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
        }
    }
}
