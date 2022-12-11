using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AerToss.Controllers
{
    public class ShippingController : Controller
    {
        // GET: Shipping
        public ActionResult Index()
        {
            return View();
        }

        // GET: Shipping/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Shipping/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shipping/Create
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

        // GET: Shipping/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shipping/Edit/5
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

        // GET: Shipping/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shipping/Delete/5
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
