using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionApp.Domain.Core
{
    [Table("Houses")]
    public class House : Plot
    {
        public int RoomsInHouse { get; set; }
        public double AreaOfKitchen { get; set; }
        public bool TownHouse { get; set; }
        public double AreaOfPlot { get; set; }

        //public House(bool electricity, bool gas, bool plumbing, bool sewerage, 
        //    int objectId, string city, string address, double area, 
        //    string describe, string photos, double areaOfPlot,
        //  int rooms, double areaOfKitchen, bool townHouse)
        //    : base (electricity, gas, plumbing, sewerage, 
        //          objectId, city, address, describe, photos, areaOfPlot)
        //{
        //   Area = area;
        //   Rooms = rooms;
        //   AreaOfKitchen = areaOfKitchen;
        //   TownHouse = townHouse;
        //}
    }
}
