using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DependencyInjection
{
    public class OrderProcessor
    {
        private readonly IPaymentGateway _paymentGateway;

        public OrderProcessor(IPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }


        public bool ProcessOrder()
        {
            bool success = _paymentGateway.ProcessPayment();
            return success;
        }

        public static void Main(string[] args){; 

            CreditCardPaymentGateway y = new CreditCardPaymentGateway();
            OrderProcessor x = new OrderProcessor(y);
            x.ProcessOrder();
            
        }
    }
}
