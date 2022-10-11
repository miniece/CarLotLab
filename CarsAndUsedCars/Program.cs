﻿namespace CarsAndUsedCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Chrysler", "Sebring", 2010, 6500);
            Console.WriteLine(c);

            List<Car> carsInventory = new List<Car>();
            carsInventory.Add(c);
            carsInventory.Add(new Car("Nissan", "Altima", 2017, 9745));
            carsInventory.Add(new Car("Ford", "F150", 2015, 10520));
            carsInventory.Add(new UsedCar("Honda", "Civic", 2016, 5261, 137561));
            carsInventory.Add(new UsedCar("Toyota", "Camry", 2004, 4248, 184562));
            carsInventory.Add(new UsedCar("Jeep", "Wrangler", 2009, 7895, 49785));

            int index = 0;
            foreach (Car car in carsInventory)
            {
                Console.WriteLine(index + ": " ,car);
                index++;
            }
            Console.WriteLine("Which car would you like to remove? Please select by index.");
            string input = Console.ReadLine();
            int pick = int.Parse(input);

            carsInventory.RemoveAt(pick);

            index = 0;
            foreach (Car car in carsInventory)
            {
                Console.WriteLine(index + ": ", car);
                index++;
            }
        }
        
    }
}
/*
Add a public static method to Car called ListCars that loops through the list and prints out each member and its index in the list. (Hint: Use a regular for loop, not a foreach loop so you  can print out the index.)
Add a public static method to Car called Remove which takes an integer parameter and removes the car whose index is that parameter
In your main, print out the list (by calling the ListCar method). Then ask the user which car they would like to buy, by number (the index of the car).
Print out the details for the chosen car. (Think about how to print out this information: You’ll access the item in the list by index, and call Console.WriteLine.)
Remove the chosen car from the list
List all the cars again

Hints:
Use the right access modifiers (public/private/protected)!
You can just use \t tab escape characters to line things up, or if you want to get fancier, look up text formatters. 

Extra Challenges:
Think about other methods which might be useful for your Car such as “BuyBack” where you can add a used car to the list. Implement them and modify your app to take advantage of them. 
Create an Admin mode which lets the user edit cars.
Provide search features:
View all cars of an entered make.
View all cars of an entered year.
View all cars of an entered price or less.
View only used cars or view only new cars.

See next page for Console Preview.

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