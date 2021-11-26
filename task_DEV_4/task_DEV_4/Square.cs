﻿using System;

namespace task_DEV_4
{
    class Square : Figure
    {
        public double Side { get; set; }
        
        public override void CheckForExistance()
        {
            if (Side <= 0)
            {
                throw new ArgumentOutOfRangeException("This value cannot be less than or equal to zero.");
            }
            else
            {
                return;
            }
        }

        public Square(double side,string name,string color) : base(name,color)
        {
            Side = side;
        }        

        public override double CalculatePerimeter()
        {
            return 4 * Side;
        }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }
        public override string GetFullInfo()
        {
            return $"Name : {Name}, Color : {Color}, Side square {Side}";
        }
    }
}
