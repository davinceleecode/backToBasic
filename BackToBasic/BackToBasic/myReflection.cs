using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BackToBasic
{
    public class myReflection
    {

        public static void Main(string[] args)
        {
            //var assembly = Assembly.GetExecutingAssembly();
            //Console.WriteLine(assembly.FullName);

            //var types = assembly.GetTypes();
            //foreach (var type in types)
            //{
            //    Console.WriteLine("Type: " + type.Name);

            //    var props = type.GetProperties();
            //    foreach (var prop in props)
            //    {
            //        Console.WriteLine("\tProperty: " + prop.Name + " PropertyType: " + prop.PropertyType);
            //    }


            //    var fields = type.GetFields();
            //    foreach (var field in fields)
            //    {
            //        Console.WriteLine("\tField: " + field.Name);
            //    }

            //    var methods = type.GetMethods();
            //    foreach (var method in methods)
            //    {
            //        Console.WriteLine("\tMethod: " + method.Name);
            //    }
            //}





            var sample = new Samples { Name = "Vincent", Age = 28 };
            var sampleType = typeof(Samples); //sample.GetType(); //compile type operation


            var nameProperty = sampleType.GetProperty("Name");
            Console.WriteLine("Property: " + nameProperty.GetValue(sample));

            var method = sampleType.GetMethod("MyMethod");
            method.Invoke(sample, null); ;
            Console.ReadKey();
        }

        public class Samples
        {
            public string Name { get; set; }
            public int Age;

            public void MyMethod()
            {
                Console.WriteLine("Hello from MyMethod");
            }
        }
    }
}
