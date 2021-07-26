using System;
using System.IO;

namespace OnionApp.Domain.Core
{
    class CheckAdvert<A> where A : AdvertSell<ObjectS, Seller>
    {
        //public bool SwitchAdvert;
        public CheckAdvert (A adv)
        { 
             //adv.Delete
        }
        public CheckAdvert(A adv, DateTime time, decimal price, RieltorStatistic stat)
        {
            if (stat == 0)
                RieltorStatistic <A> s = new RieltorStatistic<A>();
            adv.stat.NumberOfObject++;

        }
        DateTime TimeSell;
        public static void AddObject(RieltorStatistic<A> stat)
        { stat.NumberOfObject++; }
        public void  CheckTime(A adv)
        {
            var today = DateTime.Today;
            const string filePath = @"C:\date.txt";
            var lastDate = DateTime.Parse(File.ReadAllText(filePath));
            if (today > lastDate)
            {
                if ((DateTime.Today - adv.DateOfAdd) < 183)
                //Delete adv
            }
        }
        public void Time()

    }
}
