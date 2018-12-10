using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MagicBus.Common.Models;
using MagicBus.DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MagicBus.Models;
using Microsoft.AspNetCore.Authorization;

namespace MagicBus.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<MagicTrip> _magicTrips;
        public HomeController(IRepository<MagicTrip> mt)
        {
            _magicTrips = mt;
        }

        public IActionResult Index()
        {
            return View();
        }

     
        [HttpPost]
        public IActionResult Index([FromForm]ViewMagicTrip obj)
        {
            MagicTrip incoming_magictrip = new MagicTrip
            {
                DateAndTime = new DateTime(obj.Date.Year,obj.Date.Month,obj.Date.Day,obj.Time.Hour,obj.Time.Minute,obj.Time.Second)
            };
            _magicTrips.Insert(incoming_magictrip);
            _magicTrips.SaveChanges();
            return View();
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
