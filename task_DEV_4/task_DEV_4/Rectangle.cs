namespace task_DEV_4
{
    class Rectangle : Square
    {
        public double SideB { get; set; }               

        public Rectangle(double sideB, double sideA) : base(sideA)
        {
            SideB = sideB;            
        }

        public void SetRectangleParameters(double sideB, double sideA)
        {
            SideB = sideB;
            SideA = sideA;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (SideB + SideA);
        }

        public override double CalculateArea()
        {
            return SideB * SideA;
        }
    }
}
