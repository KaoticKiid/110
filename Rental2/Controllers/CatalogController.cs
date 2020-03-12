using System;
using Microsoft.AspNetCore.Mvc;
using Rental.Models;
using System.Collections.Generic;

namespace Rental.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetCatalog(){
            Car c1 = new Car();
            c1.Make = "Ford";
            c1.Model = "Mustang GT";
            c1.Year = "2003";
            c1.Cyls = "8";
            c1.Description = "STEEDA, 'Performance at its best, The top performing package";
            c1.DailyPrice = "12000";
            c1.ImageURL = "https://i.pinimg.com/originals/2d/e2/c4/2de2c4b2b6087f11fae5884a273dafe4.jpg";

            Car c2 = new Car();
            c2.Make = "Chevy";
            c2.Model = "Cobalt SS";
            c2.Year = "2006";
            c2.Cyls = "4";
            c2.Description = "The SS models offer a dynamic driving experience. Driving the SS Supercharged model is an absolute hoot. Quick, responsive handling and brisk acceleration performance along with a sporty-sounding exhaust note make the supercharged coupe entertaining to drive, a sport compact that can more than hold its own in the class.";
            c2.DailyPrice = "6000";
            c2.ImageURL = "https://i.ytimg.com/vi/L3pdvaGK-V4/maxresdefault.jpg";

            List<Car> list = new List<Car>();
            list.Add(c1);
            list.Add(c2);

            return Json(list);
        }
    }
}