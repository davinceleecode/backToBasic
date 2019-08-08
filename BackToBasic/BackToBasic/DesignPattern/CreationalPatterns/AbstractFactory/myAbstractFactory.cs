using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//uses Builder Design Pattern & Prototype Design Pattern
namespace BackToBasic.DesignPattern.AbstractFactory
{
    public interface ICrud
    {
        string Add();
        string Edit();
        string Delete();
        string Update();

    }

   public interface ITransaction
    {
        string StartProcess();
        string StopProcess();
        string BindData();

    }

    class myAbstractFactory : ICrud, ITransaction
    {
        public string Add()
        {
            return "Add myAbstract";
        }

        public string Edit()
        {
            return "Edit myAbstract";
        }

        public string Delete()
        {
            return "Delete myAbstract";
        }

        public string Update()
        {
            return "Update myAbstract";
        }

        public string StartProcess()
        {
            return "StartProcess myAbstract";
        }

        public string StopProcess()
        {
            return "StopProcess myAbstract";
        }


        public string BindData()
        {
            return "BindData myAbstract";
        }
    }

     

    class User : ICrud, ITransaction
    {

        public string Add()
        {
            return "Add User";
        }

        public string Edit()
        {
            return "Edit User";
        }

        public string Delete()
        {
            return "Delete User";
        }

        public string Update()
        {
            return "Update User";
        }

        public string StartProcess()
        {
            return "StartProcess User";
        }

        public string StopProcess()
        {
            return "StopProcess User";
        }


        public string BindData()
        {
            return "BindData User";
        }
    }

    //abstraction
   public interface IMaintenance
    {
        ICrud getMaintenance();
    }
   public interface ITransactionProcess
    {
        ITransaction getTransaction();
    }

    //concrete class
    class clsUser : IMaintenance
    {

        public ICrud getMaintenance()
        {
            return new User();
        }
    }

    //concrete class
    class clsMyFactory : IMaintenance
    {

        public ICrud getMaintenance()
        {
            return new myAbstractFactory();
        }
    }

    //concrete class
    class TranUser : ITransactionProcess
    {

        public ITransaction getTransaction()
        {
            return new User();
        }
    }

    //concrete class
    class TranMyFactory : ITransactionProcess
    {

        public ITransaction getTransaction()
        {
            return new myAbstractFactory();
        }
    }

    //Director class
    public class TranMainProgram
    {
        ITransactionProcess _Obj = null;
        public TranMainProgram(ITransactionProcess obj)
        {
            this._Obj = obj;
        }

        public string TranStartProcess()
        {
            return this._Obj.getTransaction().StartProcess();
        }

        public string TranBindData()
        {
            return this._Obj.getTransaction().BindData();
        }


    }


    //Director class
    class clsMainProgram
    {
        IMaintenance _ObjClient = null;
         
        clsMainProgram(IMaintenance ObjClient)
        {
            this._ObjClient = ObjClient;
        }
 
        

        public string GetAdd()
        {
            return this._ObjClient.getMaintenance().Add();
        }

        public string GetEdit()
        {
            return this._ObjClient.getMaintenance().Edit();
        }

 


        public static void Main()
        {
            clsMainProgram x = new clsMainProgram(new clsUser());
            Console.WriteLine(x.GetAdd());
                
            clsMainProgram y = new clsMainProgram(new clsMyFactory());
            Console.WriteLine(y.GetAdd());


            TranMainProgram a = new TranMainProgram(new TranUser());
            Console.WriteLine(a.TranBindData());


            Console.ReadKey();
        }
    }

    
}
