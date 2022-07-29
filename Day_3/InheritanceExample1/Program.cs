using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample1
{
    class Program
    {
        /*
        static void Main1()
        {
            DerivedClass d12 = new DerivedClass();
            d12.Display1();
            d12.Display1("abc");

            d12.Display2();

            d12.Display3();
            Console.ReadLine();
        }*/


        static void Main2()
        {
            BaseClass b12;
            b12 = new BaseClass();
            b12.Display2();

        }
    }

    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("BASE CLASS : DISPLAY 1");
        }

        public void Display2()
        {
            Console.WriteLine("BASE CLASS : DISPLAY 2");

        }
        public virtual void Display3()
        {
            Console.WriteLine("BASE CLASS : DISPLAY 3");
        }
    }

    public class DerivedClass : BaseClass
    {

        //METHOD OVERLOADING IN DERIVED CLASS
        public void Display1(string s)
        {
            Console.WriteLine("DERIVED CLASS : DISPLAY 1");
        }


        //HIDING THE BASE METHOD IN DERIVED CLASS
        public new void Display2()
        {
            Console.WriteLine("DERIVED CLASS : DISPLAY 2");
        }

        //OVERRIDING BASE METHOD IN DERIVED CLASS
        public override void Display3()
        {
            Console.WriteLine("DERIVED CLASS : DISPLAY 3");
        }
    }
    public class SubDerivedClass : DerivedClass
    {

        //OVERRIDING THE BASE METHOD IN DERIVED CLASS
        public sealed override void Display3()
        {
            Console.WriteLine("SUBDERIVED CLASS : DISPLAY 3");
        }
    }

    public class SubSubDerivedClass : SubDerivedClass
    {

        //OVERRIDING THE BASE METHOD IN THE DERIVED CLASS
        public void Display3()
        {
            Console.WriteLine("SUBSUBDERIVEDCLASS : DISPLAY 3");
        }
    }



}

/*
 * 1. Derived class can overload the base class method
same name, diff parameters
Derived o = new Derived();
o.BaseMethod
o.DerivedMethod
Both methods are available from a derived class object

2. Derived class can hide the base class method
same name, same parameters
Derived o = new Derived();
o.DerivedMethod
Only derived class method is available from a derived class object
Any method can be hidden*

3. Derived class can override the base class method
same name, same parameters
Derived o = new Derived();
o.DerivedMethod
Only derived class method is available from a derived class object
Only a virtual method can be overridden***

Virtual methods -
Late bound - Run time binding - Run time polymorphism
 */
