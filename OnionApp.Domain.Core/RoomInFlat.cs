using System.Collections.Generic;

namespace OnionApp.Domain.Core
{
   public class RoomInFlat : Room
    {
        public int HowManyRoomsForOneKitchAndBath { get; set; }
        public RoomInFlat(bool electricity, bool gas, bool plumbing, bool sewerage, 
            int objectId, string city, string address, double area,
            string describe, string photos,
            int floor, int howManyRoomsForOneKitchAndBath)
        {
            Electricity = electricity; Gas = gas; Plumbing = plumbing; Sewerage = sewerage;
            ObjectId = objectId; City = city; Address = address; Area = area;
            Describe = describe; Photos = photos; Floor = floor; Rooms = 1; Floor = floor;
            HowManyRoomsForOneKitchAndBath = howManyRoomsForOneKitchAndBath;
        }
    }
}
