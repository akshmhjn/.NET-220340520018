using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValueTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Init(out a, out b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            // Swap(ref a, ref b);
            Print(in a);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
            
        }

        static void Swap(ref int i,ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }

        //Out is similar to ref -> changes made in function refleck black in calling code.
        //The initial value is discarded
        // out variables MUST be initialized in the function

        static void Init(out int i, out int j)
        {
            i = 200;
            j = 300;
        }

        static void Print(in int i)
        {
            Console.WriteLine(i);

            //i = 100;
            //error --in variables are read only
        }
    }
}
