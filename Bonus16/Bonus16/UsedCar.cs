using System;
namespace Bonus16
{
    public class UsedCar : Car
    {
        
        double mileage;


        public UsedCar(string make, string model, int year, double price, double Mileage) : base(make, model, year, price)
        {
            mileage = Mileage;
        }

        public override string ToString()
        {
            
            Console.WriteLine(base.ToString());
            return $"Mileage: {mileage} miles";
        }
    }
}
