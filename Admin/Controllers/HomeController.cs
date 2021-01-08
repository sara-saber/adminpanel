using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Admin.Models;

namespace Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["class_1"] = "bg-info";
            ViewData["number_1"] = "150";
            ViewData["name_1"] = "New Orders";
            ViewData["icon_1"] = "ion-bag";

            ViewData["class_2"] = "bg-success";
            ViewData["number_2"] = "53";
            ViewData["name_2"] = "Bounce Rate";
            ViewData["icon_2"] = "ion-stats-bars";

            ViewData["class_3"] = "bg-warning";
            ViewData["number_3"] = "44";
            ViewData["name_3"] = "User Registrations";
            ViewData["icon_3"] = "ion-person-add";


            ViewData["class_4"] = "bg-danger";
            ViewData["number_4"] = "65";
            ViewData["name_4"] = "Unique Visitors";
            ViewData["icon_4"] = "ion-pie-graph";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index1()
        {
            ViewData["class_1"] = "bg-info";
            ViewData["number_1"] = "10";
            ViewData["text_1"] = "CPU Traffic";
            ViewData["icon_1"] = "fas fa-cog";

            ViewData["class_2"] = "bg-danger";
            ViewData["number_2"] = "41,410";
            ViewData["text_2"] = "Likes";
            ViewData["icon_2"] = "fas fa-thumbs-up";

            ViewData["class_3"] = " bg-success";
            ViewData["number_3"] = "760";
            ViewData["text_3"] = "Sales";
            ViewData["icon_3"] = "fas fa-shopping-cart";

            ViewData["class_4"] = "bg-warning";
            ViewData["number_4"] = "2,000";
            ViewData["text_4"] = "New Members";
            ViewData["icon_4"] = "fas fa-users";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
