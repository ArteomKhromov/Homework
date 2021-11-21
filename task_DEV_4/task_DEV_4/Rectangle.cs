namespace task_DEV_4
{
    class Rectangle : Square
    {
        public double Height { get; set; }
               

        public Rectangle(double height, double side) : base(side)
        {
            Height = height;            
        }

        public void SetRectangleParameters(double height)
        {
            Height = height;            
        }

        public override double CalculatePerimeter()
        {
            return (Height * 2) + (FirstSide * 2);
        }

        public override double CalculateArea()
        {
            return Height * FirstSide;
        }
    }
}
