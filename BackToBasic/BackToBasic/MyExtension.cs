using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BackToBasic
{
    public static class MyExtension
    {
        /// <summary>
        /// Indicates whether this string is in correct URL format.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>



        public static Boolean IsValid(this Int32 value)
        {
            if (value == 1991)
                return true;
            else
                return false;
        }

        public static String IsCorrect(this String value)
        {
            if (value.Contains("lee"))
                return "Correct";
            else
                return "Incorrect";
        }

        public static void Main(string[] args)
        {
            var birthdate = 1991.IsValid();
            var name = "vincent.lee.c.flores".IsCorrect();
        }




    }
}
