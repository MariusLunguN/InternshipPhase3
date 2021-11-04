using DataAccess.Models;
using DataAccess.Services;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class AdminController : Controller
    {
        private IEmployeeData _db;
        public AdminController(IEmployeeData db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_db.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Add(employee);

                return RedirectToAction("Details", new { id = employee.ID });
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Update(employee);
                TempData["Message"] = "You have saved the employee !";

                return RedirectToAction("Details", new { id = employee.ID });
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            var model = _db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var model = _db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            _db.Delete(id);

            return RedirectToAction("Index");
        }
    }
}