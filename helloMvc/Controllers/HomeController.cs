﻿using helloMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolModel.Entities;
using SchoolModel.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace helloMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository studentRepo;

        public HomeController(ILogger<HomeController> logger,IStudentRepository studentRepo)
        {
            this.studentRepo = studentRepo;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var students = studentRepo.FindByLastnameLike("re"); 
            return View(students);
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

        //GET: prendi dei dati dal database da mostrare
        public IActionResult Students()
        {
            return View();
        }

    }
}
