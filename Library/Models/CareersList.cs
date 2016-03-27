using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

using Capa_Servicios;
using Capa_Entidades;

namespace Library.Models
{
    public class CareersList
    {
        [Required(ErrorMessage = "&diams; Debe elegir una opción.")]        
        public int idCareer { get; set; }
        public IEnumerable<SelectListItem> careers { get; set; }

        public CareersList()
        {
            List<SelectListItem> options = new List<SelectListItem>();
            //options.Add(new SelectListItem() { Value = "", Text = "Elegir carrera universitaria...", Selected = true });
            List<sp_ListingCareers_Result> list = new UserServices().ListOfCareers();

            foreach (var option in list)
            {
                options.Add(new SelectListItem() { Value = option.CareerID.ToString(), Text = option.Name });
            }            
            this.careers = options;
        }
    }
}