using Microsoft.AspNetCore.Mvc;

namespace Nompilo.Controllers
{
    public class CounsellingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
