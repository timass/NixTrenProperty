using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionApp.Domain.Core
{
    [Table("Plots")]
    public class Plot : ObjectS
    {
             
        //public Plot(bool electricity, bool gas, bool plumbing, bool sewerage, int objectId, string city, string address, 
        //    string describe, string photos, double areaOfPlot)
        //{
        //    Electricity = electricity; Gas = gas; Plumbing = plumbing; Sewerage = sewerage;
        //    ObjectId = objectId; City = city; Address = address; Area = 0;
        //    Describe = describe; Photos = photos; AreaOfPlot = areaOfPlot;
        //}       
    }
}
