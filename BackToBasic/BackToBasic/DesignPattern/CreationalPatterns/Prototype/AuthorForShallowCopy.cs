using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DesignPattern.CreationalPatterns.Prototype
{
    public class AuthorForShallowCopy : ICloneable
    {
        public string Name { get; set; }
        public string TwitterAccount { get; set; }
        public string Website { get; set; }
        public Address HomeAddress { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class CloneClient
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy Sample\n");

            AuthorForShallowCopy o = new AuthorForShallowCopy()
            {
                Name = "Vincent Lee",
                TwitterAccount = "https://twitter.com/m1rakuru22",
                Website = "fb.com/m1rakuru22",
                HomeAddress = new Address()
                {
                     City = "Ormoc",
                     State = "PH"
                }
            };

            Console.WriteLine("Original Copy");
            Console.WriteLine(o);


            AuthorForShallowCopy clonedObject = (AuthorForShallowCopy)o.Clone();
            Console.WriteLine("\nCloned Copy");
            Console.WriteLine(clonedObject);

            Console.WriteLine("\nMake Changes to clone copy address");

            clonedObject.Name = "Mr. Changer";
            clonedObject.TwitterAccount = "twitter/MrChanger";
            clonedObject.Website = "Changer.com";
            clonedObject.HomeAddress.State = "Changer";
            clonedObject.HomeAddress.City = "Changer";

            Console.WriteLine("\nCloned Copy");
            Console.WriteLine(clonedObject);

            Console.WriteLine("\nOriginal Copy");
            Console.WriteLine(o);

        }
    }
}
