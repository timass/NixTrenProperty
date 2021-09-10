using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionApp.Domain.Core
{
    [Table("Houses")]
    public class House : Plot
    {
        public int RoomsInHouse { get; set; }
        public double AreaOfKitchen { get; set; }
        public bool TownHouse { get; set; }
        public double AreaOfPlot { get; set; }
        public Guid Id { get; set; }
    }
}
