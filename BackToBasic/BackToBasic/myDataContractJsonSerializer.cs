using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Reflection;

namespace BackToBasic
{
    public class myDataContractJsonSerializer
    {

        [DataContract]
        class BlogSite
        {
            [DataMember]
            public string Name { get; set; }

            [DataMember]
            public string Description { get; set; }
        }


        public static void Main()
        {

            //Serialization
            BlogSite bsObj = new BlogSite()
            {
                Name = "C-SharpYouCrackedMeUp",
                Description = "Share Knowledge"
            };

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(BlogSite));
            MemoryStream msObj = new MemoryStream();
            js.WriteObject(msObj, bsObj);
            msObj.Position = 0;
            StreamReader sr = new StreamReader(msObj);

            string json = sr.ReadToEnd();

            sr.Close();
            msObj.Close();

            

            //Deserialization
            json = "{\"Description\":\"Share Knowledge\",\"Name\":\"C-sharpcorner\"}";
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(BlogSite));
                BlogSite bsObj2 = (BlogSite)deserializer.ReadObject(ms);
                Console.WriteLine("Name: {0}", bsObj2.Name);
                Console.WriteLine("Description: {0}", bsObj2.Description);
                Console.ReadKey();
            }

        }

    }
}
