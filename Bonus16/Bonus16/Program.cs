using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Bonus16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car mine = new Car();
            Car used = new UsedCar("Pontiac", "G6", 2007, 3200, 130000);
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

                //Input validation for year
                int year;
                Console.Write($"Enter Car #{i + 1} Year: ");
             
                while (!int.TryParse(Console.ReadLine(), out year))
                {
                    Console.Write($"Input Invalid, enter car #{i + 1} Year: ");
                }

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
            cars.Add(used);
            Console.Clear();

            // Loop showing the list and looking until user says quit
            bool onward = true;
            while (onward)
            {
                //show inv
                Console.WriteLine("Current Inventory: ");

                for (int i = 0; i < cars.Count; i++)
                {
                    Console.Write((i + 1) + ". ");
                    cars[i].ToString();
                }
                Console.WriteLine($"{cars.Count + 1}. Quit");

                int sel;
               
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Which vehicle are you interested in?");
                        sel = int.Parse(Console.ReadLine());

                        // quit if user selects
                        if (sel == cars.Count + 1)
                        {
                            Console.WriteLine("Goobye!");
                            System.Environment.Exit(1); //From stackoverflow
                        }
                        Console.Clear();
                        Console.WriteLine(cars[sel - 1].ToString());
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
                    Thread.Sleep(2000);
              
                }
                else
                {
                    Console.WriteLine("Okay");
                    Thread.Sleep(2000);
                }

                Console.Clear();
            }
        }

    }
    
}
