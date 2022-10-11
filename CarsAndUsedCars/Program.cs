namespace CarsAndUsedCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Chrysler", "Sebring", 2010, 6500);

            List<Car> carsInventory = new List<Car>();
            carsInventory.Add(c);
            carsInventory.Add(new Car("Nissan", "Altima", 2017, 9745));
            carsInventory.Add(new Car("Ford", "F150", 2015, 10520));
            carsInventory.Add(new UsedCar("Honda", "Civic", 2016, 5261, 137561));
            carsInventory.Add(new UsedCar("Toyota", "Camry", 2004, 4248, 184562));
            carsInventory.Add(new UsedCar("Jeep", "Wrangler", 2009, 7895, 49785));

            int index = 1;
            foreach (Car car in carsInventory)
            {
                Console.WriteLine(index + ": " + car);
                index++;
            }
            Console.WriteLine("");
            Console.WriteLine("Which car would you like to remove? Please select by index.");
            string input = Console.ReadLine();
            int pick = int.Parse(input);


            carsInventory.RemoveAt(pick);
            Console.WriteLine(carsInventory[pick-1]);
            Console.WriteLine("");
            Console.WriteLine("Excellent! We will be in touch with you soon so that you can drive off the lot.");
            Console.WriteLine("Have a great day!");
            Console.WriteLine("");

            index = 1;
            foreach (Car car in carsInventory)
            {
                Console.WriteLine(index + ": " + car);
                index++;
            }
        }
        
    }
}
/*

Console Preview
Your output will vary based on decisions you make with your partner.

Welcome to Grant Chirpus’ Used Car Emporium!
 
1. Nikolai	Model S	2017		$54,999.90
2. Fourd	Escapade	2017		$31,999.90
3. Chewie	Vette		2017		$44,989.95
4. Hyonda	Prior		2015		$14,795.50 (Used) 35,987.6 miles
5. GC		Chirpus	2013		$8,500.00 (Used) 12,345.0 miles
6. GC		Witherell	2016		$14,450.00 (Used) 3,500.3 miles
Which car would you like?  {6}
GC		Witherell	2016		$14,450.00 (Used) 3,500.3 miles
Excellent!  Our finance department will be in touch shortly.
Have a great day!


 */