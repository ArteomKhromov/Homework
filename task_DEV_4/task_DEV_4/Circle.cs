using System;

namespace task_DEV_4
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius, string name, string color) : base(name, color)
        {
            Radius = radius;
        }
        public override void CheckForExistance()
        {
            if (Radius <= 0)
            {
                throw new ArgumentOutOfRangeException("This value cannot be less than or equal to zero.");
            }
            else
            {
                return;
            }
        }
        public override double CalculatePerimeter()
        {
            return Radius * 2 * 3.14;
        }
        public override double CalculateArea()
        {
            return Radius * Radius * 3.14;
        }
        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}, Radius circle : {Radius}";
        }
    }
}
