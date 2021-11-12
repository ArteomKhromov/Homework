namespace task_DEV_4
{
    class Rectangle
    {
        public int height;
        public int width;

        public Rectangle()
        {

        }

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public void SetRectangleParameters(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public int CalculatePerimeter()
        {
            return (height + width) * 2;
        }

        public int CalculateArea()
        {
            return height * width;
        }

        public bool IsSquare()
        {
            return height == width;
        }
    }
}
