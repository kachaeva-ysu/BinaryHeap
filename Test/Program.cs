using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Console.WriteLine("Сортировка с рекурсией vs сортировка без рекурсии");
            while (true)
            {
                Console.WriteLine("n=");
                string input = Console.ReadLine();
                if (input == "")
                    break;
                int n = int.Parse(input);
                var rnd = new Random();
                Stopwatch watch = new Stopwatch();

                int[] sortedElements = new int[n];
                for (int i = n - 1; i >= 0; i--)
                    sortedElements[i] = i;
                BinaryHeap<int> heap = new BinaryHeap<int>(sortedElements, new MaxComparer<int>());
                watch.Start();
                heap.SortWithRecursion();
                watch.Stop();
                Console.Write("Отсортированная последовательность: " + watch.Elapsed.TotalMilliseconds);
                heap = new BinaryHeap<int>(sortedElements, new MaxComparer<int>());
                watch.Restart();
                heap.SortWithoutRecursion();
                watch.Stop();
                Console.WriteLine(" vs " + watch.Elapsed.TotalMilliseconds);

                int[] partiallySortedElements = new int[n];
                for (int i = n / 2 - 1; i >= 0; i--)
                    partiallySortedElements[i] = i;
                for (int i = n / 2; i < n; i++)
                    partiallySortedElements[i] = rnd.Next(0, n);
                heap = new BinaryHeap<int>(partiallySortedElements, new MaxComparer<int>());
                watch.Restart();
                heap.SortWithRecursion();
                watch.Stop();
                Console.Write("Частично отсортированная последовательность: " + watch.Elapsed.TotalMilliseconds);
                heap = new BinaryHeap<int>(partiallySortedElements, new MaxComparer<int>());
                watch.Restart();
                heap.SortWithoutRecursion();
                watch.Stop();
                Console.WriteLine(" vs " + watch.Elapsed.TotalMilliseconds);

                HashSet<int> nonRepeatingElements = new HashSet<int>();
                while (nonRepeatingElements.Count < n)
                    nonRepeatingElements.Add(rnd.Next(0, n));
                heap = new BinaryHeap<int>(nonRepeatingElements, new MaxComparer<int>());
                watch.Restart();
                heap.SortWithRecursion();
                watch.Stop();
                Console.Write("Случайная последовательность со всеми различными элементами: " + watch.Elapsed.TotalMilliseconds);
                heap = new BinaryHeap<int>(nonRepeatingElements, new MaxComparer<int>());
                watch.Restart();
                heap.SortWithoutRecursion();
                watch.Stop();
                Console.WriteLine(" vs " + watch.Elapsed.TotalMilliseconds);

                int[] repeatingElements = new int[n];
                for (int i = 0; i < n; i++)
                    repeatingElements[i] = rnd.Next(0, n);
                heap = new BinaryHeap<int>(repeatingElements, new MaxComparer<int>());
                watch.Restart();
                heap.SortWithRecursion();
                watch.Stop();
                Console.Write("Случайная последовательность с повторяющимися элементами: " + watch.Elapsed.TotalMilliseconds);
                heap = new BinaryHeap<int>(repeatingElements, new MaxComparer<int>());
                watch.Restart();
                heap.SortWithoutRecursion();
                watch.Stop();
                Console.WriteLine(" vs " + watch.Elapsed.TotalMilliseconds);

            }
        }
    }
}
