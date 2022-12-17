using Microsoft.AspNetCore.Mvc;

namespace AerToss.Controllers
{
    public class LocationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
