using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DesignPattern.AbstractFactory
{
    interface INormal
    {
        string DisplayBase();
    }
    interface IAboveNormal
    {
        string DisplayTop();
    }

    



   public class clsWagonR : INormal
    {
        public string DisplayBase()
        {
            return "WagonR";
        }
    }

    public class clsSwift : IAboveNormal
    {

        public string DisplayTop()
        {
            return "Switft";
        }
    }

    public class clsAudiA4 : INormal
    {

        public string DisplayBase()
        {
            return "AudiA4";
        }
    }

    public class clsAudiQ7 : IAboveNormal
    {

        public string DisplayTop()
        {
            return "AudiQ7";
        }
    }


    interface ICar
    {
        INormal GetNormal();
        IAboveNormal GetAboveNormal();
    }

    public class clsMaruti : ICar
    {
        INormal ICar.GetNormal()
        {
            return new clsWagonR();
        }

        IAboveNormal ICar.GetAboveNormal()
        {
            return new clsSwift();
        }
    }
    
    public class clsAudi : ICar
    {
        INormal ICar.GetNormal()
        {
            return new clsAudiA4();
        }

        IAboveNormal ICar.GetAboveNormal()
        {
            return new clsAudiQ7();
        }
    }

    enum test : int
    {
        xxx = 1,
    }


    

    class clsDecider
    {
        public string GetCarDetails(int iCarType)
        {
             
             


            ICar ObjClient = null;
            switch (iCarType)
            {
                case 1:
                    ObjClient = new clsMaruti();
                    break;
                case 2:
                    ObjClient = new clsAudi();
                    break;
                default:
                    ObjClient = new clsMaruti();
                    break;
            }

            string sOutput = "Normal Car is:" + ObjClient.GetNormal().DisplayBase() + ", Above Normal car is:  " + ObjClient.GetAboveNormal().DisplayTop();
            return sOutput;
        }


        static void Main()
        {
            clsDecider ObjDecider = new clsDecider();
            string result = ObjDecider.GetCarDetails(1);
        }

    }
}
