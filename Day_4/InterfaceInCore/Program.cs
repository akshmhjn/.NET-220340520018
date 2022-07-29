using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.Insert();
            //c1.DefMethod();

            IDbFunctions C1IDb;
            C1IDb = c1;
            C1IDb.Insert();
            //C1IDb.DefMethod();
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();

        //static int a;


        //DEFAULT IMPLEMENTATION FOR INTERFACE METHOD

        /*
        void DefMethod()
        {
            Console.WriteLine("DEFAULT IMPLEMENTATION FOR INTERFACE METHOD");
        }
        */


    }

    public class Class1 : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("CLASS 1 : IDb.Delete");
        }

        public void Display()
        {
            Console.WriteLine("CLASS 1 : DISPLAY");

        }

        public void Insert()
        {
            Console.WriteLine("CLASS 1 : IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("CLASS 1 : IDb.Update");
        }

        /*
        public void DefMethod()
        {
            Console.WriteLine("CLASS 1 CODE FOR DEF METHOD");
        }
        */

        /*
        void IDbFunctions.DefMethod()
        {
            Console.WriteLine("CLASS 1 CODE FOR DEF METHOD - IDbFunctions");
        }
        */
    }
}
