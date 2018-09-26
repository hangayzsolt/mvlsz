using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvlsz.Persistance.Entities;
using Mvlsz.Persistance.Implementations;
using Mvlsz.Site.Areas.Admin.Models;

namespace Mvlsz.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly MvlszContext _context;
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Create()
        {
            MatchViewModel matchVm = new MatchViewModel();
            return View(matchVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Place,DateTime,Division,HomeTeam,VisitorTeam")]MatchViewModel matchViewModel)
        {
            if (!ModelState.IsValid)
                return View(matchViewModel);

            using (var uow = new UnitOfWork(_context))
            {
                uow.CreateRepository<Match>().Add(new Match
                {
                    Id = Guid.NewGuid(),
                    Division = matchViewModel.Division,
                    DateTime = matchViewModel.DateTime,
                    Place = matchViewModel.Place,
                    HomeTeam = matchViewModel.HomeTeam,
                    VisitorTeam = matchViewModel.VisitorTeam
                });
                uow.Save();
            }
            return RedirectToAction("Index");
        }
    }
}