using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract public class Abstract
    {
        abstract public void Method(int a, int b); //signature
        public void normal_method(int a, int b)
        {
            Console.WriteLine("Hello");
            Console.WriteLine(a + b);
        }
    }

    public class Abstract1 : Abstract
    {
        override public void Method(int a, int b)
        {
            Console.WriteLine("Hello");
            Console.WriteLine(a + b);
        }
    }
}