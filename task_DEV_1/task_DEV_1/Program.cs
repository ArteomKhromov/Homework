using System;

namespace task_DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter A namber");
           int index = int.Parse(Console.ReadLine());
           if (index % 2 == 0 && index % 5 == 0)
            {
              Console.WriteLine("tutti-frutti");
            }
           else if (index % 2 == 0)
            {
              Console.WriteLine("tutti");
            }
           else if (index % 5 == 0)
            {
              Console.WriteLine("frutti");
            } 
           
        }
    }
}
