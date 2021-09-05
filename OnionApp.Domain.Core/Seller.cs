using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OnionApp.Domain.Core
{
    [Table("Sellers")]
    public class Seller : User
    {        
        //public List<Advert> Adverts { get; set; }
        //public bool Rieltor { get; set; }
        //public Statistic Stata { get; set; }
    }
}
