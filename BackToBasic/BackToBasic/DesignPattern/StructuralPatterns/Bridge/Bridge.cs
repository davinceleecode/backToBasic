using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DesignPattern.StructuralPatterns.Bridge
{
   

    //Abstract Bridge component
    public interface IBridgeComponents
    {
        
        void Send(String messageType);
    }

    //Abstract logic class with reference to the Bridge
    public abstract class SendData
    {
        //Reference of the Bridge
        public IBridgeComponents _iBridgeComponents;
        public abstract void Send();
    }


    public class SendEmail : SendData
    {
        public override void Send()
        {
            
            //Use the bridge to send the email
            _iBridgeComponents.Send("Email");
        }
    }

    public class SendSMS : SendData
    {

        public override void Send()
        {
            //Use the bridge to send the SMS
            _iBridgeComponents.Send("SMS");
        }
    }


    public class WebService : IBridgeComponents
    {

        public void Send(string messageType)
        {
            Console.WriteLine("Sending " + messageType + " using Webservice.");
        }
    }

    public class ThirdPartyAPI : IBridgeComponents
    {

        public void Send(string messageType)
        {
            Console.WriteLine("Sending " + messageType + " using Third party API.");
        }
    }
    public class Bridge
    {
        public static void Main(string[] args)
        {
            SendData _sendData = new SendEmail();

            //Set Webservice as reference for sending Email
            _sendData._iBridgeComponents = new WebService();
            _sendData.Send();

            //Set Third party API as reference for sending Email
            _sendData._iBridgeComponents = new ThirdPartyAPI();
            _sendData.Send();

            _sendData = new SendSMS();

            //Set Webservice as reference for sending SMS
            _sendData._iBridgeComponents = new WebService();
            _sendData.Send();

            //Set Third party API as reference for sending SMS
            _sendData._iBridgeComponents = new ThirdPartyAPI();
            _sendData.Send();
        }

    }
}
