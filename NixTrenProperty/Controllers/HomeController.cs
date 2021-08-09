using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NixTrenProperty.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;
using OnionApp.Services.Interfaces;

namespace NixTrenProperty.Controllers
{
    public class HomeController<O> : Controller
        where O : ObjectS
    {
        IObjectSRepository<O> repo;

        private readonly ILogger<HomeController<O>> _logger;

        public HomeController(ILogger<HomeController<O>> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
