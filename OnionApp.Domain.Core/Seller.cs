using System;
using System.Collections;
using System.Collections.Generic;

namespace OnionApp.Domain.Core
{
   public class Seller : User/*, IEnumerable*/ // who has no more than one sale deal a year or rent deal only for one address 
    {
        // public List<SalesFigures> Flist = new List<SalesFigures>(); //Statistics
        public  Guid SellerId { get; set; }
        public string Telephone { get; set; }
        //public Seller() { }
       // public Statistic Statistics;
        
        
        //public Seller(Guid userId, string name, string email, string password, string telephone)
        //{
        //    UserId = userId; Name = name; Email = email; Password = password;  Telephone = telephone;
        //}
        //public IEnumerator GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

    }
}
