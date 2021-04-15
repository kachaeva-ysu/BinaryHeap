using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryHeap;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountShouldBeZeroAfterHeapCreation()
        {
            var heap = new BinaryHeap<int>(new MaxComparer<int>());
            Assert.AreEqual(0, heap.Count);
        }
        [TestMethod]
        public void CollectionExistsAfterHeapCreation()
        {
            var heap = new BinaryHeap<int>(new int[] { 1, 2, 3 }, new MaxComparer<int>());
            Assert.AreEqual(3, heap.Count);
            Assert.AreEqual(3, heap[1]);
            Assert.AreEqual(2, heap[2]);
            Assert.AreEqual(1, heap[3]);
        }
        [TestMethod]
        public void CapacityIncreases()
        {
            var heap = new BinaryHeap<int>(1, new MaxComparer<int>());
            heap.Insert(1);
            heap.Insert(2);
            Assert.AreEqual(2, heap[1]);
            Assert.AreEqual(1, heap[2]);
        }

        [TestMethod]
        public void ItemExistsAfterInsertion()
        {
            var heap = new BinaryHeap<int>(new MaxComparer<int>());
            heap.Insert(1);
            heap.Insert(2);
            heap.Insert(3);
            heap.Insert(4);
            heap.Insert(5);
            heap.Insert(6);
            Assert.AreEqual(6, heap.Count);
            Assert.AreEqual(6, heap[1]);
            Assert.AreEqual(4, heap[2]);
            Assert.AreEqual(5, heap[3]);
            Assert.AreEqual(1, heap[4]);
            Assert.AreEqual(3, heap[5]);
            Assert.AreEqual(2, heap[6]);
        }

        [TestMethod]
        public void FindReturnsCorrectValue()
        {
            var heap = new BinaryHeap<int>(new int[] { 1, 2, 3 }, new MaxComparer<int>());
            Assert.AreEqual(3, heap.FindRoot());
        }

        [TestMethod]
        public void ItemDoesNotExistAfterRemoving()
        {
            var heap = new BinaryHeap<int>(new int[] { 1, 2, 3 }, new MaxComparer<int>());
            heap.RemoveRoot();
            Assert.AreEqual(2, heap.Count);
            Assert.AreEqual(2, heap[1]);
            Assert.AreEqual(1, heap[2]);
        }
        public void IndexatorGetsCorrectly()
        {
            var heap = new BinaryHeap<int>(new int[] { 1, 2, 3 }, new MaxComparer<int>());
            Assert.AreEqual(3, heap[1]);
        }
        [TestMethod]
        public void MaxHeapIsBalanced()
        {
            var heap = new BinaryHeap<int>(new MaxComparer<int>());
            var rnd = new Random();
            for (int i = 0; i < 100; i++)
                heap.Insert(rnd.Next(0, 100));
            for (int i = 1; i <= heap.Count / 2; i++)
            {
                Assert.AreEqual(true, heap[i] >= heap[i * 2]);
                if (i * 2 + 1 <= heap.Count)
                    Assert.AreEqual(true, heap[i] >= heap[i * 2 + 1]);
            }
        }
        [TestMethod]
        public void MinHeapIsBalanced()
        {
            var heap = new BinaryHeap<int>(new MinComparer<int>());
            var rnd = new Random();
            for (int i = 0; i < 100; i++)
                heap.Insert(rnd.Next(0, 100));
            for (int i = 1; i <= heap.Count / 2; i++)
            {
                Assert.AreEqual(true, heap[i] <= heap[i * 2]);
                if (i * 2 + 1 <= heap.Count)
                    Assert.AreEqual(true, heap[i] <= heap[i * 2 + 1]);
            }
        }
        [TestMethod]
        public void SortWithoutRecursionWorksCorrectly()
        {
            var heap = new BinaryHeap<int>(new MaxComparer<int>());
            var rnd = new Random();
            for (int i = 0; i < 100; i++)
                heap.Insert(rnd.Next(0, 100));
            var sortedArray = heap.SortWithoutRecursion();
            for (int i = 0; i < sortedArray.Length - 1; i++)
                Assert.AreEqual(true, sortedArray[i] >= sortedArray[i + 1]);
            Assert.AreEqual(100, sortedArray.Length);

        }
        [TestMethod]
        public void SortWithRecursionWorksCorrectly()
        {
            var heap = new BinaryHeap<int>(new MaxComparer<int>());
            var rnd = new Random();
            for (int i = 0; i < 100; i++)
                heap.Insert(rnd.Next(0, 100));
            var sortedArray = heap.SortWithRecursion(new int[heap.Count]);
            for (int i = 0; i < sortedArray.Length - 1; i++)
                Assert.AreEqual(true, sortedArray[i] >= sortedArray[i + 1]);
            Assert.AreEqual(100, sortedArray.Length);
        }
    }
}
