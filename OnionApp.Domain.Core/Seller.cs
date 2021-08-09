using System;
using System.Collections;
using System.Collections.Generic;

namespace OnionApp.Domain.Core
{
   public class Seller : User, IEnumerable // who has no more than one sale deal a year or rent deal only for one address 
    {
        public List<SalesFigures> Flist = new List<SalesFigures>(); //Statistics
        public string Telephone { get; set; }
        public string Passport { get; set; }
        
        public Seller(int userId, string name, string email, string parol, string telephone, string passport)
        {
            UserId = userId; Name = name; Email = email; Parol = parol;  Telephone = telephone; Passport = passport; 
        }
        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
