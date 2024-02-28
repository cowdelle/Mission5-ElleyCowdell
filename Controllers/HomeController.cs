using Mission5_ElleyCowdell.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mission5_ElleyCowdell.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }



        }

    }
