using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValueTypes
{
    class Program
    {
        /*
        static void Main1(string[] args)
        {
            Class1 c1 = new Class1();
            Class1 c2 = new Class1();
            c1.i = 100;
            c2.i = 200;
            c1 = c2;
            c1.i = 300;

            Console.WriteLine(c1.i);
            Console.WriteLine(c2.i);
            Console.ReadLine();
        }
        */

        static void Main(string[] args)
        {
            int c1, c2;
            c1 = 100;
            c2 = 200;

            c1 = c2;

            c2 = 300;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.ReadLine();
        }

        static void Main3()
        {
            string o1, o2;
            o1 = "100";
            o2 = "200";
            o1 = o2;
            o2 = "300";
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
            //200,300
            //300,300
        }
        static void DataTypes()
        {
            char ch; //Char 2 bytes
            byte b; //Byte
            sbyte sb; //SByte
            short s;// Int16 2
            ushort us; //UInt16
            int i; //Int32 4
            uint ui; //UInt32
            long l; //Int64
            ulong ul; //UInt64
            bool bo; //Boolean
            float f; //Single
            double dbl; //Double
            decimal dec; //Decimal

            string str; //String
            object o; //Object
        }
    }

    public class Class1
    {
        public int i;
    }
}
