using System;

namespace task_DEV_6
{
    /// <summary>
    /// This is an array-based stack that can expand and shrink as it fills up.
    /// </summary>
    public class CustomStack<T>
    {
        private const int INIT_LENGTH = 10;
        private const string INVALID_RANGE_ERROR_MESSAGE = "There are no elements.";

        private T[] elements;
        private int count;

        public CustomStack()
        {
            elements = new T[INIT_LENGTH];
        }

        public CustomStack(int arrayLength)
        {
            elements = new T[arrayLength];
        }

        /// <summary>
        /// This method adds a new element.
        /// </summary>
        /// <returns>Returns the length of the custom stack.</returns>
        public int Capacity()
        {
            return elements.Length;
        }

        /// <summary>
        /// Counts the actual number of elements.
        /// </summary>
        /// <returns>The number of elements.</returns>
        public int Count()
        {
            return count;
        }

        /// <summary>
        /// Returns true if there are no elements in the Stack.
        /// </summary>
        /// <returns>True if count is empty. False if caunt has filled elements.</returns>
        public bool IsEmpty()
        {
            if (count != 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// This method retrieves the elements from the top of the Stack,
        /// and if there are no elements, throws an exception.
        /// </summary>
        /// <returns>Throws an error if it is not possible to reduce the array,
        ///  and reduces the array if only half of the array is filled.</returns>
        public T Pop()
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

        /// <summary>
        /// Adds a new element to the top of the Stack.
        /// </summary>
        /// <param name="item">Takes itam as input (increases the size of the array if it is full).</param>
        public void Push(T item)
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
        /// <param name="newSize">Takes as input new size(new array size).</param>
        private void Resize(int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < count; i++)
            {
                newArray[i] = elements[i];
            }
            elements = newArray;
        }
    }
}
