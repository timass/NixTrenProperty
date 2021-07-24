using System;
using System.Collections.Generic;

namespace OnionApp.Domain.Core
{
    public abstract class ObjectS
    {
        
        public int ObjectId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public double Area { get; set; }
        internal Utilites[] utilites =
        {
            new Utilites {Util = "Electricity", IsOrNot = false },
            new Utilites {Util = "Gas", IsOrNot = false},
            new Utilites {Util = "Plumbing", IsOrNot =false},
            new Utilites { Util = "Sewerage",IsOrNot = false }
        };
        public string Describe { get;  set; }
        public List<object> Photos { get; set; }        
    }
}
