using Microsoft.AspNetCore.Mvc;
using OnionApp.Domain.Core;
using OnionApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using NixTrenProperty.Models;
using Microsoft.AspNetCore.Identity;
using NixTrenProperty.ViewModels;
using Microsoft.EntityFrameworkCore;

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
