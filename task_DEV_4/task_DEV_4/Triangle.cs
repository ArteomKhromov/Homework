using System;


namespace task_DEV_4
{
    class Triangle : Figure
    {
        private const string MASSEGE_ERROR = "The triangle cannot be created because the sum of the two sides is less than the third.";
        public double BaseSide { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public Triangle(string name, string color, double baseSide, double firstSide, double secondSide) : base(color, name)
        {            
            BaseSide = baseSide;
            FirstSide = firstSide;
            SecondSide = secondSide;
            CheckForExistance();
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
        public override void CheckForExistance()
        {
            if (BaseSide + FirstSide >= SecondSide || SecondSide + FirstSide >= BaseSide ||
                BaseSide + SecondSide >= FirstSide)
            {
                throw new ArgumentOutOfRangeException(MASSEGE_ERROR);
            }
        }

        public override string GetFullInfo()
        {
            return $"Color: {Color}, Name: {Name}, Base side: {BaseSide}, First side: {FirstSide}, Second side: {SecondSide}";
        }
    }
}
