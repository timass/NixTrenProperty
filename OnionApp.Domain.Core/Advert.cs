using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    public class Advert <O, S>
        where O : ObjectS
        where S : Seller
    {        
        public int AdvertId { get; set; }
        public DateTime DateOfAdd { get; } = DateTime.Today;
        public DateTime DateOfActual { get; set; }
        public O Obj { get; set; }
        public S Sel { get; set; }
        public bool RentOrSeal { get; set; }
        public string PaimentConditions { get; set; }
        public decimal FirstPrice { get; set; }
        public decimal LastPrice { get; set; }
        public decimal Price;
        public decimal price
        {
            get { return Price; }
            set
            {
                if (LastPrice != 0)
                    Price = LastPrice;
                else Price = FirstPrice;
            }
        }
        public decimal PriceForMeter;
        public decimal priceForMeter
        {
            get { return PriceForMeter; }
            set { if (Obj.Area != 0)
                    PriceForMeter =Price / (decimal)Obj.Area;
                else PriceForMeter = 0; }
        }
        public void ConfirmActual()
        {
            DateOfActual = DateTime.Today;
        }
      /*  public AdvertSell(int advertId, O obj, S seller, decimal firstPrice)
        {
            AdvertId = advertId;
            DateOfAdd = DateTime.Now;
            Obj = obj;
            Sel = seller;
            FirstPrice = firstPrice;
        }*/
        public static List<Advert<O, S>> operator -(List<Advert<O, S>> list, Advert<O, S> adv)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].AdvertId == adv.AdvertId)
                {
                    list.RemoveAt(i);
                    break;
                }
            }
            return list;
        }
    }
}
