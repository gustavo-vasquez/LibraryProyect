using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Capa_Entidades;
using Capa_Servicios;
using BotDetect.Web.UI.Mvc;

namespace Library.Controllers
{
    public class UserController : Controller
    {
        static UserServices userService = new UserServices();

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

        public ActionResult Student()
        {
            return PartialView("_Student", new Student());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [CaptchaValidation("CaptchaTextbox", "captchaStudent", "Incorrect CAPTCHA code!")]
        public ActionResult Student(Student register)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return PartialView("_Student", register);
            }            
        }
    }
}
