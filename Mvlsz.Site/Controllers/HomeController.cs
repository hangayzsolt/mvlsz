using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using Mvlsz.Persistance;
using Mvlsz.Persistance.Entities;
using Mvlsz.Persistance.Implementations;
using Mvlsz.Persistance.Interfaces;
using Mvlsz.Site.Models;

namespace Mvlsz.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly MvlszContext _context;
        public HomeController(MvlszContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<User> users;
            using (var uof = new UnitOfWork(_context))
            {
                users = uof.CreateRepository<User>().GetAll();
            }
            return View(users);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
