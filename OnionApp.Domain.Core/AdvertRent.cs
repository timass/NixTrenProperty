using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class AdvertRent<O, S> : AdvertSell<O, S>
        where O : ObjectS
        where S : Seller
    {
        public string DescribePayment { get; set; }
    }
}
