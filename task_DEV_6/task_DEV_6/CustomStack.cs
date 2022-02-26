using System;

namespace task_DEV_6
{
    class CustomStack
    {
        private const int ARRAY_LENGTH = 10;
        private const string INVALID_RANGE_ERROR_MESSAGE = "There are no elements.";

        private int[] elements;
        private int count;

        public CustomStack()
        {
            elements = new int[ARRAY_LENGTH];
        }

        public CustomStack(int capacity)
        {
            elements = new int[capacity];
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

        private void Resize(int newSize)
        {
            int[] newStack = new int[newSize];

            for (int i = 0; i < elements.Length; i++)
            {
                newStack[i] = elements[i];
            }
            elements = newStack;
        }

        public int Pop()
        {
            if (count == 0)
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
    }
}
