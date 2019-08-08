using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BackToBasic.AdvancedCSharp.CovarianceContravariance
{
    delegate Mamal MyDel();
    public class Covariance
    {
        public static void Main(string[] args)
        {
            MyDel testDel = TestFunction;
            var result = Human.listOfHuman.Skip(2).Take(3);


            //using reflection stuff
            Type type = typeof(Customer);
            Console.WriteLine("Class: {0}", type.Name);
            Console.WriteLine("Namespace: {0}", type.Namespace);

            //get the properties
            PropertyInfo[] propertyInfo = type.GetProperties();
            foreach (PropertyInfo pInfo in propertyInfo)
            {
                Console.WriteLine(pInfo.Name);
            }

            //get the constructors
            ConstructorInfo[] constructorInfo = type.GetConstructors();
            Console.WriteLine("The Customer class contains the following Constructors: --");
            foreach (ConstructorInfo item in constructorInfo)
            {
                Console.WriteLine(item);
            }

          

            //get the methods
            MethodInfo[] methodInfo = type.GetMethods();
            Console.WriteLine("The methods of the Customer class are: --");
            foreach (MethodInfo item in methodInfo)
            {
                Console.WriteLine(item.Name);
            }
            




            Console.ReadKey();




        }

        static Human TestFunction()
        {
            return new Human { }; 
        }
    }

    class Mamal
    {

    }

    class Human : Mamal
    {
        public string Name { get; set; }
        public string Address { get; set; }


        private static List<Human> _listOfHuman = new List<Human>();
        public static List<Human> listOfHuman 
        {
            get {
                _listOfHuman.Add(new Human { Address = "Mocow", Name = "Josh" });
                _listOfHuman.Add(new Human { Address = "USA", Name = "Bob" });
                _listOfHuman.Add(new Human { Address = "Canada", Name = "Roy" });
                _listOfHuman.Add(new Human { Address = "Singapore", Name = "Steve" });
                _listOfHuman.Add(new Human { Address = "Malaysia", Name = "John" });
                return _listOfHuman;
            }
        }

  
    }



    
    class Customer
    {
        public Customer()
        {
            //Default constructor
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string Address { get; set; }

        public bool Validate(Customer customerObj)
        {
            //Code to validate the customer object
            return true;
        }

        
    }
}
