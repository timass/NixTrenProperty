using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnionApp.Domain.Core
{
    [Table("Adverts")] 
    public class Advert
    {        
        public Guid Id { get; set; }
        public DateTime DateOfAdd { get; } = DateTime.Today;
        public DateTime? DateConfirm { get; set; }
        public DateTime Date;
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
        public int FirstPrice { get; set; }
        public int? LastPrice { get; set; }
        public int Price;

        public decimal price
        {
            get { return Price; }
            set
            {
                if (LastPrice != null)
                    Price = (int)LastPrice;
                else Price = FirstPrice;
            }
        }
        [Required]
        public string City { get; set; }
        //public void ConfirmActual()
        //{
        //    DateConfirm = DateTime.Today;
        //}
        //public void ChangePrice(decimal newprice)
        //{
        //    LastPrice = newprice;
        //}   
    }
}
