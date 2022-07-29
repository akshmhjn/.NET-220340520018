using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingExamples2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(Func1));
            //Thread t2 = new Thread(new ParameterizedThreadStart(Func2));
            Thread t2 = new Thread(Func2);
            t1.Start("o1");
            t2.Start("o2");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Thread " + i.ToString());
            }
            Console.ReadLine();
        }

        //TO DO : Pass 2 values to the func.
        //Hint : Create a class that has 2 properties and pass an object of the class
        static void Func1(object o)
        {
            //Employee obj = (Employee) o;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First Thread " + i.ToString() + o.ToString());
            }
        }
        static void Func2(object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second Thread " + i.ToString() + o.ToString());
            }
        }
    }
}
