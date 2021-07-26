using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class DeleteAdvert<A> where A : AdvertSell<ObjectS, Seller>
    {
        delegate void Check(object sender, CheckAdvert<A> c);
        event Check NotifyDelete;
        public A Advert { get; set; }
        public bool SuccessDeal { get; set; } // Deal or just delete
        public decimal Price { get; set; }
        public DateTime TimeSell { get; set; }
        public DeleteAdvert(A adv, bool succ)
        {
            Advert = adv;
            SuccessDeal = succ;
            Price = adv.Price;
            TimeSell = DateTime.Now - adv.DateOfAdd;            
        }
        public void ChangeStatistic()
        {
            if(!SuccessDeal)
            NotifyDelete?.Invoke(this, new CheckAdvert<A>(Advert));           
            else NotifyDelete?.Invoke(this, new CheckAdvert<A>(Advert, TimeSell, Price));
        }
        public DateTime DeleteTime { get; set; } = DateTime.Now;
        public void ChangeStatistic(A adv)
        { 
        adv.Seller.UsesrId = 
        }
        public void DeleteAdv(A adv)
        {
            //delete adv.Obj, adv from PublicDb;
            //if (SuccessDeal)add DeleteTime, Price to HideDb;
            //else delete adv.Obj, adv from HideDb;
        }
    } 
}
