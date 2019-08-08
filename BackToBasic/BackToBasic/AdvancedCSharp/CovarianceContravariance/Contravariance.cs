using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.AdvancedCSharp.CovarianceContravariance
{

    public class Contravariance
    {
        private delegate void MyDel(Dog d);
        public static void Main(string[] args)
        {
            MyDel testDel = TestFunctionContra;
            int x = Convert.ToInt32("string");
        }

        static void TestFunctionContra(Animal a)
        {
            
        }

         


        class Animal
        {

        }

        class Dog : Animal
        {

        }
    }

    
}
