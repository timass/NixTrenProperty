using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    public class Plot : ObjectS
    {
        public double AreaOfPlot { get; set; }
        internal Plot(int objectId, string city, string address, 
            Utilites[] ut, string describe, List<object> photos, double areaOfPlot)
        {
            ObjectId = objectId; City = city; Address = address; Area = 0; utilites = ut;
            Describe = describe; Photos = photos; AreaOfPlot = areaOfPlot;
        }


        
    }
}
