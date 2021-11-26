using System;


namespace task_DEV_4
{
    class Triangle : Figure
    {
        public double BaseSide { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public override void CheckForExistance()
        {
            if (BaseSide + FirstSide > SecondSide)
            {
            }
            else if (BaseSide <= 0 && FirstSide <= 0 && SecondSide <= 0)
            {
                throw new ArgumentOutOfRangeException("This value cannot be less than or equal to zero.");
            }
            else
            {
                throw new ArgumentOutOfRangeException("This value cannot be less than or equal to zero.");
            }
        }
        public Triangle(double baseSide, double firstSide, double secondSide, string name, string color) : base(name, color)
        {
            BaseSide = baseSide;
            FirstSide = firstSide;
            SecondSide = secondSide;
        }
        public override double CalculatePerimeter()
        {
            return BaseSide + FirstSide + SecondSide;
        }

        public override double CalculateArea()
        {
            double a = BaseSide + FirstSide + SecondSide;
            double b = a / 2;
            return Math.Sqrt(b * (b - BaseSide) * (b - FirstSide) * (b - SecondSide));
        }
        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}, Length of sides : {BaseSide}, {FirstSide}, {SecondSide}";
        }
    }
}
