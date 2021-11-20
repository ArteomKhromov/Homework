namespace task_DEV_4
{
    class Square
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public void SetSquareParameter(double side)
        {
            Side = side;
        }

        public virtual double CalculatePerimeter()
        {
            return (Side + Side) * 2;
        }

        public virtual double CalculateArea()
        {
            return Side * Side;
        }
    }
}
