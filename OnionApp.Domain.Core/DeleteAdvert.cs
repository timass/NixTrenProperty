using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class DeleteAdvert<A> where A : AdvertSell<ObjectS, Seller>
    {
        public bool SuccessDeal { get; set; } // Deal or just delete
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
