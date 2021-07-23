using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class BuyerOrSeekerRieltor : User, IShowStatistic
    {
        public string Telephone { get; set; }
    }
}
