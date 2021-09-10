using OnionApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NixTrenProperty.ViewModels
{
    public class AdvertViewModel<T>
    where T : ObjectS

    {
        public Advert Advert { get; set; }
        public User User { get; set; }
        public T Object { get; set; }       
    }
}
