using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasic.DesignPattern.BehavioralPatterns.Mediator
{
    /// <summary>
    /// The Mediator interface, which defines a send message method which the concrete mediators must implement.
    /// </summary>
    public interface Mediator
    {
        void SendMessage(string message, ConcessionStand concessionStand);
    }

    /// <summary>
    /// The Colleague abstract class, representing an entity involved in the conversation which should receive messages.
    /// </summary>
    public abstract class ConcessionStand
    {
        protected Mediator mediator;
        public ConcessionStand(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    /// <summary>
    /// A Concrete Colleague class
    /// </summary>
    public class NorthConcessionStand : ConcessionStand
    {
        public NorthConcessionStand(Mediator mediator) : base(mediator)
        {

        }

        public void Send(string message)
        {
            Console.WriteLine($"North Concession Stand sends message: {message}");
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"North Concession Stand gets message: {message}");
        }
    }



    /// <summary>
    /// A Concrete Colleague class
    /// </summary>
    public class SouthConcessionStand : ConcessionStand
    {
        public SouthConcessionStand(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Console.WriteLine("South Concession Stand sends message: " + message);
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("South Concession Stand gets message: " + message);
        }
    }



    /// <summary>
    /// The Concrete Mediator class, which implement the send message method and keep track of all participants in the conversation.
    /// </summary>
    public class ConcessionsMediator : Mediator
    {
        private NorthConcessionStand _northConcessionStand;
        private SouthConcessionStand _southConcessionStand;

        public NorthConcessionStand NorthConcessionStand
        {
            set
            {
                _northConcessionStand = value;
            }
        }

        public SouthConcessionStand SouthConcessionStand
        {
            set
            {
                _southConcessionStand = value;
            }
        }



        public void SendMessage(string message, ConcessionStand colleague)
        {
            if (colleague == _northConcessionStand)
                _southConcessionStand.Notify(message);
            else
                _northConcessionStand.Notify(message);

        }
    }

    public class MediatorPattern
    {
        public static void Main(string[] args)
        {
            ConcessionsMediator mediator = new ConcessionsMediator();

            NorthConcessionStand leftKitchen = new NorthConcessionStand(mediator);
            SouthConcessionStand rightKitchen = new SouthConcessionStand(mediator);

            mediator.NorthConcessionStand = leftKitchen;
            mediator.SouthConcessionStand = rightKitchen;

            leftKitchen.Send("Can you send me some popcorn?");
            rightKitchen.Send("Sure thing, Kenny's on his way.");

            rightKitchen.Send("Do you have any extra hot dogs?  We've had a rush on them over here.");
            leftKitchen.Send("Just a couple, we'll send Kenny back with them.");

            Console.ReadKey();
        }
    }
}
