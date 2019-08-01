using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus16
{
    class Car
    {
        // Variables
        string make;
        string model;
        int year;
        double price;

        //Constructor that takes no arguments
        public Car()
        { 
            make = "Honda";
            model = "Accord";
            year = 1986;
            price = 500.00;
        }

        public Car(string Make, string Model, int Year, double Price)
        {
            make = Make;
            model = Model;
            year = Year;
            price = Price;
        }

        public override string ToString()
        {
            Console.WriteLine("Make: " + make);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Price: " + price);
            return "";
        }
    }
}
