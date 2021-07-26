using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class AdvertSell <O, S>
        where O : ObjectS
        where S : Seller
    {
        public int AdvertId { get; set; }
        public DateTime DateOfAdd { get; } = DateTime.Today;
        public DateTime DateOfActual { get; set; } =  DateTime.Today;
        public O Obj { get; set; }
        public S Seller { get; set; }
        public decimal FirstPrice { get; private set; }
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
        public void CreateObjectS(O obj)
        {
            string type2 = "OnionApp.Domain.Core" + type;
            Type myType = obj.GetType();
            myType newObject = new myType();
        }
        public void Save()
        {
            if (Obj != null )
            {
                //add DateOfActual, obj, Seller, Price to PublicDb;
                //add DateOfAdd, obj, Seller, FirstPrice to HideDb;
            }
            else Console.WriteLine("Not enough data");
        }
    }
}
