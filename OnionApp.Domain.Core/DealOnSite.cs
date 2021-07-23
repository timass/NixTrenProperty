using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class DealOnSite <O, S> : DeleteObject
        where O : ObjectS        
        where S : Seller
    {
        public double RentPrice { get; set; }
        public DateTime TimeDeal { get; set; }
        public void AddToBd(O obj, BuyerOrSeekerRieltor buyer, S seller)
        {
            //add to Bd obj, client, seller, RentPrice, TimeDeal;
        }
        public void DeleteObject(O obj)
        {
            //delete obj from Db;
        }
    
        public double SalePrice { get; set; }
        public double FirstPrice { get; set; }
        public double LastPrice { get; set; }
       
        public DateTime DateOfSale { get; set; }      
    }
}
