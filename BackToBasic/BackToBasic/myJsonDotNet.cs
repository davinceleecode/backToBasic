using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic
{
   public class myJsonDotNet
    {

        class BlogSites
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }
        
        public static void Main()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "C-sharpcorner",
                Description = "Share Knowledge"
            };
            string jsonData = JsonConvert.SerializeObject(bsObj);


            BlogSites xbsObj = JsonConvert.DeserializeObject<BlogSites>(jsonData);
            Console.WriteLine(xbsObj.Name);
            Console.ReadKey();
        }
    }
}
