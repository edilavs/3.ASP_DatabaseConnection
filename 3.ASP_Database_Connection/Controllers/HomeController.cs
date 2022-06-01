using _3.ASP_Database_Connection.DAL;
using _3.ASP_Database_Connection.Models;
using _3.ASP_Database_Connection.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3.ASP_Database_Connection.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = sliders,
                
            };

            return View(homeVM);

        }
        public IActionResult About()
        {
            return View();

        }
    }
}
