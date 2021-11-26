using System;

namespace task_DEV_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Square square = new Square(3, "Sqare", "blue");
                double squarePerimeter = square.CalculatePerimeter();
                Console.WriteLine($"The perimetr of a square is {squarePerimeter}");
                double squareArea = square.CalculateArea();
                Console.WriteLine($"The area of a sqare is {squareArea}");
                Console.WriteLine(square.GetFullInfo());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Parallelogram parallelogram = new Parallelogram(3, 4, 5, "Parallelogram", "green");
                double parallelogramPerimeter = parallelogram.CalculateArea();
                Console.WriteLine($"The perimetr of a parallelogram is {parallelogramPerimeter}");
                double parallelogramArea = parallelogram.CalculateArea();
                Console.WriteLine($"The area of a parallelogram is {parallelogramArea}");
                Console.WriteLine(parallelogram.GetFullInfo());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Circle circle = new Circle(10, "Circle", "blak");
                double circlePerimeter = circle.CalculatePerimeter();
                Console.WriteLine($"The perimetr of a cirkle is {circlePerimeter}");
                double circleArea = circle.CalculateArea();
                Console.WriteLine($"The area of a cirkle is {circleArea}");
                Console.WriteLine(circle.GetFullInfo());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Triangle triangle = new Triangle(3, 7, 5, "Triangle", "read");
                double trianglePerimeter = triangle.CalculatePerimeter();
                Console.WriteLine($"The perimeter of a triangle is {trianglePerimeter}");
                double triangleArea = triangle.CalculateArea();
                Console.WriteLine($"The area of a triangle is {triangleArea}");
                Console.WriteLine(triangle.GetFullInfo());
            }            
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
