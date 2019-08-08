using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BackToBasic
{
    public class myTPL
    {
        public static void Main()
        {
            #region Parallel Task and cancellation Token
            var source = new CancellationTokenSource();
            try
            {
                var t1 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(1, 1501, source.Token)).ContinueWith((prevTask) => DoSomeOtherImportantWork(1, 1000));
                var t2 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(2, 1503, source.Token));
                var t3 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(3, 2002, source.Token));

                var taskList = new List<Task> { t1, t2, t3 };

                source.Cancel();

                Task.WaitAll(taskList.ToArray());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.GetType());
            }


            #endregion



            #region comparison using C# For vs Parallel. For
            Console.WriteLine("Using C# For Loop \n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i = {0}, thread = {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
            Console.WriteLine("\nUsing Prallel.For \n");
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("i = {0}, thread = {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });
            #endregion

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }


        static void DoSomeVeryImportantWork(int id, int sleepTime, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requested.");
                token.ThrowIfCancellationRequested();
            }
            Console.WriteLine("task {0} is beginning", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} has completed", id);
        }


        static void DoSomeOtherImportantWork(int id, int sleepTime)
        {
            Console.WriteLine("task {0} is beginning more work", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} has completed more work", id);
        }
    }
}
