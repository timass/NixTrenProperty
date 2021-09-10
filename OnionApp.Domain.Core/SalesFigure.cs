using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{

    [Table("SalesFigure")]
    public class SalesFigure 
    {
        public Guid Id { get; set; }        
        public bool SaleOrRent { get; set; }
        public decimal PriceDifference { get; set; }
        public TimeSpan TimeDifference { get; set; }
        public Guid StatisticId { get; set; }
        public Statistic Statistic { get; set; }
    }
}
