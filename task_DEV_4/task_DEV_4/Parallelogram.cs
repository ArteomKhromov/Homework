using System;

namespace task_DEV_4
{
    class Parallelogram : Square
    {
        public double Height { get; set; }
        public double Angle { get; set; }
        public double SecondSide { get; set; }

        public Parallelogram(double firstSide, double height) : base(firstSide)
        {
            Height = height;
        }

        public Parallelogram(double firstSide, double secondSide, double angle) : base(firstSide)
        {
            SecondSide = secondSide;
            Angle = angle;
        }

        public override double CalculateArea()
        {
            if (Height > 0 && FirstSide > 0)
            {
                return FirstSide * Height;
            }
            else if (FirstSide > 0 && SecondSide > 0 && Angle > 0)
            {
                return FirstSide * SecondSide * Math.Sin(Angle);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
