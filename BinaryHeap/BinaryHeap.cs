using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    public class BinaryHeap<T> where T : IComparable
    {
        private T[] Heap { get; set; }
        public int Count { get; set; }
        private int Capacity { get; set; }
        private IComparer<T> _comparer;
        public BinaryHeap(IComparer<T> comparer)
        {
            Capacity = 8;
            Count = 0;
            Heap = new T[Capacity + 1];
            _comparer = comparer;
        }
        public BinaryHeap(int capacity, IComparer<T> comparer)
        {
            Capacity = capacity;
            Count = 0;
            Heap = new T[Capacity + 1];
            _comparer = comparer;
        }
        public BinaryHeap(ICollection<T> heap, IComparer<T> comparer)
        {
            if(heap==null)
                throw new ArgumentNullException();
            Capacity = heap.Count;
            Count = heap.Count;
            Heap = new T[Capacity+1];
            heap.CopyTo(Heap,1);
            _comparer = comparer;
            BuildHeap();
        }

        private void BuildHeap()
        {
            for (var i = Count / 2; i > 0; i--)
            {
                HeapifyTopToBottom(i);
            }
        }
        private void IncreaseCapacity()
        {
            if (Capacity == Count)
            {
                Capacity *= 2;
                T[] temp = new T[Capacity+1];
                Array.Copy(Heap, 1, temp, 1, Count);
                Heap = temp;
            }
        }
        public void Insert(T value)
        {
            IncreaseCapacity();
            Heap[Count + 1] = value;
            Count++;
            if(Count/2!=0)
            HeapifyBottomToTop(Count);
        }
        public T FindRoot()
        {
            if (Count != 0)
                return Heap[1];
            else
                throw new NullReferenceException();
        }
        public bool RemoveRoot()
        {
            if (Count == 0)
                return false;
            Heap[1] = Heap[Count];
            Count--;
            HeapifyTopToBottom(1);
            return true;
        }

        private void HeapifyTopToBottom(int index)
        {
            var left = 2 * index;
            var right = 2 * index + 1;
            var parent = index;
            if (left <= Count && _comparer.Compare(Heap[left], Heap[index]) > 0)
                parent = left;
            if (right <= Count && _comparer.Compare(Heap[right], Heap[parent]) > 0)
                parent = right;

            if (parent == index) return;
            var temp = Heap[parent];
            Heap[parent] = Heap[index];
            Heap[index] = temp;
            HeapifyTopToBottom(parent);
        }
        private void HeapifyTopToBottomWithoutRecursion(int index)
        {
            while (true)
            {
                var left = 2 * index;
                var right = 2 * index + 1;
                var parent = index;
                if (left <= Count && _comparer.Compare(Heap[left], Heap[index]) > 0)
                    parent = left;
                if (right <= Count && _comparer.Compare(Heap[right], Heap[parent]) > 0)
                    parent = right;

                if (parent == index) return;
                var temp = Heap[parent];
                Heap[parent] = Heap[index];
                Heap[index] = temp;
                index = parent;
            }
        }
        private void HeapifyBottomToTop(int index)
        {
            if (index <= 1) return;
            int parent = index / 2;
            if(_comparer.Compare(Heap[index], Heap[parent]) > 0)
            {
                var temp = Heap[parent];
                Heap[parent] = Heap[index];
                Heap[index] = temp;
            }
            HeapifyBottomToTop(parent);
        }
        public T this[int index]
        {
            get
            {
                if (index <= 0 || index > Count)
                    throw new IndexOutOfRangeException();
                return Heap[index];
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= Count; i++)
                result.Append(Heap[i] + " ");
            return result.ToString();
        }

        public T[] SortWithRecursion()
        {
            T[] sortedArray = new T[Count];
            return SortWithRecursion(sortedArray, 0);
        }


        private T[] SortWithRecursion(T[] sortedArray,int index)
        {
            sortedArray[index] = Heap[1];
            Heap[1] = Heap[Count];
            Count--;
            index++;
            HeapifyTopToBottom(1);
            if(Count>0)
                SortWithRecursion(sortedArray,index);
            return sortedArray;

        }
        public T[] SortWithoutRecursion()
        {
            T[] sortedArray = new T[Count];
            for(int i=0;i<sortedArray.Length;i++)
            {
                sortedArray[i] = Heap[1];
                Heap[1] = Heap[Count];
                Count--;
                HeapifyTopToBottomWithoutRecursion(1);
            }
            return sortedArray;
        }

    }
    public class MaxComparer<T> : IComparer<T> where T : IComparable
    {
        public int Compare(T a, T b)
        {
            return a.CompareTo(b);
        }
    }
    public class MinComparer<T> : IComparer<T> where T : IComparable
    {
        public int Compare(T a, T b)
        {
            return -(a.CompareTo(b));
        }
    }
}
