using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToBasic.Models
{
    public class Customer : Base,Interface1
    {
        public override void DontImplementMe()
        {
            throw new NotImplementedException();
        }
        public override void ImplementMe()
        {

            throw new NotImplementedException();
        }

        public void method(string x)
        {
            throw new NotImplementedException();
        }

        public void MethodToImplement(string Name, string address)
        {
            throw new NotImplementedException();
        }
    }
}
