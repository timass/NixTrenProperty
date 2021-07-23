using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class ConfirmActualityEditPrice<A> where A : AdvertSell<ObjectS, Seller>
    {
        public DateTime TimeConfirm { get;} = DateTime.Now;
        public void EditPriceTime(A advert, decimal price)
        {
           if (advert != null && price != advert.Price)
            advert.LastPrice = price;
            advert.DateOfActual = TimeConfirm;
            advert.Save();
        }     
    }
}
