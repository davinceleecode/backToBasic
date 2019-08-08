using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DependencyInjection
{
    public class CreditCardPaymentGateway : IPaymentGateway
    {

        public bool ProcessPayment()
        {
            Console.WriteLine("Processing payment...");
            Console.WriteLine("Processing payment completed.");
            return true;
        }
    }
}
