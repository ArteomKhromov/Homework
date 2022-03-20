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
                int count = stack.Count;
                int intPop = stack.Pop();
                bool isEmpty = stack.IsEmpty();

                CustomStack<string> customStack = new CustomStack<string>();
                customStack.Push("Mama");
                customStack.Push("Papa");
                customStack.Push("Sister");
                customStack.Push("Brother");
                count = customStack.Count;
                string stringPop = customStack.Pop();
                isEmpty = customStack.IsEmpty();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
