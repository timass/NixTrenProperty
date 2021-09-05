using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.App.Infrastructure.Business
{
    public enum TypesObject
    {
        [Display(Name = "Plot")]
        Plot,
        [Display(Name = "House")]
        House,
        [Display(Name = "ParkingPlace")]
        ParkingPlace,
        [Display(Name = "Ночь")]
        Night
    }
}
