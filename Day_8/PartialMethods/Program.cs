using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethods
{
    public class MainClass
    {
        public static void Main1()
        {
            Class1 o = new Class1();

            Console.WriteLine(o.check());

            Console.ReadLine();
        }
    }

    //Partial methods can only be defined within a partial class.
    //Partial methods must return void.
    //Partial methods can be static or instance level.
    //Partial methods cannnot have out params
    //Partial methods are always implicitly private.

    public partial class Class1 
    {
        private bool isValid = true;
        partial void Validate();
        public bool check()
        {
            //...
            Validate();
            return isValid;
        }
    }

    public partial class Class1
    {
        partial void Validate()
        {
            //perform some validation code here
            isValid = false;
        }
    }

}
