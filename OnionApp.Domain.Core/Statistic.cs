using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    public class Statistic
    {
        
        public Guid StatisticId { get; set; }
        public double AverageDifPrice { get; set; }
        public string AverageTimeOfDeal { get; set; } 
        
        public Guid SellerIdStatisticId { get; set; }
        public Seller Sel { get; set; }
      //  public Statistic() { }
           
    }
}
