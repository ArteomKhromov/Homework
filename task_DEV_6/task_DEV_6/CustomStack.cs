using System;

namespace task_DEV_6
{
    class CustomStack
    {
        private const int INIT_LENGTH = 10;
        private const string INVALID_RANGE_ERROR_MESSAGE = "There are no elements.";

        private int[] elements;
        private int count;

        public CustomStack()
        {
            elements = new int[INIT_LENGTH];
        }

        public CustomStack(int arrayLength)
        {
            elements = new int[arrayLength];
        }

        public int Capacity()
        {
            return elements.Length;
        }

        public int Count()
        {
            return count;
        }

        public bool IsEmpty()
        {
            if (count != 0)
            {
                return false;
            }
            return true;
        }    

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException(INVALID_RANGE_ERROR_MESSAGE);
            }
            else if (count <= elements.Length / 2.0)
            {
                Resize(elements.Length / 2);
            }            
            return elements[--count];
        }

        public void Push(int item)
        {
            if (count >= elements.Length * 2.0)
            {
                Resize(elements.Length * 2);
            }            
            elements[count++] = item;
        }

        private void Resize(int newSize)
        {
            int[] newArray = new int[newSize];

            for (int i = 0; i < elements.Length; i++)
            {
                newArray[i] = elements[i];
            }
            elements = newArray;
        }
    }
}
