using System;

namespace Bonus16
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Car myCar = new Car("Pontiac", "G6", 2007, 3200);
            Console.WriteLine(c.ToString());
            Console.WriteLine(myCar.ToString());
        }
    }
}
