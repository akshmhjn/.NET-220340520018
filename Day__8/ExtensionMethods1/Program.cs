using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        private static object MyExtMethodClass;

        static void Main1(string[] args)
        {
            string s = "Akshay";
            MyExtendMethodClass.Display(s);
            int i = 10;
            i = MyExtendMethodClass.Add(i, 5);
            MyExtendMethodClass.Show(i);
            Console.ReadLine();
        }

        static void Main()
        {
            ClsMaths o = new ClsMaths();
            Console.WriteLine(o.Subtract(10, 5));

            Console.ReadLine();
        }
    }

    //CREATE A STATIC CLASS

    public static class MyExtendMethodClass
    {
        //CREATE A STATIC METHOD IN A CLASS
        //FIRST PARAMETER SHOULD BE TYPE FOR WHICH YOU ARE WRITING EXTENSION METHOD
        //PRECED THE FIRST PARAMETER WITH 'this' KEYWORD

        public static void Display(this string s)
        {
            Console.WriteLine(s);
        }
        public static void Show(this int i)
        {
            Console.WriteLine(i);
        }

        public static int Add(this int i, int j)
        {
            return i + j;
        }

        //if you define an extension method for an interface, 
        // it is also available to all classes that implement that interface
        public static void ExtMethodForBaseClass(this object s)
        {
            //Array.Sort();
            Console.WriteLine(s);
        }

        //if you define an extension method for an interface, 
        // it is also available to all classes that implement that interface
        public static int Subtract(this IMathOperations i, int a, int b)
        {
            return a - b;
        }
    }
    public interface IMathOperations
    {
        int Add(int a, int b);
        int Multiply(int a, int b);
    }
    public class ClsMaths : IMathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
