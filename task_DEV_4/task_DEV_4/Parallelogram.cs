using System;

namespace task_DEV_4
{
    class Parallelogram : Figure
    {
        private const string MASSEGE_ERROR = "This value cannot be less than, equal to zero.";
        public double Angle { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public Parallelogram(string color, string name,
            double angle, double firstSide, double secondSide) : base(color, name)
        {
            Angle = angle;
            FirstSide = firstSide;
            SecondSide = secondSide;
            CheckForExistance();
        }

        public override double CalculateArea()
        {
            return FirstSide * SecondSide * Math.Sin(Angle);
        }

        public override double CalculatePerimeter()
        {
            return (FirstSide + SecondSide) * 2;
        }

        public override void CheckForExistance()
        {
            if (Angle <= 0 || FirstSide <= 0 || SecondSide <= 0)
            {
                throw new ArgumentOutOfRangeException(MASSEGE_ERROR);
            }
        }

        public override string GetFullInfo()
        {
            return $"Color: {Color} Name: {Name}, Angle: {Angle} " +
                $"Length of sides: {FirstSide}, {SecondSide}.";
        }
    }
}
