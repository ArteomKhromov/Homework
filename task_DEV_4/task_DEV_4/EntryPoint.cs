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
            rectangle.SettingRectangleValues(height, width);            
            int rectanglePerimetr = rectangle.CalculatingThePerimeterOfARectangle();
            Console.WriteLine($"The perimetr of a rectangle is {rectanglePerimetr}");
            int rectangleArea = rectangle.CalculatingTheAreaOfARectangle();
            Console.WriteLine($"The area of a rectangle is {rectangleArea}");
            bool isSquare = rectangle.CheckForASquare();
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
