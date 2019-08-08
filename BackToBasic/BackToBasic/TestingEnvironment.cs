using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
namespace BackToBasic
{
    public class TestingEnvironment
    {
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public static void Main(string[] args)
        {
            var header = new List<QuestionHeader>();
            var detail = new List<QuestionDetail>();


            header.Add(new QuestionHeader
            {
                qnh_id = 1,
                qnh_title = "Question One"
            });

            header.Add(new QuestionHeader
            {
                qnh_id = 2,
                qnh_title = "Question Two"
            });
            header.Add(new QuestionHeader
            {
                qnh_id = 2,
                qnh_title = "Question Two"
            });
            header.Add(new QuestionHeader
            {
                qnh_id = 3,
                qnh_title = "Question Three"
            });


            detail.Add(new QuestionDetail { 
                qnd_id = 1,
                qnd_question = "Detail one",
                qnd_test = "asdadasd"
            });
            detail.Add(new QuestionDetail
            {
                qnd_id = 2,
                qnd_question = "Detail Two",
                qnd_test = "asdadasd"
            });
            detail.Add(new QuestionDetail
            {
                
                qnd_question = "Detail Four",
                qnd_test = "asdadasd",
                qnd_id = 4
            });


            var result = (from H in header
                         join D in detail
                         on H.qnh_id equals D.qnd_id
                         select new { H.qnh_id, H.qnh_title, D.qnd_id, D.qnd_question, D.qnd_test}).Distinct().ToList();
            DataTable dt = new DataTable();
            TestingEnvironment g = new TestingEnvironment();
            dt = g.ToDataTable (result);


            var x = detail.Where(m => m.qnd_id == 1).ToList();
            dt = g.ToDataTable(x);

        }
    }
    public class QuestionDetail
    {
        public int qnd_id { get; set; }
        public string qnd_question { get; set; }
        public string qnd_test { get; set; }
       
    }

    public class QuestionHeader
    {
        public int qnh_id { get; set; }
        public string qnh_title { get; set; }
       

    }
}
