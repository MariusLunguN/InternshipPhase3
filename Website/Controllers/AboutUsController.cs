using System.Web.Mvc;
using DataAccess.Models;
using DataAccess.Services;
using Website.Models;

namespace Website.Controllers
{
    public class AboutUsController : Controller
    {
        private IEmployeeData _db;

        public AboutUsController(IEmployeeData db)
        {
            this._db = db;
        }

        public ActionResult Index()
        {
            var model = new AboutUsViewModel();

            model.EmployeeList = _db.GetAll();
            model.Title = "Employees";

            return View(model);
        }
    }
}