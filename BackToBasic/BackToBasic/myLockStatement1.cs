using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace BackToBasic
{
    
    public class myLockStatement1
    {
        
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[10];
            Account acc = new Account(1000);
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ThreadStart(acc.DoTransactions));
                threads[i] = t;
            }
            for (int i = 0; i < 10; i++)
            {
                threads[i].Start();
            }
            Console.ReadKey();
        }

    }

   

    public class Account
    {
        private Object thislock = new object();
        int balance;

        Random r = new Random();

        public Account(int initial)
        {
            balance = initial;
        }


        int Withdraw(int amount)
        {
            //if (balance < 0)
            //{
            //    throw new Exception("Negative Balance");
            //}

            lock (thislock)
            {
                if (balance >= amount)
                {
                    Console.WriteLine("Balance before Withdrawal: {0}", balance);
                    Console.WriteLine("Amount to Withdraw: {0}", amount);
                    balance = balance - amount;
                    Console.WriteLine("Balance after Withdrawal: {0}", balance);
                    return amount;
                }
                else
                {
                    return 0;
                }
            }
        }

        public void DoTransactions()
        {
            for (int i = 0; i < 100; i++)
            {
                Withdraw(r.Next(1, 100));
            }
        }
    }
}
