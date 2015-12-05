using System.Web.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();
            return View(model);
        }

        [HttpGet]
        public PartialViewResult GetSecurityTable(string symbol, string searchText)
        {
            HomeModel model = new HomeModel();
            model.LoadSecurities(symbol, searchText);

            return PartialView("SecurityTable", model);
        }

    }
}