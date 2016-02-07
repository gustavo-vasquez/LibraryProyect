using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Loans_Granted()
        {
            return View();
        }

        public ActionResult Applied_Sanctions()
        {
            return View();
        }

    }
}
