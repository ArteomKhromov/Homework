using System;

namespace task_DEV_4
{
    class Parallelogram : Square
    {
        public double HeightA { get; set; }
        public double Angle { get; set; }
        public double SideB { get; set; }

        public Parallelogram(double sideA, double heightA) : base(sideA)
        {
            HeightA = heightA;
        }

        public Parallelogram(double sideA, double sideB, double angle) : base(sideA)
        {
            SideB = sideB;
            Angle = angle;
        }

        public override double CalculateArea()
        {
            if (HeightA > 0 && SideA > 0)
            {
                return SideA * HeightA;
            }
            else if (SideA > 0 && SideB > 0 && Angle > 0)
            {
                return SideA * SideB * Math.Sin(Angle);
            }
            else
            {
                throw new ArgumentOutOfRangeException("The parameter cannot be less or equal to zero.");
            }
        }
    }
}
