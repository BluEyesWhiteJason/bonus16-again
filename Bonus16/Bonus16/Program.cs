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

                int year = 0;
                Console.Write($"Enter Car #{i + 1} Year: ");
                //while (true)
                //{
                //    try
                //    {
                        year = int.Parse(Console.ReadLine());
                //        break;
                //    }
                //    catch (FormatException e)
                //    {
                //        Console.WriteLine("Please enter a number");
                //    }
                //}

                double price = 0;
                Console.Write($"Enter Car #{i + 1} Price: ");
                //try
                //{
                    price = int.Parse(Console.ReadLine());
                    //break;
                //}
                //catch (FormatException e)
                //{
                //    Console.WriteLine("Please enter a number");
                //}

                Console.WriteLine();
                Console.WriteLine();

                cars.Add(new Car(make, model, year, price));
            }

            int j = 1;
            Console.WriteLine("Current Inventory: ");
     
            for (int i = 0; i < cars.Count; i++)
            {
                Console.Write((i + 1) + ". ");
                cars[i].ToString();
            }

            int sel;
            while (true)
            {
                try
                {
                    Console.WriteLine("Which vehicle are you interested in?");
                    sel = int.Parse(Console.ReadLine());

                    Console.WriteLine(cars[sel - 1].ToString());
                    //Try to apply to list
                    break;

                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine($"Range - Please enter a number from 1 - {cars.Count}");
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Format -  Please enter a number from 1 - {cars.Count}");

                }

            }

            // Section asking for purchasing
            Console.WriteLine("Would you like to purchase this vehicle? (y/n)");
            string confirm = Console.ReadLine();
            while (confirm != "y" && confirm != "n" && confirm != "n" && confirm != "N")
            {
                Console.Write("Please enter either y or n: ");
                confirm = Console.ReadLine();
            }

            if (confirm == "y" || confirm == "Y")
            {
                Console.WriteLine("Excellent! Our finance department will be in touch with you shortly");
                cars.RemoveAt(sel - 1);

                //Show the inventory again
                Console.WriteLine("Current Inventory: ");
         
                for (int i = 0; i < cars.Count; i++)
                {
                    Console.Write((i+1) + ". ");
                    cars[i].ToString();
                }
            }
            else
            {
                Console.WriteLine("Okay");
                //TODO loop to do it again
            }
        }

    }
    
}
