using Microsoft.AspNetCore.Mvc;

namespace Nompilo.Controllers
{
    public class ReferralsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
