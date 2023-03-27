using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public interface Interface
    {
        public void show();

        public void display(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public void calculate(int age)
        {
            Console.WriteLine(age);
        }

    }

    public class child: Interface
    {
        public void show()
        {
            Console.WriteLine("Show method is child");
        }
        public void calculate(int age)
        {
            Console.WriteLine(age);
        }
        public void display(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
