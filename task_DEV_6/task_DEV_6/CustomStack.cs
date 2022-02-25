using System;

namespace task_DEV_6
{
    class CustomStack
    {
        private int[] arrayStack;
        private int count;
        private const int ARRAYLENGTH = 10;

        public CustomStack()
        {
            arrayStack = new int[ARRAYLENGTH];
        }

        public CustomStack(int item)
        {
            arrayStack = new int[item];
        }

        public int Capacity()
        {
            return arrayStack.Length;
        }

        public int Count()
        {
            return count;
        }

        public bool IsEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            return false;
        }

        public void Resize()
        {
            if (count == arrayStack.Length / 2.0)
            {
                int newSize = arrayStack.Length / 2;
                int[] newStack = new int[newSize];

                for (int i = 0; i < arrayStack.Length; i++)
                {
                    newStack[i] = arrayStack[i];
                }
                arrayStack = newStack;
            }
            else if (count == arrayStack.Length * 2.0)
            {
                int newSize = arrayStack.Length * 2;
                int[] newStack = new int[newSize];

                for (int i = 0; i < arrayStack.Length; i++)
                {
                    newStack[i] = arrayStack[i];
                }
                arrayStack = newStack;
            }
        }

        public int Pop()
        {
            WillMessageDisplay();
            Resize();
            return arrayStack[--count];
        }

        public void Push(int enteredElement)
        {
            Resize();
            arrayStack[count++] = enteredElement;
        }

        private void WillMessageDisplay()
        {
            if (count == 0)
            {
                throw new IndexOutOfRangeException("There are no elements.");
            }
        }
    }    
}
