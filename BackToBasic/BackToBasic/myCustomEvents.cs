using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic
{
    public delegate string MyDel(string str);
    public partial class myCustomEvents
    {
        event MyDel MyEvent;

        public myCustomEvents()
        {
            this.MyEvent += new MyDel((username) => { return "Welcome " + username; });
            this.MyEvent += new MyDel(this.WelcomeUser);
        }

        public string WelcomeUser(string username)
        {
            return "Welcome " + username;

        }

        private static void Main()
        {
            myCustomEvents x = new myCustomEvents();
            string result = x.MyEvent("Tutorials Point");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public partial class myCustomEvents
    {
        class Observable
        {

            public event EventHandler SomethingHappened;
            public void DoSomething()
            {
                EventHandler handler = SomethingHappened;
                if (handler != null)
                    handler(this, EventArgs.Empty);
            }
        }

        class Observer
        {
            public void HandleEvent(object sender, EventArgs args)
            {
                Console.WriteLine("Something happened to " + sender);
                Console.ReadKey();
            }

        }

        class Test
        {
            static void Main()
            {
                Observable observable = new Observable();
                Observer observer = new Observer();
                observable.SomethingHappened += observer.HandleEvent;

                observable.DoSomething();
            }
        }
    }


    public partial class myCustomEvents
    {
        class eventProgramming
        {
            public static void Main()
            {
                AddTwoNumbers x = new AddTwoNumbers();
                x.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
                x.Add();
                Console.ReadKey();
            }

            static void EventMessage()
            {
                Console.WriteLine("***Event Executed : This is Odd Number***");
            }
        }

        class AddTwoNumbers
        {

            public delegate void dg_OddNumber();
            public event dg_OddNumber ev_OddNumber;

            public void Add()
            {
                int result;
                result = 5 + 4;
                Console.WriteLine(result.ToString());

                if ((result % 2 != 0) && (ev_OddNumber != null))
                {
                    ev_OddNumber();
                }
            }
        }
    }


}
