using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModels;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;

        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        public async System.Threading.Tasks.Task<IActionResult> Index(){
            List<CourseViewModel> courses = await courseService.GetCoursesAsync();
            ViewData["Title"] = "Elenco Corsi";
            return View(courses);
        }

        public async System.Threading.Tasks.Task<IActionResult> Detail(int id){
            CourseDetailViewModel course = await courseService.GetCourseAsync(id);
            ViewData["Title"] = course.Title;
            return View(course);
        }
    }
}