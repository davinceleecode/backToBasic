using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackToBasic
{
   public class TestThreading
    {

        public static void Main()
        {


            try
            {
                var source = new CancellationTokenSource();
                //source.Cancel();
                var t1 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(1, 1500, source.Token)).ContinueWith((prevTask) => DoSomeOtherVeryImportantWork(1, 1000, source.Token));
                var t2 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(2, 3000, source.Token)).ContinueWith((prevTask) => DoSomeOtherVeryImportantWork(2, 1000, source.Token));
                var t3 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(3, 1000, source.Token)).ContinueWith((prevTask) => DoSomeOtherVeryImportantWork(3, 1000, source.Token));

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.GetType());
            }



            //var tasklist = new List<Task> { t1, t2, t3 };
            //Task.WaitAll(tasklist.ToArray());


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Doing some other work");
            //    Thread.Sleep(250);
            //    Console.WriteLine("i = {0}", i);
            //}

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();




            //var intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Parallel.ForEach(intList, i => Console.WriteLine(i));


            //Console.WriteLine("Press any key to quit");
            //Console.ReadKey();

        }

        static void DoSomeVeryImportantWork(int id, int sleepTime, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requested");
                return;
            }

            Console.WriteLine("task {0} is beginning",id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} has completed",id);
        }

        static void DoSomeOtherVeryImportantWork(int id, int sleepTime, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requested");
                //token.ThrowIfCancellationRequested();
                return;
            }
            Console.WriteLine("task {0} is beginning more work", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} has completed more work", id);
        }
    }
}
