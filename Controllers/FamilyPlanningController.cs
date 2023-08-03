using Microsoft.AspNetCore.Mvc;

namespace Nompilo.Controllers
{
    public class FamilyPlanningController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
