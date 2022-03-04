using NUnit.Framework;
using System;

namespace task_DEV_6
{
    public class CustomStackTest
    {
        [Test]
        public void PushTest()
        {
            CustomStack customStack = new CustomStack();
            customStack.Push(2);
            int count = customStack.Count();
            Assert.AreEqual(count, 1);
        }

        [Test]
        public void PopTest()
        {
            CustomStack customStack = new CustomStack();
            customStack.Push(3);
            int pop = customStack.Pop();
            int count = customStack.Count();
            Assert.AreEqual(count, 0);
        }

        [Test]
        public void PopExeptionTest()
        {
            CustomStack customStack = new CustomStack();
            var exeption = Assert.Throws<IndexOutOfRangeException>(() => customStack.Pop());
        }

        [Test]
        public void IsEmptyTest()
        {
            CustomStack customStack = new CustomStack();
            bool isEmpty = customStack.IsEmpty();
            Assert.True(isEmpty);
        }

        [Test]
        public void CapacityTest()
        {
            CustomStack customStack = new CustomStack();
            int capacyti = customStack.Capacity();
            Assert.AreEqual(capacyti, 10);
        }
    }
}
