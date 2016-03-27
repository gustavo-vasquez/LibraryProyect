using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Models
{
    public class DatesList
    {
        [Required(ErrorMessage = "&diams; Elegir...")]
        public int? idDays { get; set; }

        public IEnumerable<SelectListItem> Days { get; set; }


        [Required(ErrorMessage = "&diams; Elegir...")]
        public int? idMonths { get; set; }
        public IEnumerable<SelectListItem> Months { get; set; }


        [Required(ErrorMessage = "&diams; Elegir...")]
        public int? idYears { get; set; }
        public IEnumerable<SelectListItem> Years { get; set; }


        public IEnumerable<SelectListItem> FillDays()
        {
            int i;
            List<SelectListItem> options = new List<SelectListItem>();

            //options.Add(new SelectListItem() { Value = "", Text = "Día...", Selected = true });

            for (i = 1; i <= 31; i++)
            {
                options.Add(new SelectListItem() { Value = i.ToString(), Text = i.ToString() });
            }                

            this.Days = options;

            return this.Days;
        }

        public IEnumerable<SelectListItem> FillMonths()
        {
            int i;
            Hashtable names = new Hashtable();            
            names.Add(1, "Enero");
            names.Add(2, "Febrero");
            names.Add(3, "Marzo");
            names.Add(4, "Abril");
            names.Add(5, "Mayo");
            names.Add(6, "Junio");
            names.Add(7, "Julio");
            names.Add(8, "Agosto");
            names.Add(9, "Septiembre");
            names.Add(10, "Octubre");
            names.Add(11, "Noviembre");
            names.Add(12, "Diciembre");            

            List<SelectListItem> options = new List<SelectListItem>();

            //options.Add(new SelectListItem() { Value = "", Text = "Mes...", Selected = true });

            for (i = 1; i <= 12; i++)
            {
                options.Add(new SelectListItem() { Value = i.ToString(), Text = names[i].ToString() });
            }                

            this.Months = options;

            return this.Months;
        }

        public IEnumerable<SelectListItem> FillYears()
        {
            int i;
            List<SelectListItem> options = new List<SelectListItem>();

            //options.Add(new SelectListItem() { Value = "", Text = "Año...", Selected = true });

            for (i = 1999; i >= 1986; i--)
            {
                options.Add(new SelectListItem() { Value = i.ToString(), Text = i.ToString() });
            }                

            this.Years = options;

            return this.Years;
        }        
    }
}