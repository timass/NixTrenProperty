using Microsoft.AspNetCore.Identity;
using OnionApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace OnionApp.Domain.Core
{
    public class User : IdentityUser, IName
    {
        public string Name { get; set; }       
        public DateTime DateOfRegistration { get;} = DateTime.Now;
        public string Telephone { get; set; }
        public List<Advert> Adverts { get; set; } = new List<Advert>();
        public bool Rieltor { get; set; }
        public Statistic Stata { get; set; }
       

    }
}
