using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToBasic
{
   public class Generic
    {

       static T Max<T>(T a, T b) where T : IComparable<T>
       {
           return a.CompareTo(b) > 0 ? a : b;
       }


        private static void Main()
        {
            
            int z = Max(5, 10);
            string last = Max("ant", "zoo");

            bool Equal = Calculator.AreEqual<int>("sd", 5);

            if (Equal)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
        }

    }

    public class Calculator
    {
        public static bool AreEqual<T>(string Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }

        
    }


    public class GenericOverloadedMethods{
        static void Swap<T>(T input) { }
        static void Swap<T, U>(T input, U input2) { }
        static void Swap<T,U,W>(T input, U input2, W input3) { }
    }



    /*
    where T : struct        –   Type argument must be a value type
    where T : class         –   Type argument must be a reference type
    where T : new()         –   Type argument must have a public parameterless constructor.
    where T : <base class>  –   Type argument must inherit from <base class> class.
    where T : <interface>   –   Type argument must implement from <interface> interface.
    where T : U             –   There are two type arguments T and U. T must be inherit from U.
     */

    public static class GenericMethodsConstraints{
        
       //public static void SWAP<T>(ref T input1, ref T input2) where T : struct {
            
       //}
       //public static void SWAP<T>(ref T input1, ref T input2) where T : class { 
       
       //}
       //public static void SWAP<T>(ref T input1, ref T input2) where T : new() { 
       
       //}
       //public static void SWAP<T>(ref T input1, ref T input2) where T : BaseEmployee { 
       
       //}
       //public static void SWAP<T>(ref T input1, ref T input2) where T : IEmployee { 
       
       //}
       //public static void SWAP<T>(ref T input1, ref T input2) where T : U { 
       
       //}
    }
    
    public class BaseEmployee{}
    public interface IEmployee{}


}
