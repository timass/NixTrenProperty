using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NixTrenProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NixTrenProperty.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationContext db;
        public AdminController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
