using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Capa_Entidades;
using Capa_Servicios;
using BotDetect.Web.UI.Mvc;
using System.Globalization;

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
        [CaptchaValidation("CaptchaTextbox", "captchaStudent", "¡Código CAPTCHA incorrecto!")]
        public ActionResult Student(Student data, int idDays, int idMonths, int idYears)
        {
            if (ModelState.IsValid)
            {
                DateTime birth = new DateTime(idYears, idMonths, idDays);
                birth.ToString("dd-mm-yyyy", CultureInfo.InvariantCulture);
                data.Person.BirthDate = birth;
                bool IsSuccess = userService.AddStudent(data);

                if (IsSuccess)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["ErrorMessageSP"] = "Ocurrió un error en el registro";
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
