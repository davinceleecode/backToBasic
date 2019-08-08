using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace BackToBasic
{
    public delegate bool IsPromotable(Person name);
    public delegate bool IsPromotables(Person name);
    public class MultiThread
    {
        //public static void DisplayZero()
        //{
        //    for (int i = 0; i < 5000; i++)
        //    {
        //        Console.Write("0");
        //    }
        //}


        //public static void DisplayOne()
        //{
        //    for (int i = 0; i < 5000; i++)
        //    {
        //        Console.Write("1");
        //    }
        //}

        //public delegate void PrintDetails(string Details);




        //public static void Hello(string strMsg)
        //{
        //    Console.Write(strMsg);

        //}


        public static void Main()
        {

            //string time = "09:01:00 AM";

            //DateTime  xxxx = DateTime.ParseExact(time, "HH:mm:ss tt", System.Globalization.CultureInfo.CurrentCulture);

            //DateTime d = new DateTime();
            //d.AddHours(xxxx.Hour);


            //var timespan = new TimeSpan(3, 0, 0);
            //var output = new DateTime().Add(timespan).ToString("hh:mm tt");


            string s = "5:19:41 PM";
            DateTime t = DateTime.ParseExact(s, "h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            //if you really need a TimeSpan this will get the time elapsed since midnight:
            int y = t.Hour;



            IsPromotable IsPromotable = new IsPromotable(Promote);
            Person.PromotePerson(GenerateListOfPerson(), IsPromotable);



            //PrintDetails xx = new PrintDetails(Hello);
            //xx("Hello Vincent");


            var list = GenerateListOfPerson();
            var City = from x in list
                       group x by x.address into g
                       where g.FirstOrDefault().age <= 31
                       select new { g.FirstOrDefault().Name, g.FirstOrDefault().address };
            City.ToList().ForEach(m => Console.WriteLine(m.Name.ToString() + "" + m.address.ToString()));




            //Console.ReadLine();

            //Thread thZero = new Thread(DisplayZero);
            //Thread thOne = new Thread(DisplayOne);
            //thZero.Priority = ThreadPriority.Highest;
            //thOne.Priority = ThreadPriority.Lowest;

            //thZero.Start();
            //thOne.Start();

            //thZero.Join();
            //thOne.Join();


            //MessageBox.Show("Done");

            //Console.ReadLine();
        }


        public static List<Person> GenerateListOfPerson()
        {
            var list = new List<Person>();
            list.Add(new Person { Name = "Vincent Lee Flores", age = 5, address = "Urgello", occupation = "Software Engineer" });
            list.Add(new Person { Name = "Rio Cinco", age = 6, address = "Mandaue City", occupation = "Software Engineer" });
            list.Add(new Person { Name = "Glenn Amora", age = 4, address = "Mingla", occupation = "Software Engineer" });
            list.Add(new Person { Name = "Romeo Patindol", age = 5, address = "Mandaue City", occupation = "Software Engineer" });
            return list;
        }




        public static bool Promote(Person person)
        {
            if (person.age >= 5)
                return true;
            else
                return false;
        }

        public static bool Promote(int person)
        {
            if (person <= 5)
                return true;
            else
                return false;
        }

    }






    public class Person
    {
        public string Name { get; set; }
        public string occupation { get; set; }
        public string address { get; set; }
        public int age { get; set; }

        public static void PromotePerson(List<Person> PromotionList, IsPromotable IsPromotable)
        {
            foreach (var item in PromotionList)
            {
                if (IsPromotable(item))
                {
                    Console.WriteLine(item.Name + " promoted.");
                }
            }
            Console.ReadLine();
        }
    }

}
