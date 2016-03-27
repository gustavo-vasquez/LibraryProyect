using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Objects;

using Library.Models;
using Capa_Entidades;
using Capa_Servicios;
using System.Data.SqlClient;

namespace Library.Controllers
{
    public class AdministratorController : Controller
    {
        static UserServices userService = new UserServices();
        static AdministratorServices adminService = new AdministratorServices();

        //
        // GET: /Administrator/

        public ActionResult CreateBook()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBook(Book data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    adminService.CreateNewBook(data);
                    return RedirectToAction("ControlPanel", "Administrator");
                }

                throw new Exception();
            }
            catch (Exception ex)
            {
                if (ex.InnerException is SqlException)
                {
                    ViewBag.ErrorBook = ex.InnerException.Message;
                    return View(data);
                }
                    
                return View(data);
            }
                        
        }

        public ActionResult EditBook(int id)
        {
            return View(adminService.SearchBook(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditBook(int id, Book data, bool onlyStock, int modifyStock, string plusOrMinus)
        {
            try
            {                
                if (onlyStock)
                {
                    adminService.EditStockData(id, modifyStock, plusOrMinus);
                    return RedirectToAction("ControlPanel");
                }

                if (ModelState.IsValid)
                {
                    adminService.EditBookData(id, data, modifyStock, plusOrMinus);
                    return RedirectToAction("ControlPanel");
                }

                throw new Exception();
            }
            catch (Exception ex)
            {
                if (ex.InnerException is SqlException)
                {
                    ViewBag.EditError = ex.InnerException.Message;
                    return View(data);
                }

                return View(data);
            }
        }

        public ActionResult DeleteBook()
        {
            return View();
        }

        public ActionResult ControlPanel()
        {
            return View(adminService.GetBooksList());
        }

        public ActionResult RegisteredUsers()
        {
            var list = new SelectList(new[]
                           {
                               new { value = "recent", text = "Más recientes primero" },
                               new { value = "first", text = "Más antiguos primero" },
                               new { value = "AtoZ", text = "Apellido ascendente (A-Z)" },
                               new { value = "ZtoA", text = "Apellido descendente (Z-A)" },
                               new { value = "Administrator", text = "Administrador" },
                               new { value = "Employee", text = "Empleado" },
                               new { value = "Student", text = "Estudiante" },
                           }, "value", "text", "recent");
            ViewData["list"] = list;            

            List<sp_ShowPersons_Result> listOfUsers = userService.ListOfPersons("recent");
            return View(listOfUsers);
        }

        [HttpPost]
        public ActionResult RegisteredUsers(string filterList)
        {
            var list = new SelectList(new[]
                           {
                               new { value = "recent", text = "Más recientes primero" },
                               new { value = "first", text = "Más antiguos primero" },
                               new { value = "AtoZ", text = "Apellido ascendente (A-Z)" },
                               new { value = "ZtoA", text = "Apellido descendente (Z-A)" },
                               new { value = "Administrator", text = "Administrador" },
                               new { value = "Employee", text = "Empleado" },
                               new { value = "Student", text = "Estudiante" },
                           }, "value", "text", "recent");
            ViewData["list"] = list;

            List<sp_ShowPersons_Result> listOfUsers = userService.ListOfPersons(filterList);
            return View(listOfUsers);
        }        

    }
}
