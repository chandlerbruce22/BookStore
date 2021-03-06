﻿using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //Initialize the repo
        private iBookRepository _repository;

        //Send the repoe through the home controller
        public HomeController(ILogger<HomeController> logger, iBookRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //Send the context repo to display through the index view.
        // Check if the model is valid (With a prepopulated DB, it'll always be valid.
        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {
                return View(_repository.Books);
            }
            else
            {
                return View();
            }
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
