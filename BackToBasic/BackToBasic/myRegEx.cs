using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace BackToBasic
{
    public class myRegEx
    {
        /*
         * All explanation are to be found here:
         * https://regex101.com/r/uZ1bL9/1
         */
        public static void Main(string[] args)
        {
            string Ismatch = string.Empty;

            string ExpressionForDouble = @"(?<vincent>(\d+)(\.\d{1,2})?)";
            //Ismatch = @"sdf 3434.343 s dsd asdasd 334";
            Ismatch = @"\n      ≈ 1010.92 PHP\n    ";
            

            //return the exact match only
            Match m = Regex.Match(Ismatch, ExpressionForDouble);
            if (m.Success)
            {
                string name = m.Groups["vincent"].Value;
            }

            

            Console.ReadKey();


            //Matching an Email
            string Expression1 = @"^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z]{2,6})$";
            Ismatch = @"john@doe.com";
            //Ismatch = @"john@doe.something";
            if (ValidateRegEx(Expression1, Ismatch).Success)
                Console.WriteLine(ValidateRegEx(Expression1, Ismatch).Value);
            else
                Console.WriteLine("Does not match the an Email pattern.");


            //Matching a Slug
            string Expression2 = @"^[a-z0-9-]+$";
            Ismatch = @"my-title-here";
            //Ismatch = @"my_title_here";
            if (ValidateRegEx(Expression2, Ismatch).Success)
                Console.WriteLine(ValidateRegEx(Expression2, Ismatch).Value);
            else
                Console.WriteLine("Does not match the an Slug pattern.");



            //Matching a URL
            string Expression3 = @"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$";
            Ismatch = @"http://net.tutsplus.com/about";
            //Ismatch = @"http://google.com/some/file!.html";
            if (ValidateRegEx(Expression3, Ismatch).Success)
                Console.WriteLine(ValidateRegEx(Expression3, Ismatch).Value);
            else
                Console.WriteLine("Does not match the an URL pattern.");


            Console.ReadKey();

        }

        public static Match ValidateRegEx(string Expression, string Value)
        {
            Regex regex = new Regex(Expression);
            Match match = regex.Match(Value);
            return match;

            
        }
            
          
    }
}
