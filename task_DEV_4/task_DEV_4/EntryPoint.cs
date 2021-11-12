using System;

namespace task_DEV_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {            
            Rectangle rectangle = new Rectangle();
            int height = 5;
            int width = 6;
            rectangle.SetRectangleParameters(height, width);            
            int rectanglePerimeter = rectangle.CalculatePerimeter();
            Console.WriteLine($"The perimetr of a rectangle is {rectanglePerimeter}");
            int rectangleArea = rectangle.CalculateArea();
            Console.WriteLine($"The area of a rectangle is {rectangleArea}");
            bool isSquare = rectangle.IsSquare();
            if (isSquare)
            {
                Console.WriteLine("Square");
            }
            else
            {
                Console.WriteLine("Rectangle");
            }            
        }
    }
}
