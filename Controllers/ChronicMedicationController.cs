using Microsoft.AspNetCore.Mvc;

namespace Nompilo.Controllers
{
    public class ChronicMedicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
