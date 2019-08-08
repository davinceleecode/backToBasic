using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic
{
    public class myDelegate
    {

        public delegate void CallbackGateWay(string value);
        public int id { get; set; }
        public string name { get; set; }

        public static void AddCustomerDetail(CallbackGateWay callback)
        {
            callback("Customer Added!");
        }

        public static void ModifyCustomerDetail(CallbackGateWay callback)
        {
            callback("Customer Modified!");
        }

        public static void Main()
        {
            List<myDelegate> CustomerList = new List<myDelegate>();
            CallbackGateWay callback = Maintransaction;
            AddCustomerDetail(callback);
            ModifyCustomerDetail(callback);
            Console.ReadKey();
        }


        public static void Maintransaction(string value)
        {
            Console.WriteLine(value);
        }


    }


    public class myLambdaDelegate
    {
        public static void DoWork(Action<int, int> callback)
        {
            callback(5, 10);
        }
        public static void Main()
        {
            DoWork((x, y) =>
            {
                if (x >= 5)
                {
                    Console.WriteLine("5");
                }
                else
                {
                    Console.WriteLine("Boo!!!");
                }
            });
            Console.ReadKey();
        }
    }

    public class FuncDelegate
    {
        public static void Main(string[] args)
        {
            Func<int, string> displayHex = delegate(int intValue)
             {
                 return (intValue.ToString("X"));
             };

            Func<string, int> displayInteger = delegate(string hexValue)
            {
                return (int.Parse(hexValue,
                    System.Globalization.NumberStyles.HexNumber));
            };
            //same code with this:
            //Func<string, int> LdisplayInteger = hexValue => 
            //{
            //    return (int.Parse(hexValue,
            //        System.Globalization.NumberStyles.HexNumber));
            //};

            Console.WriteLine(displayHex(16));
            Console.WriteLine(displayInteger("10"));
            Console.ReadKey();
        }
    }




    public class myCallback
    {
        public interface Controller
        {
            void X();
            void B();
            void C();
            void D();
        }




        public class Mario : Controller
        {
            public void X()
            {
                Console.WriteLine("Attack Mario");
            }

            public void B()
            {
                Console.WriteLine("Jump mario");
            }

            public void C()
            {
                Console.WriteLine("Swim mario");
            }

            public void D()
            {
                Console.WriteLine("fly mario");
            }
        }





        public class Contra : Controller
        {

            public void X()
            {
                Console.WriteLine("Missile");
            }

            public void B()
            {
                Console.WriteLine("Bomb!");
            }

            public void C()
            {
                Console.WriteLine("Fly");
            }

            public void D()
            {
                Console.WriteLine("Run");
            }
        }




        public class ActionClass
        {
            public static void DoWork(Controller handlerObject)
            {
                handlerObject.X();
                handlerObject.B();
                handlerObject.C();
                handlerObject.D();
            }
        }







        public static void Main(string[] args)
        {
            var objMario = new Mario();
            var objContra = new Contra();


            ActionClass.DoWork(objMario);
        }
    }



}
