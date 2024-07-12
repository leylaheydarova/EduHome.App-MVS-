using Microsoft.AspNetCore.Mvc;

namespace EduHome.App.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
