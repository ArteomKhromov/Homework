using System;

namespace task_DEV_7
{
    public class CustomStack
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

        /// <summary>
        /// This method adds a new element.
        /// </summary>
        /// <returns>element.Length</returns>
        public int Capacity()
        {
            return elements.Length;
        }
        /// <summary>
        /// Counts the actual number of elements.
        /// </summary>
        /// <returns>count</returns>
        public int Count()
        {
            return count;
        }
        /// <summary>
        /// Returns true if there are no elements in the Stack.
        /// </summary>
        /// <returns>true</returns>
        public bool IsEmpty()
        {
            if (count != 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// This method retrieves the elements from the top of the Stack, and if there are no elements, throws an exception.
        /// </summary>
        /// <returns>elements</returns>
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException(INVALID_RANGE_ERROR_MESSAGE);
            }
            else if (count <= elements.Length % 2)
            {
                Resize(elements.Length / 2);
            }
            return elements[--count];
        }
        /// <summary>
        /// Adds a new element to the top of the Stack.
        /// </summary>
        /// <param name="item"></param>
        public void Push(int item)
        {
            if (count >= elements.Length)
            {
                Resize(elements.Length * 2);
            }
            elements[count++] = item;
        }
        /// <summary>
        /// This method changes the actual size of the Stack.
        /// </summary>
        /// <param name="newSize"></param>
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
