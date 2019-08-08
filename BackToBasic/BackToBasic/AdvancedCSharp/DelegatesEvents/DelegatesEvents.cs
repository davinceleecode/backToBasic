using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.AdvancedCSharp.DelegatesEvents
{
    public class DelegatesEvents
    {
        public static void Main(string[] args)
        {
            Person p = new Person();
            p.cashEvent += () => Console.WriteLine("Person gained a 100 dollars!");
            
            p.AddCash(50);
            p.AddCash(50);

            p.shallowcopy();   
        }

        
    }

    public class Person
    {
        public delegate void MyEventHandler();
        public event MyEventHandler cashEvent;

        public object shallowcopy()
        {
            return this.MemberwiseClone();
        }
        private int _cash;

        public int Cash
        {
            get
            {
                return _cash;
            }
            set
            {
                _cash = value;
                if (_cash >= 100)
                    if (cashEvent != null)
                        cashEvent();
            }
        }



        public void AddCash(int amount)
        {
            Cash += amount;
        }
    }
    
}
