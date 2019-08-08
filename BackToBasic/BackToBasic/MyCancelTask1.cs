using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BackToBasic
{
    class MyCancelTask1
    {
         
        static void Main()
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            Task t1 = Task.Factory.StartNew(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("* ");
                    Thread.Sleep(1000);
                }
            },
            token);
            Console.WriteLine("Press any key to stop the task\n");
            Console.ReadKey();
            tokenSource.Cancel();
            Console.WriteLine("\n\nPress any key to stop the task");
            Console.ReadKey(); 
        }

    }
}
