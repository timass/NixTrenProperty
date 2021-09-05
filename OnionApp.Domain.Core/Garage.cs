using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionApp.Domain.Core
{
    [Table("Garages")]
  public  class Garage : ParkingPlace
    {
       public bool Pit { get; set; }
       public bool Cellar { get; set; }
        public Garage() { }
       //public Garage (bool electricity, bool gas, bool plumbing, bool sewerage, int objectId, string city, string address, double area,
       //     string describe, string photos, bool electricForEcar, bool pit, bool cellar)
       //     : base (electricity, gas, plumbing, sewerage, objectId, city, address, area, describe, photos, electricForEcar)
       // {
       //    Pit = pit; Cellar = cellar;
       // }
    }
}
