﻿using System;

namespace task_DEV_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Square square = new Square(3);
                double squarePerimeter = square.CalculatePerimeter();
                Console.WriteLine($"The perimetr of a square is {squarePerimeter}");
                double squareArea = square.CalculateArea();
                Console.WriteLine($"The area of a sqare is {squareArea}");

                Rectangle rectangle = new Rectangle(5, 6);
                double rectanglePerimeter = rectangle.CalculatePerimeter();
                Console.WriteLine($"The perimetr of a rectangle is {rectanglePerimeter}");
                double rectangleArea = rectangle.CalculateArea();
                Console.WriteLine($"The area of a rectangle is {rectangleArea}");

                Parallelogram parallelogram = new Parallelogram(3, 6, 40);
                double parallelogramArea = parallelogram.CalculateArea();
                Console.WriteLine($"The perimetr of a parallelogram is {parallelogramArea}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The parameter cannot be less than or equal to zero.");
            }
        }
    }
}
