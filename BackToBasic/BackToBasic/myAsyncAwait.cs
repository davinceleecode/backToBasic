using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic
{
  public class myAsyncAwait
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Handle user input.
                string result = Console.ReadLine();
                Console.WriteLine("You typed: " + result);
                //Start computation.
                Example();
                Console.WriteLine("You typed: " + result);
                
            }
        }




        static async void Example()
        {
            // This method runs asynchronously.
            int t = await Task.Run(() => Allocate());
            Console.WriteLine("Compute: " + t);
        }

        static int Allocate()
        {
            int size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    string value = i.ToString();
                    if (value == null)
                    {
                        return 0;
                    }
                    size += value.Length;
                }
            }
            return size;
        }
    }

  public class Example
  {
      public static void Main()
      {
          DisplayCurrentInfo().Wait();

         
      }


      static async Task DisplayCurrentInfo()
      {
          await WaitAndApologize();
          Console.WriteLine("Today is {DateTime.Now:D}");
          Console.WriteLine("The current time is {DateTime.Now.TimeOfDay:t}");
          Console.WriteLine("The current temperature is 76 degrees.");
          Console.ReadKey();
      }

      static async Task WaitAndApologize()
      {
          Console.WriteLine("\nSorry for the delay. . . .\n");
          await Task.Delay(2000);
          
      }
  }
}
