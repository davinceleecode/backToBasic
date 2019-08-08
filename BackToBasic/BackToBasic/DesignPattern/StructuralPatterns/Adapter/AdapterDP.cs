using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DesignPattern.StructuralPatterns.Adapter
{
    public class AdapterDP
    {
    }

    public interface Itarget{
        List<string> GetEmployeeList();
    }

    public class ThirdPartyBillingSystem
    {
        private Itarget employeeSource;

        public ThirdPartyBillingSystem(Itarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }


        public void ShowEmployeeList()
        {
            List<string> employee = employeeSource.GetEmployeeList();

            Console.WriteLine("###### Employee List ######");
            foreach (var item in employee)
            {
                Console.Write(item);
            }
        }
    }

    public class HRSystem
    {
        public string[][] GetEmployees()
        {
            string[][] employess = new string[4][];

            employess[0] = new string[] { "100", "Deepak", "Team Leader" };
            employess[1] = new string[] { "101", "Rohit", "Developer" };
            employess[2] = new string[] { "102", "Vincent Lee", "Developer" };
            employess[3] = new string[] { "103", "Dev", "Tester" };
            return employess;
        }
    }

    public class EmployeeAdapter : HRSystem, Itarget
    {

        public List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            string[][] employees = GetEmployees();
            foreach (string[] employee in employees)
            {
                employeeList.Add(employee[0]);
                employeeList.Add(",");
                employeeList.Add(employee[1]);
                employeeList.Add(",");
                employeeList.Add(employee[2]);
                employeeList.Add("\n");
            }
            return employeeList;
        }
    }

    public class AdpaterDP
    {
        static void Main(string[] args)
        {
            Itarget Itarget = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
            client.ShowEmployeeList();
            Console.ReadKey();
        }
    }
}
