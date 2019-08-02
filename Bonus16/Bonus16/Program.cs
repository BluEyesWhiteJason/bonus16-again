using System;
using System.Collections.Generic;
using System.Globalization;

namespace Bonus16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car mine = new Car();
            //Car used = new UsedCar("Pontiac", "G6", 2007, 3200, 130000);
            ////Console.WriteLine(mine);
            ////Console.WriteLine(used);
            //Car hoda = new UsedCar("ford", "taurus", 2001, 66565, 250000);

            // Setup for toTitleCase()
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            //initiate list
            List<Car> cars = new List<Car>();

            Console.WriteLine("Hello, welcome to CarApp!");

            Console.Write("How many cars would you like to enter?: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"For each of the {num} cars, please enter the following information");

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Car {i + 1}");
               

                Console.Write($"Enter Car #{i + 1} Make: ");
                string make = myTI.ToTitleCase(Console.ReadLine());

                Console.Write($"Enter Car #{i + 1} Model: ");
                string model = myTI.ToTitleCase(Console.ReadLine());


                Console.Write($"Enter Car #{i + 1} Year: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write($"Enter Car #{i + 1} Price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                cars.Add(new Car(make, model, year, price));
            }

            Console.WriteLine("Current Inventory: ");
            foreach (Car c in cars)
            {
                c.ToString();
            }




        }

        
    }
}
