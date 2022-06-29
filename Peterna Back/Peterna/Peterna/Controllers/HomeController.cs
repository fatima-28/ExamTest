using Microsoft.AspNetCore.Mvc;
using Peterna.DAL;
using Peterna.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peterna.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel
            {
                Services = _context.Services.Where(s => !s.IsDeleted).ToList()
            };
            return View(home);
        }
    }
}
