using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mgvf");
            Cat c = new Cat(true, true, 1, 4);
            Dog d = new Dog(true, true, 2, 4);
            Frog f = new Frog(false, false, 2, 4);
            Console.WriteLine(c.getNumberOfLegs());
            d.sayHello(d.mood);
            Console.WriteLine(f.hasGills());
            c.sayHello();
            Console.ReadLine(  );
        }
    }
}
