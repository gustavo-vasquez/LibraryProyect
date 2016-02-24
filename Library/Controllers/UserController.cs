using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Capa_Entidades;
using Capa_Servicios;
using BotDetect.Web.UI.Mvc;
using System.Globalization;
using System.Threading;

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
            Thread.Sleep(1000);
            return PartialView("_Student", new Student());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [CaptchaValidation("CaptchaTextbox", "captchaStudent", "¡Código CAPTCHA incorrecto!")]
        public ActionResult Student(Student data, int idDays, int idMonths, int idYears)
        {
            if (ModelState.IsValid)
            {
                string message = "";
                DateTime birth = new DateTime(idYears, idMonths, idDays);
                birth.ToString("dd-mm-yyyy", CultureInfo.InvariantCulture);
                data.Person.BirthDate = birth;
                bool IsSuccess = userService.AddStudent(data, ref message);

                if (IsSuccess)
                {
                    return Content("<div id=formStudent><script>redirectToHome();</script></div>");
                }
                else
                {
                    ViewBag.ErrorProcedure = message;
                    return PartialView("_Student", data);
                }
            }
            else
            {
                return PartialView("_Student", data);
            }
        }
    }
}
