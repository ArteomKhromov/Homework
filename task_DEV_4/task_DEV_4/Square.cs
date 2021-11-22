using System;

namespace task_DEV_4
{
    class Square
    {
        public double SideA { get; set; }

        public Square(double sideA)
        {
            SideA = sideA;
        }        

        public virtual double CalculatePerimeter()
        {
            return 4 * SideA;
        }

        public virtual double CalculateArea()
        {
            return Math.Pow(SideA, 2);
        }
    }
}
