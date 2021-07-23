using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
   public class Apartment : Room
    {
       // public override int rooms { get; set; }
        public bool KitchenWithRoom { get; set; }       
        public double AreaOfKitchen { get; set; }
        internal Apartment(int rooms, int floor, bool kitchenWithRoom, double areaOfKitchen)
        {
            Rooms = rooms; Floor = floor; KitchenWithRoom = kitchenWithRoom; AreaOfKitchen = areaOfKitchen;
        }
    }
}
