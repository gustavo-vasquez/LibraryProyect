using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Objects;

using Library.Models;
using Capa_Entidades;
using Capa_Servicios;

namespace Library.Controllers
{
    public class AdministratorController : Controller
    {
        static UserServices userService = new UserServices();

        //
        // GET: /Administrator/

        public ActionResult CreateBook()
        {
            return View();
        }

        public ActionResult EditBook()
        {
            return View();
        }

        public ActionResult DeleteBook()
        {
            return View();
        }

        public ActionResult ControlPanel()
        {
            List<GridTest> listado = new List<GridTest>();

            listado.Add(new GridTest() { posicion = 1, equipo = "River Plate" });
            listado.Add(new GridTest() { posicion = 2, equipo = "San Lorenzo" });
            listado.Add(new GridTest() { posicion = 3, equipo = "Independiente" });
            listado.Add(new GridTest() { posicion = 4, equipo = "Newell's" });
            listado.Add(new GridTest() { posicion = 5, equipo = "Rosario Central" });
            listado.Add(new GridTest() { posicion = 6, equipo = "Estudiantes" });
            listado.Add(new GridTest() { posicion = 7, equipo = "Banfield" });
            listado.Add(new GridTest() { posicion = 8, equipo = "Velez" });
            listado.Add(new GridTest() { posicion = 9, equipo = "Lanús" });
            listado.Add(new GridTest() { posicion = 10, equipo = "Argentinos Juniors" });

            return View(listado);
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
