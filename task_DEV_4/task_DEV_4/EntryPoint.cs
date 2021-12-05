using System;

namespace task_DEV_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Circle circle = new Circle("blak", "Circle", 6);
                double circlePerimeter = circle.CalculatePerimeter();
                Console.WriteLine($"The perimetr of a cirkle is {circlePerimeter}");
                double circleArea = circle.CalculateArea();
                Console.WriteLine($"The area of a cirkle is {circleArea}");
                Console.WriteLine(circle.GetFullInfo());

                Parallelogram parallelogram = new Parallelogram("green", "Parallelogram", 9, 7, 5);
                double parallelogramPerimeter = parallelogram.CalculatePerimeter();
                Console.WriteLine($"The perimetr of a parallelogram is {parallelogramPerimeter}");
                double parallelogramArea = parallelogram.CalculateArea();
                Console.WriteLine($"The area of a parallelogram is {parallelogramArea}");
                Console.WriteLine(parallelogram.GetFullInfo());

                Square square = new Square("blue", "Sqare", 8);
                double squarePerimeter = square.CalculatePerimeter();
                Console.WriteLine($"The perimetr of a square is {squarePerimeter}");
                double squareArea = square.CalculateArea();
                Console.WriteLine($"The area of a sqare is {squareArea}");
                Console.WriteLine(square.GetFullInfo());
               
                Triangle triangle = new Triangle("read", "Triangle", 5, 5, 5);
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
