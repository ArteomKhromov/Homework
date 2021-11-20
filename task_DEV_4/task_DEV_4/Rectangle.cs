namespace task_DEV_4
{
    class Rectangle : Square
    {
        public double Height { get; set; }
        public double Width { get; set; }        

        public Rectangle(double height, double side) : base(side)
        {
            Height = height;
            Width = side;
        }

        public void SetRectangleParameters(double height, double side)
        {
            Height = height;
            Width = side;
        }

        public override double CalculatePerimeter()
        {
            return (Height + Width) * 2;
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }
    }
}
