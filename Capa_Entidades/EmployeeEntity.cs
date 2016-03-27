using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Capa_Entidades
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
        [Required(ErrorMessage = "&diams; Debe resolver el captcha.")]
        public string CaptchaTextbox { get; set; }
    }

    public class EmployeeMetadata
    {
        [RegularExpression(@"^\d{1,2}$", ErrorMessage = "&diams; Campo antigüedad no válido.")]
        public int Antique { get; set; }
    }
}
