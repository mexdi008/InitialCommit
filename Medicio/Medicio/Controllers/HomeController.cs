using Microsoft.AspNetCore.Mvc;

namespace Medicio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
