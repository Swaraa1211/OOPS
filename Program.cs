namespace OOPS
{
    internal class Program
    {
        //enum days { Mon, Tues, Wed}
        static void Main(string[] args)
        {


            var obj = new Abstract1();
            obj.normal_method(10, 20);
            obj.Method(30, 40);


            /*child c = new child();
            Interface p = new child();
            p.display("Swara");
            c.show();
            c.calculate(24);
            ((Interface)c).display("Swara");*/

            /*Marks m = new Marks(289, 5);
            Student student = new Student("cm", 20, 29, 2, m);
            student.Display();*/
            //var obj = new Program();


            //var obj = new Test();
            //obj.method1();
            //var object1 = new Test().Test1();
            //obj.method1();

            //AccSpec spec = new AccSpec();

            /*Program spec = new Program();
            spec.Display("hello");
            Console.WriteLine(spec.name);*/

            //AccSpec spec = new AccSpec();
            //Program spec = new Program();
            //spec.Display("hello");
            //Console.WriteLine(spec.name);

            /*var Volvo = new VolvoSports();
            //Volvo Volvo = new Volvo();
            Volvo.MaxSpeed(40);
            Volvo.ABS();
            Volvo.Test();
            Volvo.Sportmethod();*/
        }

    }
}

/*
 * Overloading("Sai");
            Overloading("Sai", 42);

public static void Overloading(string name)
        {
            //Console.WriteLine(typeof(Day);
            Console.WriteLine("Hi " + name );
        }
        public static void Overloading(string name, int id)
        {
            Console.WriteLine($"Name- {name}, ID- {id}");
        }
 */