using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Akshay";
            s.Display();


            int i = 10;
            i.Show();
            i = i.Add(5);
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
    }
}
