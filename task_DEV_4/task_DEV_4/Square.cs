using System;

namespace task_DEV_4
{
    class Square
    {
        public double FirstSide { get; set; }

        public Square(double side)
        {
            FirstSide = side;
        }        

        public virtual double CalculatePerimeter()
        {
            return 4 * FirstSide;
        }

        public virtual double CalculateArea()
        {
            return Math.Pow(FirstSide,2);
        }
    }
}
