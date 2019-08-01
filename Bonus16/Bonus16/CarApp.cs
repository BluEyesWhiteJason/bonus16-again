using System;
using System.Collections.Generic;
namespace Bonus16
{
    public class CarApp
    {
        //string make;
        //string model;
        //int year;
        //double price;


        public CarApp()
        {
            List<Car> cars = new List<Car>();

            Console.WriteLine("Hello, welcome to CarApp!");
            Console.WriteLine("Please enter the following information");
            Console.Write("Make: ");
            string make = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();


            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

        }

        //public CarApp(string Make, string Model, int Year, double Price)
        //{
        //    make = Make;
        //    model = Model;
        //    year = Year;
        //    price = Price;
        //}
    }
}
