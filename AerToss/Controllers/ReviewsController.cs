using Microsoft.AspNetCore.Mvc;

namespace AerToss.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult All()
        {
            if (User.IsInRole("Administrator"))
            {
                return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }

            return View();
        }
    }
}
