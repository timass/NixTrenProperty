using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionApp.Domain.Core
{
    [Table("ParkingPlaces")]
   public class ParkingPlace : ObjectS
    {
       public bool ElectricForEcar { get; set; }
        public ParkingPlace() { }
       //public ParkingPlace(bool electricity, bool gas, bool plumbing, bool sewerage, int objectId, string city, string address, double area,
       //     string describe, string photos, bool electricForEcar)             
       //{
       //     Electricity = electricity; Gas = gas; Plumbing = plumbing; Sewerage = sewerage;
       //     ObjectId = objectId; City = city; Address = address; Area = area;
       //     Describe = describe; Photos = photos; ElectricForEcar = electricForEcar;
       //}
    }
}
