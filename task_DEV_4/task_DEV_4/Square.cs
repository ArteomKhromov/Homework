using System;

namespace task_DEV_4
{
    class Square : Figure
    {
        private const string MESSAGE_ERROR = "This value cannot be less than, equal to zero.";
        public double Side { get; set; }

        public Square(string color, string name, double side) : base(color, name)
        {            
            Side = side;
            CheckForExistance();
        }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }

        public override double CalculatePerimeter()
        {
            return 4 * Side;
        }

        public override void CheckForExistance()
        {
            if (Side <= 0)
            {
                throw new ArgumentOutOfRangeException(MESSAGE_ERROR);
            }
        }       

        public override string GetFullInfo()
        {
            return $" Color: {Color}, Name: {Name}, Side of square: {Side}";
        }
    }
}
