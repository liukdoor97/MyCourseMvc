using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModels;

namespace MyCourse.Controllers
{
    // [Route("[controller]")]
    public class CoursesController : Controller
    {
        // private readonly ILogger<CoursesController> _logger;

        // public CoursesController(ILogger<CoursesController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index()
        {
            char courseService = new CourseService(); // il Controller crea un oggetto del servizio applicativo che deve utilizzare
            List<CourseViewModel> courses = courseService.GetService(); // recupero la lista dei corsi
            // return Content("Sono Index");
            return View(courses);
        }

        public IActionResult Detail()
        {
            // return Content($"Sono Content ed ho l'id {id}");
            return View();

        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}