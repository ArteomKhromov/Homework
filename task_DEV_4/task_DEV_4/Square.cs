using System;

namespace task_DEV_4
{
    class Square : Figure
    {
        private const string INVALID_RANGE_ERROR_MESSAGE = "Side cannot be less or equal to zero.";

        public double Side { get; set; }

        public Square(string color, string name, double side) : base(color, name)
        {            
            Side = side;
            CheckForExistence();
        }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }

        public override double CalculatePerimeter()
        {
            return 4 * Side;
        }

        public override void CheckForExistence()
        {
            if (Side <= 0)
            {
                throw new ArgumentOutOfRangeException(INVALID_RANGE_ERROR_MESSAGE);
            }
        }       

        public override string GetFullInfo()
        {
            return $" Color: {Color}, Name: {Name}, Side of square: {Side}";
        }
    }
}
