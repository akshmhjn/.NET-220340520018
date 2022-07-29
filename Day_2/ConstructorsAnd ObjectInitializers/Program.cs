using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAnd_ObjectInitializers
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class2 c21 = new Class2();
            Console.WriteLine(c21.P4);

            Class2 c22 = new Class2(10, "a", 12, 13, 14);
            Console.WriteLine(c22.P4);

        }

        static void Main(string[] args)
        {
            Class3 c31 = new Class3();
            c31.X = 10;
            c31.P2 = 20;
            c31.P3 = 30;
            c31.P4 = 40;

            //Object Initializer
            Class3 c32 = new Class3() { X = 10, P2 = 20, P3 = 30, P4 = 40 };
            Class3 c33 = new Class3() { X = 10, P2 = 20 };
            Class3 c34 = new Class3 { X = 10, P2 = 20, P3 = 30, P4 = 40 };


            Console.WriteLine("P4 : "+c31.P4);
            c31 = null;
            c32 = null;
            c33 = null;
            c34 = null;

            Console.ReadLine();
        }

       
    }


    public class Class1
    {
        
       
    }

    public class Class2
    {

        public Class2()
        {
            X = 10;
            //P1 = "x";
            p1 = "xyz";
            P2 = 20;
            P3 = 30;
            P4 = 40;
            Console.WriteLine("No Parameter Constructor called");
        }


        public Class2(int X, string P1, int P2, int P3, int P4)
        {
            this.X = X;
            //P1 = "x";
            this.p1 = P1;
            this.P2 = P2;
            this.P3 = P3;
            this.P4 = P4;
            Console.WriteLine(" Parameter Constructor called");
        }


        private int x;
        public int X
        {
            set
            {
                //value is the rhs of o.X = 10;
                if (value < 100)
                    x = value;
                else
                    Console.WriteLine("invalid value for x");
            }
            get
            {
                return x;
            }
        }


        private string p1 = "abc";
        public string P1 //readonly property
        {
            get
            {
                return p1;
            }
        }

        private int p2;
        public int P2
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
        public int P3;

        public int P4 { get; set; }


    }

    public class Class3
    {
        public Class3()
        {
            X = 10;
            //P1 = "x";
            p1 = "xyz";
            P2 = 20;
            P3 = 30;
            P4 = 40;
            Console.WriteLine("PARAMETERLESS CONSTRUCTOR CALLED");
        }


        private int x;
        public int X
        {
            set
            {
                //value is the rhs of o.X = 10;
                if (value < 100)
                    x = value;
                else
                    Console.WriteLine("invalid value for x");
            }
            get
            {
                return x;
            }
        }
        private string p1 = "abc";
        public string P1 //readonly property
        {
            get
            {
                return p1;
            }
        }

        private int p2;
        public int P2
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
        public int P3;

        public int P4 { get; set; }

        /*
        ~Class3()  //DO NOT EVER WRITE THIS IN .NET
        {
            Console.WriteLine("destructor");
        }
        */

    }
}
