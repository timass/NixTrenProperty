using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NixTrenProperty.ViewModels
{
    public class CitiesViewModel
    {
        public string City { get; set; }
        public List<SelectListItem> Cities { get; } = new List<SelectListItem>
        { 
            //new SelectListItem {Value = " ", Text ="Choose city" } 
        };        
    }
}
