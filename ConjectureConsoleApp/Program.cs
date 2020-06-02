using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// Enter your name:  Yossi Rotenstreich

namespace ConjectureConsoleApp
{
    class Program
    {
        private static volatile int counter = 4;
        private static object CounterLock = new Object();
        private static int LIMIT;
        private static ConcurrentDictionary<int, Tuple<int, int>> results = new ConcurrentDictionary<int, Tuple<int, int>>();
        private static bool cancelRequested;

        static void Main(string[] args)
        {
            Console.WriteLine("Up to what number would you like to confirm the Goldbach conjecture?");
            LIMIT = int.Parse(Console.ReadLine());
            Console.WriteLine("How many threads would you like to use?");
            int threadcount = int.Parse(Console.ReadLine());
            Console.WriteLine("Beginning calculations, you may press 'enter' anytime to cancel");

            Task[] tasks = new Task[threadcount];

            Thread listener = new Thread(Listen);
            listener.Start();

            for (int i = 0; i < threadcount; i++)
            {
                Task t = Task.Factory.StartNew(FindPairsForNumbers);
                tasks[i] = t;
            }

            Task.WaitAll(tasks);

            listener.Abort();
            listener.Join();

            Console.WriteLine(String.Join("\n",
                results.OrderBy(kvp => kvp.Key).Select(kvp => $"{kvp.Key}: {kvp.Value.Item1} + {kvp.Value.Item2}")));

            Console.WriteLine("Press enter to exit the program");
            Console.ReadLine();
        }

        private static void FindPairsForNumbers()
        {
            while (counter <= LIMIT && !cancelRequested)
            {
                int currNumber;
                currNumber = Interlocked.Exchange(ref counter, counter + 2);
                /*lock(CounterLock)
                {
                    currNumber = counter;
                    counter += 2;
                }*/
                

                for (int i = 2; i < currNumber; i++)
                {
                    if (!IsPrime(i))
                        continue;
                    for (int j = 2; j < currNumber; j++)
                    {
                        if (!IsPrime(j))
                            continue;
                        if (i + j == currNumber)
                        {
                            results[currNumber] = new Tuple<int, int>(i, j);
                            goto PAIRFOUND;
                        }
                    }
                }

                PAIRFOUND: ;
            }
        }

        private static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        private static void Listen()
        {
            Console.ReadLine();
            cancelRequested = true;
        }
    }
}
