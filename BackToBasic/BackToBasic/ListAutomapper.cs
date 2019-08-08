using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BackToBasic
{
    public class ListAutomapper
    {

        public class ClassA
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public int Phone { get; set; }
        }
        public class ClassB
        {
            public string Name { get; set; }
            public string Address { get; set; }
        }


        public static void Main(string[] args)
        {
            List<ClassA> GroupA = new List<ClassA>();
            GroupA.Add(new ClassA { Name = "Romeo", Address = "Mandaue", Phone = 1234 });
            GroupA.Add(new ClassA { Name = "Vincent", Address = "Urgello", Phone = 1234 });



            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClassA, ClassB>();
            });

            IMapper mapper = config.CreateMapper();

            //List<ClassB> finalResult = mapper.Map<List<ClassA>, List<ClassB>>(GroupA);

            List<ClassB> finalResult = mapper.Map<List<ClassB>>(GroupA);
        }

    }
}
