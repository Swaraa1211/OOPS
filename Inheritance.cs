using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Inheritance
    {
        //sealed class cant be inerited
        public void MaxSpeed(int speed)
        {
            //protected isnt allowed
            //internal is allowed
            int MaxSpeed = speed;
            Console.WriteLine(speed);

        }
        public void ABS()
        {
            Console.WriteLine("ABS is applied");
        }
    }

    public class Volvo: Inheritance
    {
        public void Test()
        {
            Console.WriteLine("In Volvo car");
        }

        public void ABS()
        {
            //child is given preference
            Console.WriteLine("Advanced ABS is applied");
        }

    }

    public class VolvoSports: Volvo
    {
        public void Sportmethod()
        {
            Console.WriteLine("sportvolvo");
        }
    }
}
