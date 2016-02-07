using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Map()
        {
            return View();
        }

        public ActionResult About()
        {                        
            //throw new HttpException(400, "error de bad request");
            return View();
        }

        public ActionResult Books()
        {
            return View();
        }

        public ActionResult BookDetails()
        {
            return PartialView();
        }

    }
}
