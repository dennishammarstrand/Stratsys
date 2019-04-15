using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Client.Models;
using Client.Services;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        private ISkiLengthService skiLengthService;

        public HomeController(ISkiLengthService _skiLengthService)
        {
            skiLengthService = _skiLengthService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> LengthRequest(Skiier skiier)
        {
            if (ModelState.IsValid)
            {
                skiier.SkiLength = await skiLengthService.Fetch(skiier);
                return View("Index", skiier);
            }
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
