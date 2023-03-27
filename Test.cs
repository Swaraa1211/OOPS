using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{

    public class Test
    {
        //private classes can be inherited only within a public class
        
        public void method1()
        {
            var obj1 = new Test1();
            obj1.method3();
            Console.WriteLine("Hello Method1");
        }
        /*private void method2() 
        { 
            Console.WriteLine("Private Method"); 
        }*/
        public class Test1
        {
            public void method3()
            {
                Console.WriteLine("Method3");

            }
            
        }
    }
}
