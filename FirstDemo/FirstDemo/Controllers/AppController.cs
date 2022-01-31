using Microsoft.AspNetCore.Mvc;

namespace FirstDemo.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Customer()
        {
            return View();
        }
    }
}
