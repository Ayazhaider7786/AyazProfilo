using Microsoft.AspNetCore.Mvc;

namespace profilo.Controllers
{
    public class ProfiloController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
