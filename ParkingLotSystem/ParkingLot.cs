using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotSystem
{
    internal class ParkingLot:IParking
    {
        public int LotCapacity = 100;

        public int AllocatedLot = 0;
        

        
        public  bool ParkingAvailabilityStatus()
        {
            
            if(AllocatedLot <= LotCapacity)
            {
                Console.WriteLine($"Lots are available: {LotCapacity - AllocatedLot}");
                return true;
               
            }
            else
            {
                Console.WriteLine("Lots are Full");
                return false;
            }
        }

        public int AssignLot()
        {
            if (ParkingAvailabilityStatus())
            {
                Console.WriteLine("Are you Handicap? Type yes or No");
                string handicap = Console.ReadLine().ToLower();
                if (handicap == "yes")
                {
                    Console.WriteLine("Special services are available for you");

                }

                AllocatedLot += 1;
                Console.WriteLine("lot allocated");
                return AllocatedLot;
            }
            else
            {
                Console.WriteLine("Can't assign ,Lots are Full");
                return -1;
            }
        }





    }
}
