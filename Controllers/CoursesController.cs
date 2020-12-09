using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModels;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(){
            var courseService = new CourseService();
            List<CourseViewModel> courses = courseService.GetCourses();
            ViewData["Title"] = "Elenco Corsi";
            return View(courses);
        }

        public IActionResult Detail(string id){
            var courseService = new CourseService();
            CourseDetailViewModel course = courseService.GetCourse(id);
            ViewData["Title"] = course.Title;
            return View(course);
        }
    }
}