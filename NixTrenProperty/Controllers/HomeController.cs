using Microsoft.AspNetCore.Mvc;
using NixTrenProperty.Models;
using Microsoft.AspNetCore.Identity;
using OnionApp.Domain.Core;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using OnionApp.Infrastructure.Business;
using System;
using NixTrenProperty.ViewModels;

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


            // House o = await db.Houses.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);
            


            switch (advert.typeObj)
            {
                case "House":

                    House objH = await db.Houses.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);

                    AdvertViewModel<Plot> modelH = new AdvertViewModel<Plot>
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
               

                //    case "House":

                //        obj = await db.Houses.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);
                //        break;
                //    case "ParkingPlace":

                //        obj = await db.ParkingPlaces.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);
                //        break;
                //    case "Garage":

                //        obj = await db.Garages.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);
                //        break;
                //    case "Apartment":

                //        obj = await db.Apartments.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);
                //        break;
                //    case "ManyLevelsApartment":

                //        obj = await db.ManyLevelsApartments.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);
                //        break;
                //    case "RoomIndividual":

                //        obj = await db.RoomIndividuals.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);
                //        break;
                //    case "RoomInFlat":

                //        obj = await db.RoomInFlats.FirstOrDefaultAsync(p => p.Id == advert.ObjectSId);
                //        break;
                //    default:
                //        break;
                //}
                //AdvertViewModel<House> mod = new AdvertViewModel<House>
                //{ 
                //    Advert = advert,
                //    User = user, 
                //    Object = obj
                //};






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
