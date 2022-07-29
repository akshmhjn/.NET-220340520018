using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 100;
            var a = 100; //implicit variable
                         //var a =(long) 100; //implicit variable
                         //a= "aaa"; //error

            //used only for local variables
            //cant be used for class level vars,fn params and return types
            var b = "abc";

            //var b; //error
            Console.WriteLine(a.GetType());//Getting data type of a
            Console.WriteLine(a);
        }
    }
}
