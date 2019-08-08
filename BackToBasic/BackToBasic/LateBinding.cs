using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BackToBasic
{
  public class LateBinding
    {

        private static void Main()
        {

            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executingAssembly.GetType("BackToBasic.Customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");


            string[] parameters = new string[2];
            parameters[0] = "Vincent";
            parameters[1] = "Lee";

            string fullname = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name = {0}", fullname);
            Console.ReadLine();
        }
    }

    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
