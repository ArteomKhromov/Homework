﻿using System;

namespace task_DEV_6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayStack stack = new ArrayStack();
                stack.Push(3);
                int count = stack.Count();
                int pop = stack.Pop();                
                bool empty = stack.IsEmpty();
                int capacity = stack.Capacity();
            }
            catch (IndexOutOfRangeException ex)
            { 
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
