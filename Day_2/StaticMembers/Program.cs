using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c11 = new Class1();
            c11.i = 100;
            Class1 c12 = new Class1();
            c12.i = 200;

            Class1.static_i = 1000;
            Class1.static_Display();

            Class1.P2 = 100;
            c11.i = 100;
            c11.Display();

            c12.i = 200;
            //Console.BackgroundColor = ConsoleColor.Red;

            Console.ReadLine();
        }
    }

    public class Class1
    {
        public int i;

        //static variable - why ? -> single(shared) copy for the class
        public static int static_i;

        public void Display()
        {
            Console.WriteLine(i);
            Console.WriteLine(static_i);
            Console.WriteLine("Display");
        }
        //static function? --can be called directly classname.methodname without creating an object
        public static void static_Display()
        {
            //Console.WriteLine(i);
            Console.WriteLine(static_i);
            Console.WriteLine("static Display");
        }

        private static int p2;
        public static int P2
        {
            set
            {
                p2 = value;
            }
            get
            {
                return p2;
            }
        }
    }
}


//why static variable? --> single copy
//why property? --> validations

//why static property? --> single copy with validations
//why constructor? -->  to initialize data members
//why static constructor? --> to initialize static members

//when is the static constructor called? --> when the class is loaded
//when is the class loaded? --> when the first object is created
//OR when a static member is accessed for the first time

//static cons is implicitly called
//static cons cant have parameters
//static cons cannot be overloaded
//static cons does not have any access specifier(implicitly private)