using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Models
{
    public class PoliticalList
    {
        [Required(ErrorMessage = "&diams; Debe elegir una opción.")]
        public string nameGroup { get; set; }
        public IEnumerable<SelectListItem> groups { get; set; }

        public PoliticalList()
        {
            List<SelectListItem> options = new List<SelectListItem>();
            options.Add(new SelectListItem() { Value = "", Text = "Ver grupos políticos...", Selected = true });
            options.Add(new SelectListItem() { Value = "Liga federal", Text = "Liga federal" });
            options.Add(new SelectListItem() { Value = "Megacity", Text = "Megacity" });
            options.Add(new SelectListItem() { Value = "Ley de la selva", Text = "Ley de la selva" });

            this.groups = options;
        }
    }
}