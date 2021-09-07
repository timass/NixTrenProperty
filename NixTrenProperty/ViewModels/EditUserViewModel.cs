using OnionApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NixTrenProperty.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }       
        public string Telephone { get; set; }
        public List<Advert> Adverts { get; set; }
        public bool Rieltor { get; set; }
        public Statistic Stata { get; set; }
    }
}
