using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Library.Models;
using Capa_Servicios;
using System.Data.SqlClient;

namespace Library.Controllers
{
    public class EmployeeController : Controller
    {
        static EmployeeServices employeeService = new EmployeeServices();

        //
        // GET: /Employee/

        public ActionResult Notifications()
        {
            return PartialView("_Notifications", employeeService.GetNotifications());
        }

        public ActionResult LoanRequests()
        {
            return View(employeeService.GetLoanRequestsList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoanRequests(int requestID)
        {
            try
            {
                var employee = ((List<string>)Session["User"])[3];
                employeeService.ApproveLoan(requestID, employee);
                return View(employeeService.GetLoanRequestsList());
            }
            catch (Exception ex)
            {
                if (ex.InnerException is SqlException)
                {
                    ViewBag.ApproveError = ex.InnerException.Message;
                    employeeService.RejectLoan(requestID, ex.InnerException.Message);
                    return View(employeeService.GetLoanRequestsList());
                }

                return View(employeeService.GetLoanRequestsList());
            }
        }

        public ActionResult LoansGranted()
        {                        
            return View(employeeService.GetLoansHistory());
        }

        [HttpGet]
        public ActionResult MarkAsReturned(int id)
        {
            return PartialView("_MarkAsReturned", id);
        }

        [HttpPost]
        public ActionResult MarkAsReturned(int? id, int mark)
        {
            employeeService.MarkAsReturned(mark);
            return RedirectToAction("LoansGranted", "Employee", employeeService.GetLoansHistory());
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
