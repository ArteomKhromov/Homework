using NUnit.Framework;
using System;
using CustomStack;

namespace CustomStackTest
{
    [TestFixture]
    public class CustomStackTest
    {
        [Test]
        [TestCase(1)]
        [TestCase("string")]
        [TestCase('D')]
        public void PushTest<T>(T element)
        {
            CustomStack<T> customStack = new CustomStack<T>();
            Assert.AreEqual(customStack.Count, 0);
            Assert.AreEqual(customStack.Capacity, 10);
            customStack.Push(element);
            Assert.AreEqual(customStack.Count, 1);
            Assert.AreEqual(customStack.Capacity, 10);
        }

        [Test]
        [TestCase(1)]
        [TestCase("string")]
        [TestCase('D')]
        public void PopTest<T>(T element)
        {
            CustomStack<T> customStack = new CustomStack<T>();
            Assert.AreEqual(customStack.Count, 0);
            Assert.AreEqual(customStack.Capacity, 10);
            customStack.Push(element);
            T universalPop = customStack.Pop();
            Assert.AreEqual(customStack.Capacity, 5);
            Assert.AreEqual(customStack.Count, 0);
            Assert.AreEqual(universalPop, element);
        }

        [Test]
        public void PopStringTest()
        {
            CustomStack<string> customStack = new CustomStack<string>();
            Assert.AreEqual(customStack.Count, 0);
            customStack.Push("mam");
            customStack.Push("mam");
            customStack.Push("mam");
            customStack.Push("mam");
            customStack.Push("mam");
            customStack.Push("mam");
            Assert.AreEqual(customStack.Count, 6);
            customStack.Pop();
            Assert.AreEqual(customStack.Count, 5);
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
        public void PushResizeTest()
        {
            CustomStack<int> customStack = new CustomStack<int>();
            for (int i = 0; i < 11; i++)
            {
                customStack.Push(i);
            }
            Assert.AreEqual(customStack.Capacity, 20);
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
            Assert.AreEqual(customStack.Capacity, 10);
        }
    }
}
