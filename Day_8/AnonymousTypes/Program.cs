using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Class1 obj = new Class1{a=1, b="aaa",c = true};

            var obj = new { a = 1, b = "Akshay", c = true };
            var obj2 = new { a = 2, b = "aksh" };
            Console.WriteLine(obj.b);
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj2.GetType());

            Console.ReadLine();
        }
    }
}
