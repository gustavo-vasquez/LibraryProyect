using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Loans()
        {
            return View();
        }

        public ActionResult Sanctions()
        {
            return View();
        }

    }
}
