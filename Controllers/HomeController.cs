using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            ViewData["Title"] = "Home";
            return View();
        }
    }
}