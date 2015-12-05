using System;
using System.Web.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// Not implemented. 
        /// This is where Controller level exceptions should be logged and handled
        /// </summary>
        protected override void OnException(ExceptionContext filterContext)
        {
            Console.WriteLine("filterContext: {0}", filterContext.Exception);
        }

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