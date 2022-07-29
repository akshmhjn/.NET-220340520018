using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main1(string[] args)
        {
            DerivedClass d11 = new DerivedClass(123,456);
            //BaseClass b11 = new BaseClass(123);
            Console.ReadLine();
        }
    }

    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            Console.WriteLine("BASE CLASS PARAMETERLESS CONSTRUCTOR");
            i = 10;
        }

        public BaseClass(int i)
        {
            Console.WriteLine("BASE CLASS INTEGER CONSTRUCTOR");
            this.i = i;
        }
    }

    public class DerivedClass : BaseClass
    {
        public int j;
        public DerivedClass()
        {
            Console.WriteLine("DERIVED CLASS PARAMETERLESS CONTRUCTOR");
            j = 20;
        }

        public DerivedClass(int i,int j) //: BaseClass
        {
            Console.WriteLine("DERIVED CLASS INTEGER PARAMETER CONSTRUCTOR");
            this.j = j;
        }
    }
}




