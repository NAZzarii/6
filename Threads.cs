using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    class RangeParams
    {
        public int Start;
        public int End;
    }

    static void Main()
    {
        Thread t1 = new Thread(ShowNumbers50);
        t1.Start();
        t1.Join();

        Console.Write("\nStart: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("End: ");
        int e = int.Parse(Console.ReadLine());

        Thread t2 = new Thread(ShowNumbersRange);
        t2.Start(new RangeParams { Start = s, End = e });
        t2.Join();

        Console.Write("\nThreads count: ");
        int count = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < count; i++)
        {
            Thread t = new Thread(ShowNumbersRange);
            t.Start(new RangeParams { Start = s, End = e });
        }
        Thread.Sleep(2000);

        Random rnd = new Random();
        int[] numbers = new int[10000];
        for (int i = 0; i < 10000; i++) numbers[i] = rnd.Next(1, 100001);

        Thread tShow = new Thread(() => {
            foreach (var n in numbers) Console.Write(n + " ");
            Console.WriteLine();
        });

        Thread tMax = new Thread(() => Console.WriteLine("\nMax: " + numbers.Max()));
        Thread tMin = new Thread(() => Console.WriteLine("Min: " + numbers.Min()));
        Thread tAvg = new Thread(() => Console.WriteLine("Avg: " + numbers.Average()));

        tShow.Start();
        tMax.Start();
        tMin.Start();
        tAvg.Start();

        Console.ReadKey();
    }

    static void ShowNumbers50()
    {
        for (int i = 0; i <= 50; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void ShowNumbersRange(object obj)
    {
        RangeParams p = (RangeParams)obj;
        for (int i = p.Start; i <= p.End; i++)
        {
            Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + ": " + i);
        }
    }
}
