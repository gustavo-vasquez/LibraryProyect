using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Capa_Entidades;
using Capa_Servicios;

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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Student(Student register)
        {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index", "Home");
                }

                return View(register);                                        
        }

        //public ActionResult Careers()
        //{
        //    //SelectList list = new SelectList(userService.ListOfCareers(), "Value", "Text", new SelectListItem() { Value = "0", Text = "Elegir carrera universitaria...", Selected = true });            
        //    return PartialView();
        //}

        public ActionResult BirthDate()
        {
            return PartialView();
        }
    }
}
