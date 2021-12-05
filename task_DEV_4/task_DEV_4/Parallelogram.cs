using System;

namespace task_DEV_4
{
    class Parallelogram : Figure
    {
        private const string INVALID_RANGE_ERROR_MESSAGE = "Side cannot be less or equal to zero.";

        public double Angle { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public Parallelogram(string color, string name,
            double angle, double firstSide, double secondSide) : base(color, name)
        {
            Angle = angle;
            FirstSide = firstSide;
            SecondSide = secondSide;
            CheckForExistence();
        }

        public override double CalculateArea()
        {
            return FirstSide * SecondSide * Math.Sin(Angle);
        }

        public override double CalculatePerimeter()
        {
            return (FirstSide + SecondSide) * 2;
        }

        public override void CheckForExistence()
        {
            if (Angle <= 0 || FirstSide <= 0 || SecondSide <= 0)
            {
                throw new ArgumentOutOfRangeException(INVALID_RANGE_ERROR_MESSAGE);
            }
        }

        public override string GetFullInfo()
        {
            return $"Color: {Color} Name: {Name}, Angle: {Angle} " +
                $"Length of sides: {FirstSide}, {SecondSide}.";
        }
    }
}
