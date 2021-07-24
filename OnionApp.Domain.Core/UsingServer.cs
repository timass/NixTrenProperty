using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class UsingServer<S, O> 
        where S : Seller
        //where A : AdvertSell<ObjectS, Seller>
        where O : ObjectS

    {
        delegate void CreateObjectS(object sender, RieltorStatistic<S> e);
        event CreateObjectS NotifyObjects;
        delegate void CreateAdvert(object sender, AddAdvert e);
        event CreateObjectS NotifyAdvert;
        delegate void DeleteAdv(object sender, DeleteAdvert e);
        event CreateObjectS NotifyDeleteAdvert;s
        public void Viewing()
        {
            // Only serch for AdvertSell and  AdvertRent objects
        }
        public void SearchRieltor(BuyerOrSeekerRieltor buyer)
        { 
        if (buyer != null)
                // Search for Rieltors according to statistics
        }
        public O CreateObject(S sel)
        {
            O obj;
            if (sel != null)
                Console.WriteLine("Select type of property: ");
              string chose = Console.ReadLine();
            if (chose == "1")
            { obj = new Plot(); }
            else if (chose == "2")
            { obj = new House(); }
            // - - - -
            // - - - 
            else obj = new RoomIndividual();
            NotifyObjects?.Invoke(this, new RieltorStatistic<S>(sel)); //.AddObject(sel));
            return obj;            
        }
        public void CreateAdvert(S sel, O obj,  bool SellOrRent, A advert = null)
        {
            if (sel != null && obj != null)
                if (SellOrRent)
                    //if (sel is sel)
                    AdvertSell< Plot, Seller> adv; = new AdvertSell();
                else AdvertRent adv = new AdvertRent();
                    //Create AdvertSell and  AdvertRent  with ObjectS and delete
                    Notify?.Invoke();
           if (man != null  && advert != null && ConfirmOrDelete)
                //ConfirmActuality
           if (man != null && advert != null && !ConfirmOrDelete)
                //DeleteAdvert
        }
    }
}
