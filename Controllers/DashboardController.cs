using Microsoft.AspNetCore.Mvc;

namespace Nompilo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
