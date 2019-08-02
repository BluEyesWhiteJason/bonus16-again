using System;
using System.Collections.Generic;
namespace Bonus16
{
    public class CarApp
    {

        List<Car> carsList = new List<Car>();

        public CarApp(List<Car> Cars)
        {
           
        }

        public void SetMake()
        {
            Console.WriteLine("Make: ");
            string make = Console.ReadLine();
        }

        public void SetModel()
        {
            Console.Write("Model: ");
            string model = Console.ReadLine();
        }

        public void SetYear()
        {

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
        }

        public void SetPrice()
        {

            Console.Write("Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
        }
       



        //private static void CarAppl(List<Car> cars)
        //{
        //    foreach (Car c in cars)
        //    {
        //        Console.WriteLine(c);
        //    }
        //}



        //public CarApp(string Make, string Model, int Year, double Price)
        //{
        //    make = Make;
        //    model = Model;
        //    year = Year;
        //    price = Price;
        //}
    }
}
