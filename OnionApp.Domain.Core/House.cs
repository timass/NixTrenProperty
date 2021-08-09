using System.Collections.Generic;
namespace OnionApp.Domain.Core
{
    public class House : Plot
    {
        public int Rooms { get; set; }
        public double AreaOfKitchen { get; set; }
        public bool TownHouse { get; set; }
        public House(bool electricity, bool gas, bool plumbing, bool sewerage, 
            int objectId, string city, string address, double area, 
            string describe, string photos, double areaOfPlot,
          int rooms, double areaOfKitchen, bool townHouse)
            : base (electricity, gas, plumbing, sewerage, 
                  objectId, city, address, describe, photos, areaOfPlot)
        {
           Area = area;
           Rooms = rooms;
           AreaOfKitchen = areaOfKitchen;
           TownHouse = townHouse;
        }
    }
}
