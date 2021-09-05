using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnionApp.Domain.Core
{
    public abstract class ObjectS : IArea
    {

        public Guid Id { get; set; }
        public bool Electricity { get; set; }
        public bool Gas { get; set; }
        public bool Plumbing { get; set; }
        public bool Sewerage { get; set; }        
        [Required]
        public string Address { get; set; }
        [Required]
        public double Area { get; set; }       
        public string Describe { get;  set; }
       // public string Photos { get; set; }        
    }
}
