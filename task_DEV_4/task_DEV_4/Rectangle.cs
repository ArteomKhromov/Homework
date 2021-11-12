using System;
using System.Collections.Generic;
using System.Text;

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

        public void SettingRectangleValues(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public int CalculatingThePerimeterOfARectangle()
        {
            return (height + width) * 2;
        }

        public int CalculatingTheAreaOfARectangle()
        {
            return height * width;
        }

        public bool CheckForASquare()
        {
            bool isSquare = false;
            if (height == width)
            {
                isSquare = true;                
            }            
            return isSquare; ;
        }
    }
}
