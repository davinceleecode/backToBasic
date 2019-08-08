using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace BackToBasic.AdvancedCSharp
{
    public class Memoization
    {
        public static long FindPrimeNumber(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1;
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                    count++;
                a++;
            }
            return (--a);
        }

        public static void Main(string[] args)
        {
            int reps = 5;
            int its = 50000;

            Measure("baseline", reps, () =>
            {
                for (int i = 0; i <its; i++)
                {
                    FindPrimeNumber(45);
                }
            });

            var memFunc = utils.Memoize<int, long>(FindPrimeNumber);
            Measure("memo", reps, () =>
            {
                for (int i = 0; i < its; i++)
                {
                    memFunc(45);
                }
            });
            Console.ReadKey();
        }
        public static void Measure(string what, int reps, Action action)
        {
            action();

            double[] results = new double[reps];
            for (int i = 0; i < reps; ++i)
            {
                Stopwatch sw = Stopwatch.StartNew();
                action();
                results[i] = sw.Elapsed.TotalMilliseconds;
            }

            Console.WriteLine("{0} - AVG = {1}, MIN = {2}, MAX = {3}",
                what, results.Average(), results.Min(), results.Max());
           
        }
    }

    public static class utils
    {
        public static Func<Arg, Ret> Memoize<Arg, Ret>(this Func<Arg, Ret> functor)
        {
            var memo_table = new ConcurrentDictionary<Arg, Ret>();

            return arg0 =>
            {
                Ret func_return_val;

                if (!memo_table.TryGetValue(arg0, out func_return_val))
                {
                    func_return_val = functor(arg0);
                    memo_table.TryAdd(arg0, func_return_val);
                }

                return func_return_val;
            };

        }
    }
}
