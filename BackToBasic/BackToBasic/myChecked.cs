using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic
{
   public class myChecked
    {
      // int rio = 0;
       public static void Main()
       {
        
           string output = string.Format("temareture at {");

           checked
           {
               int b = int.MaxValue;
               Console.WriteLine(b);               // b=255
               try
               {
                   int x = b * 100;

                   Console.WriteLine(b++);
                   Console.ReadKey();
               }
               catch (OverflowException e)
               {
                   Console.WriteLine(e.Message);   // "Arithmetic operation resulted in an overflow." 
                   Console.ReadKey();
                   // b = 255
               }
           }
       }
    }
}
