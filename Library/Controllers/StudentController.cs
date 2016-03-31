using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Library.Models;
using Capa_Servicios;
using System.Data.SqlClient;
using Capa_Entidades;

namespace Library.Controllers
{
    public class StudentController : Controller
    {
        static StudentServices studentService = new StudentServices();

        //
        // GET: /Student/

        public ActionResult MyProfile()
        {
            return View();
        }
                
        public ActionResult ViewResults(string q, string cat)
        {
            if (Session["User"] != null)
            {
                string range = ((List<string>)Session["User"])[0];
                if (range != "Student")
                {
                    Response.StatusCode = 403;
                    return null;
                }
            }

            switch (cat)
            {
                case "T":
                    return View(studentService.SearchQuery(q, cat));
                case "A":
                    return View(studentService.SearchQuery(q, cat));             
            }

            return View();
        }

        public ActionResult Transaction(int id)
        {
            return View(studentService.BookInformation(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Transaction(Book data)
        {
            try
            {
                string idStudent = ((List<string>)Session["User"])[3];
                studentService.SendLoanRequest(idStudent, data.BookID);
                TempData["Solicitude"] = true;
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                if(ex.InnerException is SqlException)
                {
                    ViewBag.BookRequestError = ex.InnerException.Message;
                    return View("Transaction", data);
                }

                return View("Transaction", data);
            }                        
        }

        public ActionResult Loans()
        {
            List<GridTest> listado = new List<GridTest>();

            listado.Add(new GridTest() { posicion = 1, equipo = "River Plate" });
            listado.Add(new GridTest() { posicion = 2, equipo = "San Lorenzo"});
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

        public ActionResult Sanctions()
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
