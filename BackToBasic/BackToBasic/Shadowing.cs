using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic
{
    public class Shadowing
    {
       //base
        class InventoryAndSales
        {
            public int InvoiceNumber(int b)
            {
                return b;
            }
        }

        //if someone calls for this class then the InvoiceNumber type is now object 
        class NewInventoryAndSales : InventoryAndSales
        {
            public new string InvoiceNumber(int x)
            {
                return "";
            }
        }



        public static void Main(string[] args)
        {
            NewInventoryAndSales x = new NewInventoryAndSales();
            x.InvoiceNumber(10);
        }
        
        
    } 
}
