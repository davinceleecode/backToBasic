using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
namespace BackToBasic
{
    public class CustomException
    {
        public static void Main()
        {
            try
            {
                int b = 10;
                int a = 0;


                int x = a / b;
                throw new UserAlreadyLoggedInException("User is logged in - no duplicate session allowed");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }

    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() 
            : base()
        {

        }

        public UserAlreadyLoggedInException(string message) 
            : base(message)
        {

        }

        public UserAlreadyLoggedInException(string message, Exception innerException) 
            : base(message, innerException)
        {

        }

    }
}


