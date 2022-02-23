using System;

namespace task_DEV_6
{
    class Stack
    {        
        public int[] stack;
        public int count;

        public Stack()
        {
            stack = new int[10];
        }
        public Stack(int number)
        {
            stack = new int[number];
        }

        public int Capacity()
        {
            return stack.Length;
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
            else
            {
                return false;
            }
        }

        public void NegativeResize()
        {
            if (count == stack.Length / 2)
            {
                Array.Resize(ref stack, stack.Length / 2);
            }
        }

        public int Pop()
        {
            NegativeResize();
            return stack[--count];
        }

        public void PositiveResize()
        {
            if (count == stack.Length)
            {
                Array.Resize(ref stack, stack.Length * 2);
            }
        }

        public int Push(int enteredNumber)
        {
            PositiveResize();
            return stack[count++] = enteredNumber;
        }
    }
}
