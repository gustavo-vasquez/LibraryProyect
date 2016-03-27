using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult BadRequest()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult InternalServer()
        {
            return View();
        }

    }
}
