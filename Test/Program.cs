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
            var heap = new BinaryHeap<int>(new maxComparer<int>());
            Console.ReadLine();
        }
    }
}
