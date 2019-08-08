using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BackToBasic.AdvancedCSharp
{
    public class ConcurrentGenericCollection
    {

        private static ConcurrentDictionary<int, string> t = new ConcurrentDictionary<int, string>();
        static void Main(string[] args)
        {
             
            Console.WriteLine("hello world");

            Thread o1 = new Thread(M1);
            Thread o2 = new Thread(M2);
            
            o1.Start();
            o2.Start();

           
            Console.ReadLine();
        }

        static void M1()
        {
            for (int i = 0; i < 100; i++)
            {
                t.TryAdd(i, "M1 added " + i);
                Console.WriteLine("M1" + i);
            }
        }

        static void M2()
        {
            for (int i = 0; i < 100; i++)
            {
                t.TryAdd(i, "M2 added " + i);
                Console.WriteLine("M2" + i);

            }
        }

       
    }
     
}
