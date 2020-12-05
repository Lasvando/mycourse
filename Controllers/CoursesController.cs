using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(){
            return Content("Index");
        }

        public IActionResult Detail(string id){
            return Content($"Detail, ho ricevuto l'ID: {id}");
        }
    }
}