using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
namespace BackToBasic
{
   public class myJavaScriptJsonSerializer
    {
        class BlogSites
        {
            public string Name { get; set; }
            public string Description { get; set; }

        }

        public static void Main()
        {
            //Serialization
            BlogSites bsObj = new BlogSites()
            {
                Name = "YouCrackedMeUp",
                Description = "Share Knowledge"
            };

            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(bsObj);


            //Deserialization
            // Deserializing json data to object  
            BlogSites blogObject = js.Deserialize<BlogSites>(jsonData);
            string name = blogObject.Name;
            string description = blogObject.Description;

            // Other way to whithout help of BlogSites class  
            dynamic blgObject = js.Deserialize<dynamic>(jsonData);
            string xname = blgObject["Name"];
            string xdescription = blgObject["Description"];

        }

    }
}
