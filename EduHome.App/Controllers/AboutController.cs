using Microsoft.AspNetCore.Mvc;

namespace EduHome.App.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
