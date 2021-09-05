using Microsoft.AspNetCore.Mvc;
using OnionApp.Domain.Core;
using OnionApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using TagHelpersApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using NixTrenProperty.Models;
using Microsoft.AspNetCore.Identity;
using NixTrenProperty.ViewModels;

namespace NixTrenProperty.Controllers
{
    public class UserController : Controller
        //where T : ObjectS
    {
        private readonly UserManager<User> _userManager;
        ApplicationContext db;
        public UserController(UserManager<User> userManager, ApplicationContext context)
        {
            _userManager = userManager;
            db = context;
        }
        //public async Task<string> RoleSaver()
        //{
        //    string role ="";
        //    var user =  await _userManager.FindByNameAsync(User.Identity.Name);
        //    var roles = await _userManager.GetRolesAsync(user);
        //    if (roles.Contains("user"))
        //        role = "us";
        //    if (roles.Contains("seller"))
        //        role = "sel+us";
        //    if (roles.Contains("admin"))
        //        role = "admin";
        //    return role;
        //}       
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var roles = await _userManager.GetRolesAsync(user);
            if (roles.Contains("seller"))
                return RedirectToAction("Index", "Seller");
            if (roles.Contains("admin"))
                return RedirectToAction("Index", "Admin");           
            return View();
        }    
    }
}
