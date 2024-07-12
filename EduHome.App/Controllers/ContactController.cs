using Microsoft.AspNetCore.Mvc;

namespace EduHome.App.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
