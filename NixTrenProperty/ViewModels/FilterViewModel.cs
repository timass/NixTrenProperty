using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace NixTrenProperty.ViewModels
{
    public class FilterViewModel
    {
        public FilterViewModel(List<string> typeObjects, string typeObject,
            bool RentOrSeal, string City)
        {
           // typeObjects.Insert(0, "All");
            TypeObjects = new SelectList(typeObjects);
            SelectedObject = typeObject;           
            SelectedRentOrSeal = RentOrSeal;            
            SelectedCity = City;
        }
        //public SelectList TypeObjects { get; private set; } 
        public SelectList TypeObjects { get; private set; }
        public string SelectedObject { get; private set; }
        public bool SelectedRentOrSeal { get; private set; }        
        public string SelectedCity { get; private set; }
}
}