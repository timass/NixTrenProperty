using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NixTrenProperty.Models;
using OnionApp.Domain.Core;
using System;
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
        public async Task<IActionResult> MyAdverts()
        {
            return View(await db.Adverts.ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {

            Advert advert = await db.Adverts.FirstOrDefaultAsync(p => p.Id.ToString() == id);
            if (advert != null)
                return View(advert);
            else return NotFound();
        }
      
        [HttpPost]
        public async Task<IActionResult> Edit(Advert advert)
        {
            db.Adverts.Update(advert);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Seller");
        }
       

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {

            Advert advert = await db.Adverts.FirstOrDefaultAsync(p => p.Id == id);
            if (advert != null)
            {
               db.Adverts.Remove(advert);
               await db.SaveChangesAsync();
               return RedirectToAction("Index", "Seller");
            }            
            return NotFound();
        }

        [HttpGet]
        public IActionResult AddAdvert()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAdvert(
            Plot plot, House house, ParkingPlace parkingPlace, Garage garage,
            Apartment apartment, ManyLevelsApartment manyLevelsApartment,
            RoomIndividual roomIndividual, RoomInFlat roomInFlat,
            string typeObj, string userName,
            bool rentOfSale, string paimentConditions, int firstPrice, string City)
        {
            Guid idObj = new Guid();
            switch (typeObj)
            {
                case "Plot":
                    db.Plots.Add(plot);
                    idObj = plot.Id;
                    break;
                case "House":
                    db.Houses.Add(house);
                    idObj = house.Id;
                    break;
                case "ParkingPlace":
                    db.ParkingPlaces.Add(parkingPlace);
                    idObj = parkingPlace.Id;
                    break;
                case "Garage":
                    db.Garages.Add(garage);
                    idObj = garage.Id;
                    break;
                case "Apartment":
                    db.Apartments.Add(apartment);
                    idObj = apartment.Id;
                    break;
                case "ManyLevelsApartment":
                    db.ManyLevelsApartments.Add(manyLevelsApartment);
                    idObj = manyLevelsApartment.Id;
                    break;
                case "RoomIndividual":
                    db.RoomIndividuals.Add(roomIndividual);
                    idObj = roomIndividual.Id;
                    break;
                case "RoomInFlat":
                    db.RoomInFlats.Add(roomInFlat);
                    idObj = roomInFlat.Id;
                    break;
                default:
                    break;
            }
            Advert adv = new Advert
            {
                typeObj = typeObj,
                ObjectSId = idObj,
                RentOrSeal = rentOfSale,
                PaimentConditions = paimentConditions,
                FirstPrice = firstPrice,
                City = City
            };
            //CitiesViewModel cv = new CitiesViewModel();
            //cv.Cities.Add(new SelectListItem { Value = City, Text = City });
            db.Adverts.Add(adv);
            User sel = await db.Users.FirstOrDefaultAsync(a => (a.UserName == userName));                   
            sel.Adverts.Add(adv);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Seller");
        }

        public async Task<IActionResult> SearchRieltors()
        {
            var rieltors = db.Users.Where(a => a.Rieltor == true);
            return View(await rieltors.ToListAsync());
        }        
    }
}
