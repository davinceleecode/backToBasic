using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DesignPattern.StructuralPatterns.Adapter
{
    public interface ITarget
    {
        void MethodA();
    }

    public class Client
    {
        private ITarget target;

        public Client(ITarget target)
        {
            this.target = target;
        }

        public void MakeRequest()
        {
            target.MethodA();
        }
    }


    public class AdapterPattern : Adaptee, ITarget
    {
        public void MethodA()
        {
            MethodB();
        }
    }

    public class Adaptee
    {
        public void MethodB()
        {
            Console.WriteLine("Method() is called");
        }
    }
}
