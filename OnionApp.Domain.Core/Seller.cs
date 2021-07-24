using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class Seller : User, IShowStatistic
    {
        public string Telephone { get; set; }  // who has no more than one sale deal a year or rent deal only for one address 
        public int NumberOfObject { get; set; }
        public int NumberOfDeal { get; set; }
    }
}
