using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValueTypes3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.i = 100;
            DoSomething(c1);
            //DoSomething2(c1);
           // DoSomething3(ref o);
            Console.WriteLine(c1.i);
            Console.ReadLine();
        }

        static void DoSomething(Class1 obj) //obj  =  o
        {
            //CHANGES MADE IN FUNCTION(CHANGING VALUE OF PROPERTIES)IS REFLECTED CALLING CODE O
            obj.i = 200;

        }

        static void DoSmething2(Class1 obj)
        {
            //CHANGES MADE IN FUNCTION(OBJECT POINTING TO SOME OTHER BLOCK)IS NOT REFLECTED CALLING CODE O
            obj = new Class1();
            obj.i = 200;
        }

        static void DoSomething3(ref Class1 obj)
        {
            //CHANGES MADE IN FUNCTION(OBJECT POINTING TO SOME OTHER BLOCK)IS  REFLECTED CALLING CODE O
            obj = new Class1();
            obj.i = 200;
        }
    }
    public class Class1
    {
        public int i;
    }
}
