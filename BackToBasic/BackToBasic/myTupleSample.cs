using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Console;

namespace BackToBasic
{

    public class myTupleSample
    {

        //tradition way of using tuple
        static Tuple<double, double> GetTotalAndProduct(double no1, double no2)
        {
            return Tuple.Create(no1 + no2, no1 * no2);
        }



        public static void Main(string[] args)
        {



            Console.WriteLine("  \"vincent\" ");


            var tp = GetTotalAndProduct(10, 20);
            Console.WriteLine("$Total =" + tp.Item1 + ", Product =" + tp.Item2.ToString() + "");




            var listEmployee = new List<Tuple<int, string, string>>
            {
                Tuple.Create(1,"Vincent Lee Flores", "Urgello"),
                Tuple.Create(2,"Rio Cino", "Mandue"),
                Tuple.Create(3,"Romeo", "Patindol")
            };

            foreach (Tuple<int, string, string> item in listEmployee)
            {

            }

        }

        //c# 7.3
        //unsafe void M<D, E, T>(D d, E e, T* pointer)
        //    where D : Delegate
        //    where E : Enum
        //    where T : unmanaged
        //    {

        //}




        //introducing tuple for c# 7
        //public static (double total, double product) GetTotalAndProductUsingTuples(double no1, double no2)
        //{

        //    return 0;
        //}


        //ref in method
        //public static ref int PassingAnObject(ref int b)
        //{
        //    ref int xxx = b;

        //}



        //ref
        //int a = 1, b = 10;
        //Console.WriteLine($"a = {a}, b = {b}");


        //in - still passing as a reference 
        //locking the reference not allowing change the ref 
        //static int OrMaybe(this ref int x, in int y)
        //{

        //}


        //allow enum constraints
        //public static Dictionary<int, string> EnumnamedValues<T>() where T : System.Enum
        //{
        //    var result = new Dictionary<int, string>();
        //    var values = Enum.GetValues(typeof(T));

        //    foreach (var item in values)
        //        result.Add(item, Enum.GetName(typeof(T), item));
        //    result result;
        //}



        //Span
        //int[] array = new int[10];
        //Span<int> span = array.AsPan();
        //Span<int> slice = span.Slice(3, 5);
        //for(int i = 0; i < 10; i++) span[i] = i;
        //foreach(int v in slice) WriteLine(v);


        //null safe for all variable types


        //case patterns
        //public class Person
        //{


        //}
        //public class Student : Person
        //{
        //    public int id { get; set; }
        //    public string name { get; set; }
        //}

        //NEW RETURN SWITCH
        //static string M(Person person)
        //{
        //    return person switch
        //    {
        //        Student s =>  $"id: " {s.id}, Name of {s.name}",
        //        Person p when p.id == "lee" =>  $"id: " {p.id}, Name of {p.name}",
        //            _ => "asdadsadasds"
        //    };
        //}
        // autocheck pattern { LastName: "vincent", FirstName: var fn } => $"Please , enroll, {fn}",
        // _ => "Come back next year!"

        // Professor (_, var ln, var (_, ln, _)) => $"{fn}, Student of Dr. {ln}"

        //RANGE
        // string text = "'" + "Vincent" + "'";
        // text = text[1..^1]

    }
}
