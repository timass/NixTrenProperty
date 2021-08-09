using System;
using OnionApp.Domain.Core;

namespace BusinessLogic
{
    public class DeleteAdvert<O, S> 
       where O : ObjectS
       where S : Seller
       
    {
       /* delegate void Check(object sender, CheckAdvert<A> c);
        event Check NotifyDelete;*/
        public Advert<O, S> Advert { get; set; }
        public bool SuccessDeal { get; set; } // Deal or just delete        
        public TimeSpan TimeDifference { get; set; } //Time after add and delete
        public TimeSpan timeDifference(Advert<O, S> adv)
        {
            return DateTime.Today - adv.DateOfAdd;
        }
        public decimal PriceDifference { get; set; } //  last price - first price
        public decimal priceDifference(Advert<O, S> adv)
        {
            return adv.LastPrice - adv.FirstPrice;
        }
        public DeleteAdvert(Advert<O, S> adv, bool succ)
        {
            Advert = adv;
            SuccessDeal = succ;
        }
        public static void DeleteAdvertAfterOneYear(Advert<O, S> advert)
        { 
               if(TimeSpan.Compare((DateTime.Today-advert.DateOfActual), TimeSpan.FromDays(365)) >= 0)
                Saver<O, S>.Advlist -= advert;
        }
        public void DeleteAndRefreshStatistics(Advert<O, S> advert, bool succ)
        {
            if (succ)
            {
                bool sealOfRent;
                if (advert.GetType() == typeof(Advert<O, S>))
                    sealOfRent = true;
                else sealOfRent = false;
                for (int i = 0; i < Saver<O, S>.Slist.Count; i++)
                {
                    if (Saver<O, S>.Slist[i].Name == advert.Sel.Name)

                        advert.Sel.Flist.Add(new SalesFigures()
                        {
                            SaleOrRent = sealOfRent,
                            PriceDifference = priceDifference(advert),
                            TimeDifference = timeDifference(advert)
                        });
                }
            }
            Saver<O, S>.Advlist -= advert;// Extension method in Advert
        } 
    } 
}
