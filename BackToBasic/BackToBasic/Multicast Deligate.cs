using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BackToBasic
{
    public delegate void SampleDelegate();
   public class Multicast_Deligate
    {

       delegate void onChange(string one, string two);
       void test()
       {

           onChange x = new onChange(testMe1);
           ExecuteProgram("text", "test", x);

       }
       void ExecuteProgram(string one, string two, onChange X)
       {
           X(one, two);
       }
       string testMe0(string test1, string test2)
       {
           return string.Empty;
           //process 1
       }
       void testMe1(string test1, string test2)
       {
           //process 1
       }
       void testMe2(string test1, string test2)
       {
           // process 2
       }

        
	
        public static void Main()
        {
            //SampleDelegate del = new SampleDelegate(SampleMethod1);
            //del();

            SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(SampleMethod1);
            del2 = new SampleDelegate(SampleMethod2);
            del3 = new SampleDelegate(SampleMethod3);
            
            del4 = del1 + del2 + del3;
            del4(); 







            





        }


        public static void SampleMethod1()
        {
            Console.WriteLine("SampleMethod1 Invoked");
        }
        public static void SampleMethod2()
        {
            Console.WriteLine("SampleMethod2 Invoked");
        }
        public static void SampleMethod3()
        {
            Console.WriteLine("SampleMethod3 Invoked");
            Console.ReadLine();
        }
    }

   
}
