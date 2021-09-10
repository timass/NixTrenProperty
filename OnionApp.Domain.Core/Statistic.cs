using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    [Table("Statistic")]
    public class Statistic
    {       
        public Guid Id { get; set; }
        public double AverageDifPrice { get; set; }
        public string AverageTimeOfDeal { get; set; }
        public List<SalesFigure> SalesFigures {get; set;}
       
    }
}
