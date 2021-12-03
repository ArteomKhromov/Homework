using System;

namespace task_DEV_4
{
    class Triangle : Figure
    {
        private const string FIRST_MESSAGE_ERROR = "The triangle cannot be created because the" +
            " sum of the two sides is less than the third.";
        private const string SECOND_MESSAGE_ERROR = "Side cannot be less or equal to zero.";

        public double BaseSide { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public Triangle(string name, string color, double baseSide,
            double firstSide, double secondSide) : base(color, name)
        {
            BaseSide = baseSide;
            FirstSide = firstSide;
            SecondSide = secondSide;
            CheckForExistence();
        }

        public override double CalculateArea()
        {
            double perimeter = CalculatePerimeter();
            double semiPerimeter = perimeter / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - BaseSide) *
                (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide));
        }

        public override double CalculatePerimeter()
        {
            return BaseSide + FirstSide + SecondSide;
        }

        public override void CheckForExistence()
        {
            if (BaseSide <= 0 || FirstSide <= 0 || SecondSide <= 0)
            {
                throw new ArgumentOutOfRangeException(SECOND_MESSAGE_ERROR);
            }
            else if (BaseSide + FirstSide <= SecondSide || SecondSide + FirstSide <= BaseSide ||
                 BaseSide + SecondSide <= FirstSide)
            {
                throw new ArgumentOutOfRangeException(FIRST_MESSAGE_ERROR);
            }
        }

        public override string GetFullInfo()
        {
            return $"Color: {Color}, Name: {Name}, Base side: {BaseSide}, " +
                $"First side: {FirstSide}, Second side: {SecondSide}";
        }
    }
}
