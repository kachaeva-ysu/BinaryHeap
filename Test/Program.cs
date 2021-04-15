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
            int n = 100;
            Console.WriteLine(n + " элементов");
            var rnd = new Random();
            Stopwatch watch = new Stopwatch();

            int[] sortedElements = new int[n];
            watch.Start();
            for (int i = 0; i < n; i++)
                sortedElements[i] = i;
            watch.Stop();
            Console.WriteLine("Отсортированная последовательность: " + watch.Elapsed.TotalMilliseconds);

            int[] partiallySortedElements = new int[n];
            watch.Restart();
            for(int i=0;i<n/2;i++)
                partiallySortedElements[i] = i;
            for (int i = n / 2; i < n; i++)
                partiallySortedElements[i] = rnd.Next(0, n);
            watch.Stop();
            Console.WriteLine("Частично отсортированная последовательность: " + watch.Elapsed.TotalMilliseconds);

            HashSet<int> nonRepeatingElements = new HashSet<int>();
            watch.Restart();
            while (nonRepeatingElements.Count < n)
                nonRepeatingElements.Add(rnd.Next(0, n));
            watch.Stop();
            Console.WriteLine("Случайная последовательность со всеми различными элементами: " + watch.Elapsed.TotalMilliseconds);

            int[] repeatingElements = new int[n];
            watch.Restart();
            for (int i = 0; i < n; i++)
                repeatingElements[i] = rnd.Next(0, n);
            watch.Stop();
            Console.WriteLine("Случайная последовательность с повторяющимися элементами: " + watch.Elapsed.TotalMilliseconds);

            Console.WriteLine();

            n = 1000;
            Console.WriteLine(n + " элементов");

            sortedElements = new int[n];
            watch.Start();
            for (int i = 0; i < n; i++)
                sortedElements[i] = i;
            watch.Stop();
            Console.WriteLine("Отсортированная последовательность: " + watch.Elapsed.TotalMilliseconds);

            partiallySortedElements = new int[n];
            watch.Restart();
            for (int i = 0; i < n / 2; i++)
                partiallySortedElements[i] = i;
            for (int i = n / 2; i < n; i++)
                partiallySortedElements[i] = rnd.Next(0, n);
            watch.Stop();
            Console.WriteLine("Частично отсортированная последовательность: " + watch.Elapsed.TotalMilliseconds);

            nonRepeatingElements = new HashSet<int>();
            watch.Restart();
            while (nonRepeatingElements.Count < n)
                nonRepeatingElements.Add(rnd.Next(0, n));
            watch.Stop();
            Console.WriteLine("Случайная последовательность со всеми различными элементами: " + watch.Elapsed.TotalMilliseconds);

            repeatingElements = new int[n];
            watch.Restart();
            for (int i = 0; i < n; i++)
                repeatingElements[i] = rnd.Next(0, n);
            watch.Stop();
            Console.WriteLine("Случайная последовательность с повторяющимися элементами: " + watch.Elapsed.TotalMilliseconds);

            Console.WriteLine();

            n = 10000;
            Console.WriteLine(n + " элементов");

            sortedElements = new int[n];
            watch.Start();
            for (int i = 0; i < n; i++)
                sortedElements[i] = i;
            watch.Stop();
            Console.WriteLine("Отсортированная последовательность: " + watch.Elapsed.TotalMilliseconds);

            partiallySortedElements = new int[n];
            watch.Restart();
            for (int i = 0; i < n / 2; i++)
                partiallySortedElements[i] = i;
            for (int i = n / 2; i < n; i++)
                partiallySortedElements[i] = rnd.Next(0, n);
            watch.Stop();
            Console.WriteLine("Частично отсортированная последовательность: " + watch.Elapsed.TotalMilliseconds);

            nonRepeatingElements = new HashSet<int>();
            watch.Restart();
            while (nonRepeatingElements.Count < n)
                nonRepeatingElements.Add(rnd.Next(0, n));
            watch.Stop();
            Console.WriteLine("Случайная последовательность со всеми различными элементами: " + watch.Elapsed.TotalMilliseconds);

            repeatingElements = new int[n];
            watch.Restart();
            for (int i = 0; i < n; i++)
                repeatingElements[i] = rnd.Next(0, n);
            watch.Stop();
            Console.WriteLine("Случайная последовательность с повторяющимися элементами: " + watch.Elapsed.TotalMilliseconds);

            Console.WriteLine();

            n = 100000;
            Console.WriteLine(n + " элементов");

            sortedElements = new int[n];
            watch.Start();
            for (int i = 0; i < n; i++)
                sortedElements[i] = i;
            watch.Stop();
            Console.WriteLine("Отсортированная последовательность: " + watch.Elapsed.TotalMilliseconds);

            partiallySortedElements = new int[n];
            watch.Restart();
            for (int i = 0; i < n / 2; i++)
                partiallySortedElements[i] = i;
            for (int i = n / 2; i < n; i++)
                partiallySortedElements[i] = rnd.Next(0, n);
            watch.Stop();
            Console.WriteLine("Частично отсортированная последовательность: " + watch.Elapsed.TotalMilliseconds);

            nonRepeatingElements = new HashSet<int>();
            watch.Restart();
            while (nonRepeatingElements.Count < n)
                nonRepeatingElements.Add(rnd.Next(0, n));
            watch.Stop();
            Console.WriteLine("Случайная последовательность со всеми различными элементами: " + watch.Elapsed.TotalMilliseconds);

            repeatingElements = new int[n];
            watch.Restart();
            for (int i = 0; i < n; i++)
                repeatingElements[i] = rnd.Next(0, n);
            watch.Stop();
            Console.WriteLine("Случайная последовательность с повторяющимися элементами: " + watch.Elapsed.TotalMilliseconds);

            Console.WriteLine();

            n = 1000000;
            Console.WriteLine(n + " элементов");

            sortedElements = new int[n];
            watch.Start();
            for (int i = 0; i < n; i++)
                sortedElements[i] = i;
            watch.Stop();
            Console.WriteLine("Отсортированная последовательность: " + watch.Elapsed.TotalMilliseconds);

            partiallySortedElements = new int[n];
            watch.Restart();
            for (int i = 0; i < n / 2; i++)
                partiallySortedElements[i] = i;
            for (int i = n / 2; i < n; i++)
                partiallySortedElements[i] = rnd.Next(0, n);
            watch.Stop();
            Console.WriteLine("Частично отсортированная последовательность: " + watch.Elapsed.TotalMilliseconds);

            nonRepeatingElements = new HashSet<int>();
            watch.Restart();
            while (nonRepeatingElements.Count < n)
                nonRepeatingElements.Add(rnd.Next(0, n));
            watch.Stop();
            Console.WriteLine("Случайная последовательность со всеми различными элементами: " + watch.Elapsed.TotalMilliseconds);

            repeatingElements = new int[n];
            watch.Restart();
            for (int i = 0; i < n; i++)
                repeatingElements[i] = rnd.Next(0, n);
            watch.Stop();
            Console.WriteLine("Случайная последовательность с повторяющимися элементами: " + watch.Elapsed.TotalMilliseconds);

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
