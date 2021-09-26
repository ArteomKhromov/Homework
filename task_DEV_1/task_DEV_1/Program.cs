using System;

namespace task_DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter A number");
           int inputNumber = int.Parse(Console.ReadLine());
           
             if (inputNumber % 2 == 0 && inputNumber % 5 == 0)
             {
               Console.WriteLine("tutti-frutti");
             }
             else if (inputNumber % 2 == 0)
             {
               Console.WriteLine("tutti");
             }
             else if (inputNumber % 5 == 0)
             {
               Console.WriteLine("frutti");
             } 
             else
             {
               Console.WriteLine("This number is not divisible by 2 and not divisible by 5");
             }
        }
    }
}
