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
        private readonly IEmailService _emailService;
        private readonly MvlszContext _context;
        public HomeController(MvlszContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            //List<User> users;
            //using (var uof = new UnitOfWork(_context))
            //{
            //    users = uof.CreateRepository<User>().GetAll();
            //}
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendMail([Bind("Address,Subject,Message")]EmailViewModel emailViewModel)
        {
            _emailService.SendEmail(emailViewModel.Address, emailViewModel.Subject, emailViewModel.Message);
            return RedirectToAction("Index");
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
