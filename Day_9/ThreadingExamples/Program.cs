using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingExamples
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Thread is created but not started here
            Thread t1 = new Thread(Func1);
            Thread t2 = new Thread(Func2);
            //Thread t1 = new Thread(new ThreadStart(func1));


            //t1.IsBackground = true;
            //t2.IsBackground = true;

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;


            t1.Start();
            t2.Start();


            //t1.Suspend(); //deprecated
            //instead of suspend, use this
            //WaitHandle wh = new AutoResetEvent(false);
            //wh.WaitOne();




            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Main : " + i);
                //Thread.Sleep(1000);
            }

            //if(t1.ThreadState == ThreadState.)
            //t1.Abort();


            //code should run after t1 finishes
            //t1.Join();

            //Console.WriteLine("code after t1");

            t1.Abort();//terminates the thread


            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t1 = new Thread(Func1);
            Thread t2 = new Thread(Func2);
            //t1.IsBackground = true;
            t1.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();
            //t1.Suspend()  //deprecated code
            //t1.Resume(); //deprecated code


            //if (t1.ThreadState == ThreadState.Running)


            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main : " + i);
                //if(i==50)
                //    t1.Abort();
            }

            t1.Join();
            //code that should only run after t1 is over
            Console.WriteLine("code that should only run after t1 is over");


            Console.ReadLine();
        }


        static void Func1()
        {
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine("FIRST : " + i);
            }
        }

        static void Func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("SECOND : " + i);

            }
        }
    }
}
