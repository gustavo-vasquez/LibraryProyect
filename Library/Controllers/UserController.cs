using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            return PartialView();
        }

        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult Employee()
        {
            return View();
        }

        public ActionResult Student()
        {
            return View();
        }

    }
}
