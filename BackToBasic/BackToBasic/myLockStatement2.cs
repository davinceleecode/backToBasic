using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;

namespace BackToBasic
{
    public class myLockStatement2
    {
        static void Main(string[] args)
        {
            LockTest L = new LockTest();
            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(() => L.StartThread());
                threads[i] = t;
            }

            for (int i = 0; i < 10; i++)
            {
                threads[i].Start();
            }
        }
    }

    public class LockTest
    {
     

        private Object thislock = new Object();
        private int me = 0;
        public void StartThread()
        {
            lock (thislock)
            {
                me++;
                PrintString(me.ToString());
            }

        }

        public void PrintString(string myString)
        {

            for (int i = 0; i < 1000000; i++)
            {
                if (myString == "5")
                {
                    for (int k = 0; k < 1000; k++)
                    {

                    }
                }
            }
            Console.WriteLine("Your String: {0}", myString);
        }
    }
}
