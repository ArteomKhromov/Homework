using System;

namespace CustomStack
{
    /// <summary>
    /// This is an stack-based stack that can expand and shrink as it fills up.
    /// </summary>
    public class CustomStack<T>
    {
        private const int INIT_LENGTH = 10;
        private const string INVALID_RANGE_ERROR_MESSAGE = "There are no elements.";

        private T[] elements;

        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        
        public int Capacity
        {
            get
            {
                return elements.Length;
            }
        }

        /// <summary>
        /// This constructor creates a stack of 10 cells by default.
        /// </summary>
        public CustomStack()
        {
            elements = new T[INIT_LENGTH];
        }

        /// <summary>
        /// This constructor takes as input an length which specifies the stack capacity.
        /// </summary>
        /// <param name="length"></param>
        public CustomStack(int length)
        {
            elements = new T[length];
        }

        /// <summary>
        /// Returns true if there are no elements in the Stack.
        /// </summary>
        /// <returns>True if count is empty. False if count has filled elements.</returns>
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
        /// <exception cref="NVALID_RANGE_ERROR_MESSAGE">This exception occurs if stack is empty.</exception>
        /// <returns>Throws an error if it is not possible to reduce the stack,
        ///  and reduces the stack if only half of the stack is filled.</returns>
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
        /// <param name="item">Takes item as input (increases capacity of the stack if it is full).</param>
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
        /// <param name="newSize">Takes as input new size(new stack size).</param>
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
