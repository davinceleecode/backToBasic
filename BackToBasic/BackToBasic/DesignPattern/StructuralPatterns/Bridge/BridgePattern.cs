using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DesignPattern.StructuralPatterns.Bridge
{
    //source https://www.dotnettricks.com/learn/designpatterns/bridge-design-pattern-dotnet
    /// <summary>
    /// The 'Bridge/Implementor' interface
    /// </summary>
    public interface IMesssageSender
    {
        void SendMessage(string subject, string body);
    }

    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class EmailSender : IMesssageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Email\n{subject}\n{body}");
        }
    }

    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class WebServiceSender : IMesssageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Web Service\n{subject}\n{body}");
        }
    }

    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class MSMQSender : IMesssageSender
    {
        public void SendMessage(string subject, string body)
        {
             Console.WriteLine($"MSMQ\n{subject}\n{body}");
        }
    }




    public abstract class Message
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public IMesssageSender MessageSender;

        public abstract void Send();
    }


    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }

    public class UserMessage : Message
    {
        public string UserComments { get; set; }
        public override void Send()
        {
            string fullBody = $"{Body} \nUser Comments: {UserComments}";
            MessageSender.SendMessage(Subject, fullBody);
        }
    }



    public class BridgePattern
    {
        public static void Main()
        {
            IMesssageSender email = new EmailSender();
            IMesssageSender msmq = new MSMQSender();
            IMesssageSender webservice = new WebServiceSender();

            Message message = new SystemMessage();
            message.Subject = "MicroftHunter";
            message.Body = "Hi, This is MicroftHunter";

            message.MessageSender = email;
            message.Send();

            message.MessageSender = msmq;
            message.Send();

            message.MessageSender = webservice;
            message.Send();


            UserMessage usermsg = new UserMessage();
            usermsg.Subject = "davinceleecode";
            usermsg.Body = "Hi, This is davinceleecode";
            usermsg.UserComments = "I hope you are good";

            usermsg.MessageSender = email;
            usermsg.Send();

            Console.ReadKey();
        }
    }
}
