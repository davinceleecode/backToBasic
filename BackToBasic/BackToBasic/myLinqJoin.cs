using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic
{
   public class myLinqJoin
    {

       public static void Main()
       {
           // Array 1
           var ints1 = new int[3];
           ints1[0] = 4;
           ints1[1] = 3;
           ints1[2] = 0;

           // Array 2.
           var ints2 = new int[3];
           ints2[0] = 5;
           ints2[1] = 4;
           ints2[2] = 2;

           {
               // Join with method call.
               var result = ints1.Join<int, int, int, int>(ints2,
                   x => x + 1,
                   y => y,
                   (x, y) => x);

               //Display results.
               foreach (var item in result)
               {
                   Console.WriteLine(item);
               }
               Console.ReadKey();
           }

           {

               var result = from t in ints1
                            join x in ints2 on t equals x
                            select t;

               foreach (var item in result)
               {
                   Console.WriteLine(item);
               }
               Console.ReadKey();
           }


           List<Customers> ListOfCustomers = new List<Customers>();

           ListOfCustomers.Add(new Customers
           {
               CustomerName = "Vincent",
               CustomerOrder = new List<Order>() 
               { 
                   new Order 
                   { 
                       Menu = "Chicken", OrderDate = 2015
                   } 
               }
           });
           
           ListOfCustomers.Add(new Customers
           {
               CustomerName = "Lee",
               CustomerOrder = new List<Order>() 
               { 
                   new Order 
                   { 
                       Menu = "Pig", OrderDate = 2016
                   } 
               }
           });

           ListOfCustomers.Add(new Customers
           {
               CustomerName = "Flores",
               CustomerOrder = new List<Order>() 
               { 
                   new Order 
                   { 
                       Menu = "Frog", OrderDate = 2017
                   } 
               }
           });


           List<Customers> test = ListOfCustomers.Where(c => c.CustomerOrder.Any(o => o.OrderDate == 2015)).ToList();
           foreach (var item in test)
           {
               Console.WriteLine(item.CustomerName.ToString() + item.CustomerOrder.FirstOrDefault().Menu.ToString() + item.CustomerOrder.FirstOrDefault().OrderDate.ToString());
           }

       }
    }

   public class Customers
   {
       public string CustomerName { get; set; }

       public List<Order> CustomerOrder { get; set; }

   }

   public class Order
   {
       public int OrderDate{get;set;}
       public string Menu { get; set; }
   }
}
