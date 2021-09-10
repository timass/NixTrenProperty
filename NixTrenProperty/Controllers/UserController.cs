using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnionApp.Domain.Core;
using OnionApp.Infrastructure.Data;
using System.Threading.Tasks;

namespace NixTrenProperty.Controllers
{
    public class UserController : Controller
        
    {
        private readonly UserManager<User> _userManager;
        ApplicationContext db;
        public UserController(UserManager<User> userManager, ApplicationContext context)
        {
            _userManager = userManager;
            db = context;
        }

        
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var roles = await _userManager.GetRolesAsync(user);
            if (roles.Contains("seller"))
                return RedirectToAction("Index", "Seller");
            if (roles.Contains("admin"))
                return RedirectToAction("Index", "Admin");
            return View();
            //return View(await db.Adverts.ToListAsync());
        }    
    }
}
