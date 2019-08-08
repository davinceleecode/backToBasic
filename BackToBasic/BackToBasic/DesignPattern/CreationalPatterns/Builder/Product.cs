using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DesignPattern.CreationalPatterns.Builder
{
    class Product
    {
        public List<string> Parts = new List<string>();
    }


    abstract class Builder
    {
        public abstract void BuildPart();
        public abstract Product Construct();

    }

    class ConcreteBuilderr : Builder
    {
        private Product product = new Product();
        private int part = 0;

        public override void BuildPart()
        {
            product.Parts.Add("Adding part #" + (part++));
        }

        public override Product Construct()
        {
            return product;
        }
    }

    class Director
    {
        private Builder builder = new ConcreteBuilderr();
        public Product Constructor()
        {
            for (int i = 0; i < 5; i++)
                builder.BuildPart();

            return builder.Construct();
        }
    }

    class ProductMainProgram {
        public static void Main(string[] args)
        {
            var director = new Director();
            var product = director.Constructor();
            product.Parts.ForEach((part) => Console.WriteLine(part));
            Console.ReadKey();
        }
    }
    
}
