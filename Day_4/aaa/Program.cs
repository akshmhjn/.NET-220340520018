using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaa
{
    class Program
    {
        static void Main()
        {
            int[,] arr = new int[4, 3];

            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));

            Console.WriteLine("Upper Bound: {0}", arr.GetUpperBound(0).ToString());
            Console.WriteLine("Lower Bound: {0}", arr.GetLowerBound(0).ToString());
            Console.WriteLine("Dimensions of Array : " + arr.Rank);
        }
    }
}



