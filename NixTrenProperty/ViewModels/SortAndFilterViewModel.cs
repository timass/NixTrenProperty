using OnionApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NixTrenProperty.ViewModels
{
    public class SortAndFilterViewModel
    {
        
        public IEnumerable<Advert> Adverts { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public SortViewModel SortViewModel { get; set; }
    }
}

