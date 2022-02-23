using System;

namespace task_DEV_6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = new Stack();
                stack.Push(10);
                int count = stack.Count();
                int pop = stack.Pop();                
                bool empty = stack.IsEmpty();
                int capacity = stack.Capacity();
            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine(i.Message);
            }
        }
    }
}
