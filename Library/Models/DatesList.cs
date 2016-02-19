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
        [Required(ErrorMessage = "*Elegir...")]
        public int? idDays { get; set; }

        public IEnumerable<SelectListItem> Days { get; set; }


        [Required(ErrorMessage = "*Elegir...")]
        public int? idMonths { get; set; }
        public IEnumerable<SelectListItem> Months { get; set; }


        [Required(ErrorMessage = "*Elegir...")]
        public int? idYears { get; set; }
        public IEnumerable<SelectListItem> Years { get; set; }


        public IEnumerable<SelectListItem> FillDays()
        {
            int minDay = 1;
            List<SelectListItem> options = new List<SelectListItem>();

            options.Add(new SelectListItem() { Value = "", Text = "Día...", Selected = true });
            do
            {
                options.Add(new SelectListItem() { Value = minDay.ToString(), Text = minDay.ToString() });
                minDay++;
            } while (minDay <= 31);

            this.Days = options;

            return this.Days;
        }

        public IEnumerable<SelectListItem> FillMonths()
        {
            int minMonth = 1;
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

            options.Add(new SelectListItem() { Value = "", Text = "Mes...", Selected = true });
            do
            {
                options.Add(new SelectListItem() { Value = minMonth.ToString(), Text = names[minMonth].ToString() });
                minMonth++;
            } while (minMonth <= 12);

            this.Months = options;

            return this.Months;
        }

        public IEnumerable<SelectListItem> FillYears()
        {
            int minYear = 1999;
            List<SelectListItem> options = new List<SelectListItem>();

            options.Add(new SelectListItem() { Value = "", Text = "Año...", Selected = true });
            do
            {
                options.Add(new SelectListItem() { Value = minYear.ToString(), Text = minYear.ToString() });
                minYear--;
            } while (minYear >= 1986);

            this.Years = options;

            return this.Years;
        }        
    }
}