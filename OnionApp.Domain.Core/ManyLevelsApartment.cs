using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class ManyLevelsApartment : Apartment
    {
        public int LevelsApartments { get; set; }
        public bool Penthouse { get; set; }
        internal ManyLevelsApartment(int rooms, int floor, bool kitchenWithRoom, 
            double areaOfKitchen, int levelsApartments, bool penthouse) 
                 : base  (rooms, floor, kitchenWithRoom, areaOfKitchen)
        {
            LevelsApartments = levelsApartments;
            Penthouse = penthouse;
        }
    }
}
