﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models.ViewModels;
using System.Diagnostics;

namespace SalesWebMvc.Controllers
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
            ViewData["Message"] = "Sales Web Mvc - Curse of C#";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["e-mail"] = "bruno.machado@lg.com.br";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}