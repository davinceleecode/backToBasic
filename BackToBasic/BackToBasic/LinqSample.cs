
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Collections;
using System.IO;
using System.Net;
using System.Diagnostics;

public class LinqSample
{
    
    public static void Main()
    {
        //var people = GenerateListOfPeople();

        ////IEnumerator
        //IEnumerator bat = people.GetEnumerator();
        //while (bat.MoveNext())
        //{
        //    var x = (Person)bat.Current;
        //    Console.WriteLine(x.FirstName);
        //}
        //Console.ReadLine();


        //var peopleOverTheAgeOf30 =
        //    people.Where(x => x.Age > 30);

        //foreach (var person in peopleOverTheAgeOf30)
        //{
        //    Console.WriteLine(person.FirstName);
        //}
        //Console.ReadLine();

        Console.WriteLine("***** Fun with IEnumerable / IEnumerator *****\n");

        Garage carLot = new Garage();
        // Hand over each car in the collection?
        foreach (Car c in carLot)
        {
            Console.WriteLine("{0} is going {1} MPH",
            c.Sakyanan, c.Speed);
        }
        Console.ReadLine();


        IEnumerator B = carLot.GetEnumerator();
        B.MoveNext();
        Car myCar = (Car)B.Current;
        Console.WriteLine("{0} is going {1} MPH", myCar.Sakyanan, myCar.Speed);
        Console.ReadLine();



        #region GroupBy
        //DataTable dt = new DataTable();
        //dt.Columns.Add("User");
        //dt.Columns.Add("FunctionT");

        //dt.Rows.Add("Vincent", "FunctionA");
        //dt.Rows.Add("Flores", "FunctionA");
        //dt.Rows.Add("Hubert", "FunctionB");
        //dt.Rows.Add("Eamiguel", "FunctionB");
        //dt.Rows.Add("Mio", "FunctionC");
        //dt.Rows.Add("Patindol", "FunctionC");
        //dt.Rows.Add("Patindolx", "FunctionC");
        //dt.Rows.Add("Patindolx", "");



        //var Aux =
        //from el in dt.AsEnumerable()
        //group el by el["FunctionT"] into grp
        //where grp.FirstOrDefault().Field<string>("FunctionT") != "" &&
        //     grp.FirstOrDefault().Field<string>("FunctionT") != null
        //select new
        //{
        //    hubert = grp.FirstOrDefault().Field<string>("FunctionT"),
        //    mycount = grp.Count()
        //};

        //string a = string.Empty;
        //int b = 0;

        //foreach (var item in Aux)
        //{
        //    a = item.hubert.ToString();
        //    b = item.mycount;
        //}
        #endregion

    }
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];
        // Fill with some Car objects upon startup.
        public Garage()
        {
            carArray[0] = new Car { Sakyanan = "FeeFee", Speed = 10 };
            carArray[1] = new Car { Sakyanan = "Clunker", Speed = 55 };
            carArray[2] = new Car { Sakyanan = "Zippy", Speed = 30 };
            carArray[3] = new Car { Sakyanan = "Freed", Speed = 30 };
        }

     

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }

    public class Car
    {
        public string Sakyanan { get; set; }
        public int Speed { get; set; }
    }


    private async void getdata(WebResponse response)
    {
        var streamer = new StreamReader(response.GetResponseStream());
        string x = await streamer.ReadLineAsync();
    }


    public static List<Person> GenerateListOfPeople()
    {
        var people = new List<Person>();
        
        people.Add(new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
        people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
        people.Add(new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 });
        people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 });
        people.Add(new Person { FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24 });

        return people;
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Occupation { get; set; }
    public int Age { get; set; }
}