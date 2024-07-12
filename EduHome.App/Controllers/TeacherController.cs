using Microsoft.AspNetCore.Mvc;

namespace EduHome.App.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
