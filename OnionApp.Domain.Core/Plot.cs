using System.Collections.Generic;

namespace OnionApp.Domain.Core
{
    public class Plot : ObjectS
    {
        public double AreaOfPlot { get; set; }
        public Plot(bool electricity, bool gas, bool plumbing, bool sewerage, int objectId, string city, string address, 
            string describe, string photos, double areaOfPlot)
        {
            Electricity = electricity; Gas = gas; Plumbing = plumbing; Sewerage = sewerage;
            ObjectId = objectId; City = city; Address = address; Area = 0;
            Describe = describe; Photos = photos; AreaOfPlot = areaOfPlot;
        }       
    }
}
