using Microsoft.AspNetCore.Mvc;

namespace Nompilo.Controllers
{
    public class VaccinationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
