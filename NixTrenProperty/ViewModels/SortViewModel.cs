using OnionApp.Infrastructure.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NixTrenProperty.ViewModels
{
    public class SortViewModel
    {
       
        public SortAdverts PriceSort { get; private set; } // sort for price
        public SortAdverts DateSort { get; private set; }
        public SortAdverts Current { get; private set; }     // current sort value

        public SortViewModel(SortAdverts sortOrder)
            {
                PriceSort = sortOrder == SortAdverts.PriceAsc ? SortAdverts.PriceDesc : SortAdverts.PriceAsc;
                DateSort = sortOrder == SortAdverts.DateAsc ? SortAdverts.DateDesc : SortAdverts.DateAsc;
                Current = sortOrder;
        }
        
    }
}
