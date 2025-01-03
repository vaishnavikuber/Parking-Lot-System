using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotSystem
{
    internal class Owner : ParkingLot , IParking
    {
        public bool ParkingAvailabilityStatus()
        {
            if (AllocatedLot == LotCapacity)
            {
                Console.WriteLine("Lots are Full");
                return false;

            }

            return true;
        }
    }
}
