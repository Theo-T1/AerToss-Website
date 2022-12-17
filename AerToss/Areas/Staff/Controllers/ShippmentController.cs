using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AerToss.Areas.Shippments.Controllers
{
    [Area("Staff")]
    public class ShippmentController : Controller
    {
        // GET: ShippmentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShippmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShippmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShippmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShippmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShippmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShippmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShippmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
