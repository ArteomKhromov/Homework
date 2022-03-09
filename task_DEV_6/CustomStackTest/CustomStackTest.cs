using NUnit.Framework;
using System;
using task_DEV_6;

namespace CustomStackTest
{
    public class CustomStackTest
    {
        [Test]
        public void PushTest()
        {
            CustomStack<int> customStack = new CustomStack<int>();
            for (int i = 0; i < 15; i++)
            {
                customStack.Push(i);
            }
            int push = customStack.Count();
            Assert.AreEqual(push, 15);
        }

        [Test]
        public void PushStringTest()
        {
            CustomStack<string> customStack = new CustomStack<string>();
            customStack.Push("mam");
            customStack.Count();
            customStack.Push("mam");
            customStack.Count();
            customStack.Push("mam");
            customStack.Count();
            customStack.Push("mam");
            customStack.Count();
            customStack.Push("mam");
            customStack.Count();
            customStack.Push("mam");
            customStack.Count();
            Assert.AreEqual(customStack.Count(), 6);
        }

        [Test]
        public void PopTest()
        {
            CustomStack<int> customStack = new CustomStack<int>();
            for (int i = 0; i < 15; i++)
            {
                customStack.Push(i);
            }
            customStack.Pop();
            int pop = customStack.Count();
            Assert.AreEqual(customStack.Count(), 14);
            Assert.AreEqual (pop, 14);
        }

        [Test]
        public void PopStringTest()
        {
            CustomStack<string> customStack = new CustomStack<string>();
            customStack.Push("mam");
            customStack.Push("mam");
            customStack.Push("mam");
            customStack.Push("mam");
            customStack.Push("mam");
            customStack.Push("mam");
            customStack.Pop();
            customStack.Pop();
            customStack.Pop();
            customStack.Pop();
            Assert.AreEqual(customStack.Count(), 2);
        }

        [Test]
        public void PopExeptionTest()
        {
            CustomStack<int> customStack = new CustomStack<int>();
            var exeption = Assert.Throws<IndexOutOfRangeException>(() => customStack.Pop());
            Assert.AreEqual("There are no elements.", exeption.Message);
        }

        [Test]
        public void IsEmptyTest()
        {
            CustomStack<int> customStack = new CustomStack<int>();
            Assert.True(customStack.IsEmpty());
        }

        [Test]
        public void IsEmptyFalseTest()
        {
            CustomStack<int> customStack = new CustomStack<int>();
            customStack.Push(2);
            bool isEmptyFalse = customStack.IsEmpty();
            Assert.False(isEmptyFalse);
        }

        [Test]
        public void IsEmptystringTest()
        {
            CustomStack<string> customStack = new CustomStack<string>();
            Assert.True(customStack.IsEmpty());
        }

        [Test]
        public void CapacityTest()
        {
            CustomStack<int> customStack = new CustomStack<int>();            
            Assert.AreEqual(customStack.Capacity() , 10);
        }

        [Test]
        public void PushResizeTest()
        {
            CustomStack<int> customStack = new CustomStack<int>();
            for (int i = 0; i < 11; i++)
            {
                customStack.Push(i);
            }
            Assert.AreEqual(customStack.Capacity(), 20);
        }

        [Test]
        public void PopResizeTest()
        {
            CustomStack<int> customStack = new CustomStack<int>();
            for (int i = 0; i < 11; i++)
            {
                customStack.Push(i);
            }
            customStack.Pop();
            customStack.Pop();
            customStack.Pop();
            Assert.AreEqual(customStack.Capacity(), 10);
        }
    }
}
