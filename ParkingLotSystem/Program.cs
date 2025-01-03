using System;

namespace ParkingLotSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What You want to do?");
            Console.WriteLine("1. Park Car");
            Console.WriteLine("2. Find Car");
            Console.WriteLine("3. UnPark Car");
            Console.WriteLine("4. Charges of Parking");
            Console.WriteLine("5: Exit");

            int choice =int.Parse( Console.ReadLine());

            Console.WriteLine("Enter numberPlate of car");
            string plate = Console.ReadLine();

            Driver driver = new Driver();
            switch (choice)
            {
                
                case 1:
                   
                    Console.WriteLine("Enter vehicle color");
                    string color= Console.ReadLine();
                    Console.WriteLine("Enter vehicle make");
                    string make = Console.ReadLine();
                    Console.WriteLine("Enter vehicle size (large or small)");
                    string size = Console.ReadLine().ToLower();
                    driver.ParkCar(plate, size, color, make);
                    break;

                case 2:
                    driver.FindCar(plate);
                    break;

                case 3:
                   
                    driver.UnParkCar(plate);
                    break;

                case 4:
                 
                    driver.ChargeOfParking(plate);
                    break;

                default: break;
            }
        }
    }
}
