using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BindViews.Models;

namespace BindViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var restaurant = new Restaurant() {
                Id = 1,
                Name = "My Kitchen 1",
                Address = "New Brunswick, 2657 Webster Street",
                Speciality = "Hamburgers",
                Open = true,
                Review = 4
            };
            return View(restaurant);
        }
    }
}
