using Microsoft.AspNetCore.Mvc;
using NixTrenProperty.Models;
using Microsoft.AspNetCore.Identity;
using OnionApp.Domain.Core;
using System.Threading.Tasks;

namespace NixTrenProperty.Controllers
{
    public class HomeController : Controller
        
    {
         public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "User");
            }
            else return View();
        }    
    }
}
