using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BindViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Id = 1;
            ViewBag.Name = "My Kitchen 1";
            ViewBag.Address = "New Brunswick, 2657 Webster Street";
            ViewBag.Speciality = "Hamburgers";
            ViewBag.Open = true;
            ViewBag.Review = 4;

            return View();
        }
    }
}
