using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class ParkingPlace : ObjectS
    {
       public bool Electric { get; set; }
       internal ParkingPlace(int objectId, string city, string address, double area,
            Utilites[] ut, string describe, List<object> photos, bool electric )
       {
            ObjectId = objectId; City = city; Address = address; Area = area; utilites = ut;
            Describe = describe; Photos = photos; Electric = electric;
       }
    }
}
