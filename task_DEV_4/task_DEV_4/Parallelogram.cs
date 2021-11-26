using System;

namespace task_DEV_4
{
    class Parallelogram : Figure
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double Heigth { get; set; }
        public double Angle { get; set; }        

        public override void CheckForExistance()
        {
            if (Heigth <= 0 && FirstSide <= 0)
            {
                throw new ArgumentOutOfRangeException("This value cannot be less than or equal to zero.");
            }
            else if (FirstSide <= 0 && SecondSide <= 0 && Angle <= 0)
            {
                throw new ArgumentOutOfRangeException("This value cannot be less than or equal to zero.");
            }            
        }
        public Parallelogram(double firstSide, double heigth, string name, string color) : base(name,color)
        {
            FirstSide = firstSide;
            Heigth = heigth;
        }

        public Parallelogram(double firstSide, double secondSide, double angle, string name, string color) : base(name,color)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            Angle = angle;
        }

        public override double CalculatePerimeter()
        {
            if (FirstSide > 0 && SecondSide > 0)
            {
                return (FirstSide + SecondSide) * 2;
            }
            else if (FirstSide > 0 && SecondSide > 0 && Angle > 0)
            {
                return (FirstSide + SecondSide) * 2;
            }
            else
            {
                throw new ArgumentOutOfRangeException("This value cannot be less than or equal to zero.");
            }
        }

        public override double CalculateArea()
        {
            if (Heigth > 0 && FirstSide > 0)
            {
                return FirstSide * Heigth;
            }
            else if (FirstSide > 0 && SecondSide > 0 && Angle > 0)
            {
                return FirstSide * SecondSide * Math.Sin(Angle);
            }        
            else
            {
                throw new ArgumentOutOfRangeException("This value cannot be less than or equal to zero.");
            }
        }

        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color :{Color}, Length of sides : {FirstSide}, {SecondSide}, Heigth : {Heigth}, Angle : {Angle}";
        }
    }
}
