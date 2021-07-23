using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class Garage : ParkingPlace
    {
       public bool Pit { get; set; }
       public bool Cellar { get; set; }
    }
}
