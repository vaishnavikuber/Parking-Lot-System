using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLotSystem
{
    internal class Driver 
    {   

        List<Vehicle> Cars = new List<Vehicle>();

        ParkingLot p = new ParkingLot();

        public void FindCar(string numberPlate)
        {
            var driver = Cars.First(x => x.NumberPlate == numberPlate);
            if (driver != null)
            {
                Console.WriteLine($"Your car is in lot number {driver.LotNumber} ");
            }
            else
            {
                Console.WriteLine("Please Check and enter number plate correctly");
            }
            
            
        }
        

        public void ParkCar(string numberPlate, string vehicleSize, string color ,string make)
        {
            if (p.ParkingAvailabilityStatus())
            {
               
                Cars.Add(new Vehicle() { NumberPlate = numberPlate, VehicleSize = vehicleSize ,Color=color,TimeOfParked= DateTime.Now, Make=make,LotNumber=p.AssignLot()});
                Console.WriteLine("Your car is Parked");

            }
            else
            {
                Console.WriteLine("Can't park car!!, parking lots are full");
            }
            

        }

        public int ChargeOfParking(string numberPlate)
        {
            int hourCharge = 20;

            var car = Cars.First(x => x.NumberPlate == numberPlate);

            if (car != null)
            {
                DateTime unParkTime = DateTime.Now;


                DateTime parkTime = car.TimeOfParked;

                TimeSpan t = parkTime - unParkTime;
                int charges = t.Hours * hourCharge;

                return charges;
            }
            else
            {
                Console.WriteLine("Car is not parked , so no charges");
                return 0;
            }

            
        }

        public void UnParkCar(string numberPlate)
        {
            var car = Cars.First(x => x.NumberPlate == numberPlate);
            if(car!= null)
            {
                Cars.Remove(car);
                Console.WriteLine("Car is unparked");
            }
            else
            {
                Console.WriteLine("Car is not parked, so unable to unpark");
            }
        }





    }
}
