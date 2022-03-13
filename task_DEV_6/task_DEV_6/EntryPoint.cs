using System;

namespace CustomStack
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                CustomStack<int> stack = new CustomStack<int>();
                stack.Push(3);
                stack.Push(5);
                stack.Push(7);
                stack.Push(3);
                stack.Pop();
                int count = stack.count;
                int pop = stack.Pop();
                bool empty = stack.IsEmpty();
                

                CustomStack<string> customStack = new CustomStack<string>();
                customStack.Push("Mama");
                customStack.Push("Papa");
                customStack.Push("Sister");
                customStack.Push("Brother");
                count = customStack.count;
                string newPop = customStack.Pop();
                empty = customStack.IsEmpty();
                
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
