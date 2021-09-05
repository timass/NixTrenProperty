using Microsoft.AspNetCore.Mvc;
using NixTrenProperty.Models;
using OnionApp.Domain.Core;
using System.Linq;
using System.Threading.Tasks;
//using TagHelpersApp.Models;

namespace NixTrenProperty.Controllers
{
    public class SellerController : Controller
    {
        ApplicationContext db;
        public SellerController(ApplicationContext context)
        {           
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddAdvert()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddAdvert(
            Plot plot, House house, ParkingPlace parkingPlace, Garage garage,
            Apartment apartment, ManyLevelsApartment manyLevelsApartment,
            RoomIndividual roomIndividual, RoomInFlat roomInFlat,
            string typeObj, string userName,
            bool rentOfSale, string paimentConditions, decimal firstPrice, string City)
        {
            string idObj = "";
            switch (typeObj)
            {
                case "Plot":
                    db.Plots.Add(plot);
                    idObj = plot.Id.ToString();
                    break;
                case "House":
                    db.Houses.Add(house);
                    idObj = house.Id.ToString();
                    break;
                case "ParkingPlace":
                    db.ParkingPlaces.Add(parkingPlace);
                    idObj = parkingPlace.Id.ToString();
                    break;
                case "Garage":
                    db.Garages.Add(garage);
                    idObj = garage.Id.ToString();
                    break;
                case "Apartment":
                    db.Apartments.Add(apartment);
                    idObj = apartment.Id.ToString();
                    break;
                case "ManyLevelsApartment":
                    db.ManyLevelsApartments.Add(manyLevelsApartment);
                    idObj = manyLevelsApartment.Id.ToString();
                    break;
                case "RoomIndividual":
                    db.RoomIndividuals.Add(roomIndividual);
                    idObj = roomIndividual.Id.ToString();
                    break;
                case "RoomInFlat":
                    db.RoomInFlats.Add(roomInFlat);
                    idObj = roomInFlat.Id.ToString();
                    break;
                default:
                    break;
            }
            Advert adv = new Advert
            {
                typeObj = typeObj,
                IdObj = idObj,
                RentOrSeal = rentOfSale,
                PaimentConditions = paimentConditions,
                FirstPrice = firstPrice,
                City = City
            };
            //CitiesViewModel cv = new CitiesViewModel();
            //cv.Cities.Add(new SelectListItem { Value = City, Text = City });
            db.Adverts.Add(adv);
            User[] sel = db.Users.Where(a => (a.Name == userName)).ToArray();
            if (sel.Length != 1)
                return View("ErrorSeller");
            sel[0].Adverts.Add(adv);
            db.SaveChanges();
            return RedirectToAction("Index", "User");
        }
        [HttpGet]
        public IActionResult SearchRieltors()
        {
           
            return View();
        }
    }
}
