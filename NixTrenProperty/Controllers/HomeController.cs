using Microsoft.AspNetCore.Mvc;
using NixTrenProperty.Models;
using Microsoft.AspNetCore.Identity;
using OnionApp.Domain.Core;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using OnionApp.Infrastructure.Business;

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
            else return View(await db.Adverts.ToListAsync());
        }
        public async Task<IActionResult> SearchAdvert(SortAdverts sortOrder = SortAdverts.PriceAsc)
        {
            IQueryable<Advert> adverts = db.Adverts.Include(x => x.Price);

            ViewData["PriceSort"] = sortOrder == SortAdverts.PriceAsc ? SortAdverts.PriceDesc : SortAdverts.PriceAsc;

            adverts = sortOrder switch
            {                
                SortAdverts.PriceAsc => adverts.OrderBy(s => s.Price),
                SortAdverts.PriceDesc => adverts.OrderByDescending(s => s.Price),              
            };
            return View(await adverts.AsNoTracking().ToListAsync());
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
