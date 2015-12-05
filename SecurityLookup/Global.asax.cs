using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        /// <summary>
        /// Not implemented. 
        /// This is where Application level exceptions should be logged and handled
        /// </summary>
        protected void Application_Error(object sender, EventArgs e)
        {

        }
    }
}
