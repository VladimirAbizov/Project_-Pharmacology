using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebServiceFarmoc.Controllers
{
    public class BasicController : Controller
    {
        //
        // GET: /Basic/
        public void Execute(RequestContext requestContext)
        {
            string controller = (string)requestContext.RouteData.Values["controller"];
            string action = (string)requestContext.RouteData.Values["action"];

            requestContext.HttpContext.Response.Write(
                    string.Format("Контроллер: {0}, Метод действия: {1}",
                    controller, action));
        }

    }
}
