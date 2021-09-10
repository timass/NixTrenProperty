using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NixTrenProperty.ViewModels;
using OnionApp.Domain.Core;
using OnionApp.Infrastructure.Business;
using OnionApp.Infrastructure.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NixTrenProperty.Controllers
{
    public class HomeController : Controller
       
        
    {
            private ApplicationContext db;
            public HomeController(ApplicationContext context)
            {
                db = context;
            }


        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "User");
            }
            return View(await db.Adverts.ToListAsync());
        }
        public async Task<IActionResult> SortAndFilter(string typeObject, 
            bool rentOrSeal, string city, int page=1, SortAdverts sortOrder = SortAdverts.PriceAsc)
        {
            int pageSize = 3;
            //filtration
            IQueryable<Advert> adverts = db.Adverts;

            if (typeObject != null)
            {
                adverts = adverts.Where(p => p.typeObj == typeObject);
            }
         
                adverts = adverts.Where(p => p.RentOrSeal == rentOrSeal);
            if (!String.IsNullOrEmpty(city))
            {
                adverts = adverts.Where(p => p.City == city);
            }
                // sort
                switch (sortOrder)
            {
                case SortAdverts.PriceDesc:
                    adverts = adverts.OrderByDescending(s => s.FirstPrice);
                    break;
                case SortAdverts.DateAsc:
                    adverts = adverts.OrderBy(s => s.DateOfAdd);
                    break;
                case SortAdverts.DateDesc:
                    adverts = adverts.OrderByDescending(s => s.DateOfAdd);
                    break;                
                default:
                    adverts = adverts.OrderBy(s => s.FirstPrice);
                    break;
            }

            var count = await adverts.CountAsync();
            var items = await adverts.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            SortAndFilterViewModel viewModel = new SortAndFilterViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(Advert.typeList, typeObject, rentOrSeal, city),
                Adverts = items
            };
            return View(viewModel);
        }
        //public async Task<IActionResult> SearchAdvert(SortAdverts sortOrder = SortAdverts.PriceAsc)
        //{
        //    IQueryable<Advert> adverts = db.Adverts.Include(x => x.Price);

        //    ViewData["PriceSort"] = sortOrder == SortAdverts.PriceAsc ? SortAdverts.PriceDesc : SortAdverts.PriceAsc;

        //    adverts = sortOrder switch
        //    {
        //        SortAdverts.PriceAsc => adverts.OrderBy(s => s.Price),
        //        SortAdverts.PriceDesc => adverts.OrderByDescending(s => s.Price),
        //    };
        //    return View(await adverts.AsNoTracking().ToListAsync());
        //}
        [HttpPost]
        public async Task<IActionResult> AdvertView(string id)
        {
            Advert advert = await db.Adverts.FirstOrDefaultAsync(p => p.Id.ToString() == id);
            User user = await db.Users.FirstOrDefaultAsync(p => p.Name == advert.UserName);

            switch (advert.typeObj)
            {
                case "House":

                    House objH = await db.Houses.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);

                    AdvertViewModel<House> modelH = new AdvertViewModel<House>
                    {
                        Advert = advert,
                        User = user,
                        Object = objH
                    };
                    return View("ViewHouse", modelH);
                case "Plot":

                    Plot objP = await db.Plots.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);

                    AdvertViewModel<Plot> modelP = new AdvertViewModel<Plot>
                    {
                        Advert = advert,
                        User = user,
                        Object = objP
                    };

                    return View("ViewPlot", modelP);
                case "ParkingPlace":

                    ParkingPlace objPP = await db.ParkingPlaces.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);

                    AdvertViewModel<ParkingPlace> modelPP = new AdvertViewModel<ParkingPlace>
                    {
                        Advert = advert,
                        User = user,
                        Object = objPP
                    };

                    return View("ViewParkingPlace", modelPP);
                case "Garage":

                    Garage objG = await db.Garages.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);

                    AdvertViewModel<Garage> modelG = new AdvertViewModel<Garage>
                    {
                        Advert = advert,
                        User = user,
                        Object = objG
                    };

                    return View("ViewGarage", modelG);
                case "Apartment":

                    Apartment objA = await db.Apartments.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);

                    AdvertViewModel<Apartment> modelA = new AdvertViewModel<Apartment>
                    {
                        Advert = advert,
                        User = user,
                        Object = objA
                    };

                    return View("ViewApartment", modelA);
                case "ManyLevelsApartment":

                    ManyLevelsApartment objM = await db.ManyLevelsApartments.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);

                    AdvertViewModel<ManyLevelsApartment> modelM = new AdvertViewModel<ManyLevelsApartment>
                    {
                        Advert = advert,
                        User = user,
                        Object = objM
                    };

                    return View("ViewManyLevelsApartment", modelM);
                case "RoomIndividual":

                    RoomIndividual objRI = await db.RoomIndividuals.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);

                    AdvertViewModel<RoomIndividual> modelRI = new AdvertViewModel<RoomIndividual>
                    {
                        Advert = advert,
                        User = user,
                        Object = objRI
                    };

                    return View("ViewRoomIndividual", modelRI);
                case "RoomInFlat":

                    RoomInFlat objRF = await db.RoomInFlats.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);

                    AdvertViewModel<RoomInFlat> modelRF = new AdvertViewModel<RoomInFlat>
                    {
                        Advert = advert,
                        User = user,
                        Object = objRF
                    };

                    return View("ViewRoomInFlat", modelRF);
                default:
                    break;
            }
            return NotFound();
        }

        //public IActionResult Index()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        return RedirectToAction("Index", "User");
        //    }
        //    else return View();
        //}    
    }
}
