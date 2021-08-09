using System.Collections.Generic;

namespace OnionApp.Domain.Core
{
    public abstract class ObjectS
    {

        public bool Electricity { get; set; }
        public bool Gas { get; set; }
        public bool Plumbing { get; set; }
        public bool Sewerage { get; set; }
        public int ObjectId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public double Area { get; set; }       
        public string Describe { get;  set; }
        public string Photos { get; set; }        
    }
}
