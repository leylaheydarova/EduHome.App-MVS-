using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace EduHome.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
