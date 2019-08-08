using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace BackToBasic
{
  public  class ThreadLock
    {
        static  object _object = new object();
        static int v = 0;
        static void A()
        {
            lock (_object)
            {
                v++;
                Thread.Sleep(5000);
                Console.WriteLine("Count {0}", v);
                
            }
        }
        public static void Main()
        {
            for (int i = 0; i < 100; i++)
            {
               
                ThreadStart start = new ThreadStart(A);
                new Thread(start).Start();
            }
            Console.ReadKey();
        }
    }
}
