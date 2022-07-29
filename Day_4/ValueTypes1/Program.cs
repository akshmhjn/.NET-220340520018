using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = new int();
            //int i = 0;

            Console.WriteLine(i);
            Console.ReadLine();
        }

        static void Main2()
        {
            MyPoint p = new MyPoint(10, 20, 30);
            Console.WriteLine(p.A);
            Console.ReadLine();
        }
    }

    /*
     //structs are Value Types - stored on stack. Faster than Heap operations
    //No Inheritance allowed in structs
    //Parameterless constructor not allowed in structs
     */

    public struct MyPoint
    {
        public int A
        {
            get;set;
        }
        public int X, Y;
        public MyPoint(int X = 0,int Y = 0,int A = 0)
        {
            Console.WriteLine("Constructor Called");
            this.X = X;
            this.Y = Y;
            this.A = A;
        }
    }
}
