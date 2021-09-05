using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnionApp.Domain.Core
{
   [Table("Adverts")] 
    public class Advert
    {        
        public Guid Id { get; set; }
        public DateTime DateOfAdd { get; } = DateTime.Today;
        DateTime? DateConfirm { get; set; }
        DateTime Date;
        public DateTime date
        {
            get { return Date; }
            set
            {
                if (DateConfirm != null)
                    Date = (DateTime)DateConfirm;
                else Date = DateOfAdd;
            }
        }
        public string typeObj { get; set; }               
        public string IdObj { get; set; }
        [Required]
        public bool RentOrSeal { get; set; } // true -Seal, false -rent
        public string PaimentConditions { get; set; }
        [Required]
        public decimal FirstPrice { get; set; }
        public decimal? LastPrice { get; set; }
        public decimal Price;

        public decimal price
        {
            get { return Price; }
            set
            {
                if (LastPrice != null)
                    Price = (decimal)LastPrice;
                else Price = FirstPrice;
            }
        }
        [Required]
        public string City { get; set; }
        public void ConfirmActual()
        {
            DateConfirm = DateTime.Today;
        }
        public void ChangePrice(decimal newprice)
        {
            LastPrice = newprice;
        }
        public void ChangePaimentConditions(string newPaimentConditions)
        {
            PaimentConditions = newPaimentConditions;
        }
        
    }
}
