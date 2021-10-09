using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFSchoolPersistence.EF;
using SchoolModel.Entities;
using SchoolModel.Services;
using Microsoft.Extensions.Logging;

namespace helloMvc.Controllers
{
    public class CourseController : Controller
    {
        private readonly SchoolContext _context;

        #region Prop
        private readonly ILogger<CourseController> _logger;
        private readonly IDidactisService didacticsService;
        #endregion

        public CourseController(ILogger<CourseController> logger, IDidactisService didacticsService)
        {
            this._logger = logger;
            this.didacticsService = didacticsService;
        }



        // GET: Course
        public IActionResult Index()
        {
            var courses = didacticsService.GetAllCourses().ToList();
            return View(courses);
        }
    }
}
