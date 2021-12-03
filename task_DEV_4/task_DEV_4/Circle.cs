using System;

namespace task_DEV_4
{
    class Circle : Figure
    {
        private const string MASSEGE_ERROR = "Radius cannot be less than, equal to zero.";
        public double Radius { get; set; }

        public Circle(string color, string name, double radius) : base(color, name)
        {            
            Radius = radius;
            CheckForExistance();
        }

        public override double CalculatePerimeter()
        {
            return Radius * 2 * Math.PI;
        }

        public override double CalculateArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override void CheckForExistance()
        {
            if (Radius <= 0)
            {
                throw new ArgumentOutOfRangeException(MASSEGE_ERROR);
            }
        }               

        public override string GetFullInfo()
        {
            return $"Color: {Color}, Name: {Name}, Radius of circle: {Radius}";
        }
    }
}
