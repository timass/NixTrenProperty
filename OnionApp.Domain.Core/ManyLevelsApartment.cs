using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionApp.Domain.Core
{
    [Table("ManyLevelsApartments")]
  public class ManyLevelsApartment : Apartment
    {
        public int LevelsApartments { get; set; }
        public bool Penthouse { get; set; }
        public ManyLevelsApartment() { }
        //public ManyLevelsApartment(bool electricity, bool gas, bool plumbing, bool sewerage, 
        //    int objectId, string city, string address, double area,
        //    string describe, string photos, int rooms, int floor, bool kitchenWithRoom,
        //    double areaOfKitchen, int levelsApartments, bool penthouse) 
        //         : base  (electricity, gas, plumbing, sewerage, objectId, city, address,
        //               area, describe, photos, rooms, floor, kitchenWithRoom, areaOfKitchen)
        //{
        //    LevelsApartments = levelsApartments;
        //    Penthouse = penthouse;
        //}
    }
}
