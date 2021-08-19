using Microsoft.AspNetCore.Mvc;
using System.Linq;
using OnionApp.Infrastructure.Data;
using System;
using OnionApp.Domain.Core;

namespace NixTrenProperty.Controllers
{
    public class HomeController : Controller
    {
        SellerContext db;
        public HomeController(SellerContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Action()
        {
            return View(db.Sellers.ToList());           
        }
        [HttpGet]
        public IActionResult GetStatistic(Guid? id)
        {
            if (id == null) { return RedirectToAction("Action"); }
            else
            {
                foreach (Statistic item in db.Statistics)
                {
                    if (item.SellerIdStatisticId == id)
                        ViewBag.stat = item;
                }
              return View();
            }
            
        }
        public IActionResult Login()
        {
            return View();
        }


    }
}
