using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DesignPattern.CreationalPatterns.FactoryMethod
{
    interface Product
    {
        void GetDetails();
    }


    class Product1 : Product
    {

        public void GetDetails()
        {
            Console.WriteLine("Product1 Details are called");
        }
    }

    class Product2 : Product
    {

        public void GetDetails()
        {
            Console.WriteLine("Product2 Details are called");
        }
    }


 
    abstract class FactoryM
    {
        public abstract Product GetProduct();
    }





    class concreteFactoryforProduct1 : FactoryM
    {

        public override Product GetProduct()    
        {
            return new Product1();
        }
    }

    class concreteFactoryforProduct2 : FactoryM
    {

        public override Product GetProduct()
        {
            return new Product2();
        }
    }










    public class FactoryMethodMainProgram {
        public static void Main(string[] args)
        {
            FactoryM[] objFactories = new FactoryM[2];
            objFactories[0] = new concreteFactoryforProduct1();
            objFactories[1] = new concreteFactoryforProduct2();

            foreach (FactoryM item in objFactories)
            {
                Product objProduct = item.GetProduct();
                objProduct.GetDetails();
            }

        }
    }
    
}
