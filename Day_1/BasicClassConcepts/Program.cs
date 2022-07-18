using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    class Program
    {
        /*
        static void Main1()
        {
           

            Console.WriteLine("HELLOOOO");

            Console.ReadLine();
        }

        static void Main2()
        {
            Class1 o = new Class1();
            o.Display();
            o.Display("CDAC");

           

        }


        
          static void Main2()
        {
            Class1 c1 = new Class1();
            c1.Display();


            //int ans = c1.Add(30, 40, 50);
            Console.WriteLine(ans);

           
        }

        static void Main3()
        {

            Class1 c2 = new Class1();
            c2.Display();

            double ans1 = c2.Add(35.4, 63.4, 71.1);
            Console.WriteLine(ans1);
        }
        */

        static void Main()
        {
            int a = 20;

            a++;
            ++a;
            a--;
            Function();

            void Function()
            {
                Console.WriteLine(++a);
                Console.WriteLine("Local Function");
            }

            Function();

            Console.WriteLine(a);
        }




    }
    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("AKSHAYYY");
        }

        //Function Overloading
        public void Display(string s)
        {
            Console.WriteLine("HELLO" + s);
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }

    }
}

namespace n1
{
    public class Class1 { }
    public class Class2 { }
    namespace n1a
    {
        public class Class3 { }
    }

}
