using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DependencyInjection
{
    public interface IPaymentGateway
    {

        bool ProcessPayment();

    }
}
