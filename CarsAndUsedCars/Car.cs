using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndUsedCars
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set;  }
        public int Year { get; set; }
        public decimal Price {  get; set; }

        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }
        public override string ToString()
        {
            string output = $"Make: {Make} Model: {Model} Year: {Year} Price: {Price}";
            return output;
        }
        
    }

}
