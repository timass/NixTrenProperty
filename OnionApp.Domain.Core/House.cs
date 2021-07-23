using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class House : Plot
    {
        public Room Rooms { get; set; }
        public double AreaOfKitchen { get; set; }
        public bool TownHouse { get; set; }
        internal House(int objectId, string city, string address, double area, 
            Utilites[] ut, string describe, List<object> photos, double areaOfPlot,
            Room rooms, double areaOfKitchen, bool townHouse)
            : base (objectId, city, address, ut, describe, photos, areaOfPlot)
        {
           Area = area;
           Rooms = rooms;
           AreaOfKitchen = areaOfKitchen;
           TownHouse = townHouse;
        }

    }
}
