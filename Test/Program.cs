using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryHeap;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new BinaryHeap<int>(new MaxComparer<int>());
            heap.Insert(2);
            heap.Insert(4);
            heap.Insert(1);
            heap.Insert(7);
            var sortedArray = heap.SortWithoutRecursion();
            foreach (var item in sortedArray)
                Console.Write(item + " ");
            Console.ReadLine();
        }
    }
}
