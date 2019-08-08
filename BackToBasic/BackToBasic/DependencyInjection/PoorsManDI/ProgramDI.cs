using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackToBasic.DependencyInjection.PoorsManDI;
using Unity;

namespace BackToBasic
{
    public class ProgramDI
    {
       public static void Main(string[] args)
        {

            //ProgramDI x = new ProgramDI();
            //x.Start();
            
           
            //var gameConsole = new SuperNes(new ZeldaLinkToThePast(new Sword()));
            

           var container = new UnityContainer();
           container.RegisterType<IGameConsole, SuperNes>(); 
           container.RegisterType<IGame, ZeldaLinkToThePast>();
           container.RegisterType<IWeapon, Sword>();

           var gameConsole = container.Resolve<IGameConsole>();
           gameConsole.LoadGame();

            //gameConsole.LoadGame();
            Console.ReadKey();
        }




       public void Start()
       {

           List<Person> persons = new List<Person>() 
            { new Person { FirstName = "Vincent", LastName = "Flores", Address = "Cebu City" },
              new Person { FirstName = "Rio", LastName = "Cinco", Address = "Cebu City" },
              new Person { FirstName = "Glenn", LastName = "Amora", Address = "Cebu City" }
            };

           IModelFactory _modelFactory = new ModelFactory();


           var person = persons.Select(x => _modelFactory.Create(x));
       }


       public class Person
       {
           public string FirstName { get; set; }
           public string LastName { get; set; }
           public string Address { get; set; }
       }

       public class PersonExact
       {
           public string LastName { get; set; }
           public string Address { get; set; }
       }

        public interface IModelFactory
        {
            PersonExact Create(Person Person);
        }

        public class ModelFactory : IModelFactory{

            public PersonExact Create(Person Person )
            {
                return new PersonExact { LastName = Person.LastName, Address = Person.Address };
            }
        }
    } 
}
