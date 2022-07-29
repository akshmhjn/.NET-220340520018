using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//PARTIAL CLASSES


//partial classes must be in the same assembly
//partial classes must be in the same namespace
//partial classes must have the same name
namespace LanguageFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
        }

             public partial class Class1
             {
                 public int i;
             }
             public partial class Class1
             {
                    public int j;
             }
    
    }
}
namespace LanguageFeatures5
{
    public partial class Class1
    {
        public int k;
    }
}

