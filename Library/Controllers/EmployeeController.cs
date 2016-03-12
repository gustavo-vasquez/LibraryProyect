using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Library.Models;

namespace Library.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult LoansGranted()
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

        public ActionResult AppliedSanctions()
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

    }
}
