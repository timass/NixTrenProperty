using System.Collections.Generic;

namespace OnionApp.Domain.Core
{
  public class RoomIndividual : Room
    {
        public bool Kitchen;
        public bool Bathroom;
        public RoomIndividual(bool electricity, bool gas, bool plumbing, bool sewerage,
            int objectId, string city, string address, double area, string describe,
            string photos, int floor, bool kitchen, bool bathroom)           
        {
            Electricity = electricity; Gas = gas; Plumbing = plumbing; Sewerage = sewerage;
            ObjectId = objectId; City = city; Address = address; Area = area; Describe = describe;
            Photos = photos; Floor = floor; Rooms = 1; Floor = floor; Kitchen = kitchen; Bathroom = bathroom;
        }
    }
}
