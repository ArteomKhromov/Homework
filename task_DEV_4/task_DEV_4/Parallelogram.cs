using System;

namespace task_DEV_4
{
    class Parallelogram : Square
    {
        public double Height { get; set; }
        public double Angle { get; set; }
        public double Side2 { get; set; }

        public Parallelogram(double side, double height) : base(side)
        {
            Height = height;
        }

        public Parallelogram(double side, double side2, double angle) : base(side)
        {
            Side2 = side2;
            Angle = angle;
        }

        public override double CalculateArea()
        {
            if (Height > 0 && Side > 0)
            {
                return Side * Height;
            }
            else
            {
                return Side * Side2 * Math.Sin(Angle);
            }
        }
    }
}
