using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
   public class SalesFigures // test
    {
       public bool SaleOrRent { get; set; }
        public decimal PriceDifference { get; set; }
        public TimeSpan TimeDifference { get; set; }
        public Seller Seller;
    }
}
