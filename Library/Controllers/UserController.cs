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
using Library.Models;

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

        //public ActionResult Login()
        //{
        //    return PartialView("_Login", new Login());
        //}

        public ActionResult Student()
        {
            Thread.Sleep(1000);
            return PartialView("_Student");
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

        public ActionResult Employee()
        {
            Thread.Sleep(1000);
            return PartialView("_Employee");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [CaptchaValidation("CaptchaTextbox", "captchaEmployee", "¡Código CAPTCHA incorrecto!")]
        public ActionResult Employee(Employee data, int idDays, int idMonths, int idYears)
        {
            if (ModelState.IsValid)
            {
                string message = "";
                DateTime birth = new DateTime(idYears, idMonths, idDays);
                birth.ToString("dd-mm-yyyy", CultureInfo.InvariantCulture);
                data.Person.BirthDate = birth;                
                bool IsSuccess = userService.AddEmployee(data, ref message);

                if (IsSuccess)
                {
                    return Content("<div id=formEmployee><script>redirectToHome();</script></div>");
                }
                else
                {
                    ViewBag.ErrorProcedure = message;
                    return PartialView("_Employee", data);
                }
            }
            else
            {
                return PartialView("_Employee", data);
            }
        }

        public ActionResult Administrator()
        {
            Thread.Sleep(1000);
            return PartialView("_Administrator");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [CaptchaValidation("CaptchaTextbox", "captchaAdministrator", "¡Código CAPTCHA incorrecto!")]
        public ActionResult Administrator(Administrator data, int idDays, int idMonths, int idYears, string nameGroup)
        {
            if (ModelState.IsValid)
            {
                string message = "";
                DateTime birth = new DateTime(idYears, idMonths, idDays);
                birth.ToString("dd-mm-yyyy", CultureInfo.InvariantCulture);
                data.Person.BirthDate = birth;
                data.PoliticalGroup = nameGroup;
                bool IsSuccess = userService.AddAdministrator(data, ref message);

                if (IsSuccess)
                {
                    return Content("<div id=formAdministrator><script>redirectToHome();</script></div>");
                }
                else
                {
                    ViewBag.ErrorProcedure = message;
                    return PartialView("_Administrator", data);
                }
            }
            else
            {
                return PartialView("_Administrator", data);
            }
        }
    }
}
