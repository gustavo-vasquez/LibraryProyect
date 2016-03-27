using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Capa_Entidades
{
    [MetadataType(typeof(PersonMetadata))]
    public partial class Person
    {

    }


    public class PersonMetadata
    {
        [Required(ErrorMessage = "&diams; Debe ingresar un nombre.")]
        [StringLength(50, ErrorMessage = "&diams; Máximo 50 caracteres.")]
        [RegularExpression("[a-zA-Z]+ *[a-zA-Z]{1,}", ErrorMessage = "&diams; Campo nombre sólo permite letras.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "&diams; Debe ingresar al menos un apellido.")]
        [StringLength(50, ErrorMessage = "&diams; Máximo 50 caracteres.")]
        [RegularExpression("[a-zA-Z]+ *[a-zA-Z]{1,}", ErrorMessage = "&diams; Campo apellido sólo permite letras.")]
        public string LastName { get; set; }

        // StringLength es una mierda para los int
        [Required(ErrorMessage = "&diams; Debe ingresar un dni.")]
        [RegularExpression(@"^\d{1,8}$", ErrorMessage = "&diams; Campo dni sólo puede contener como máximo 8 números.")]
        public int DNI { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegistrationDate { get; set; }

        [Required(ErrorMessage = "&diams; Debe ingresar un número de teléfono.")]
        [RegularExpression(@"^\d{1,10}$", ErrorMessage = "&diams; Campo teléfono sólo puede contener como máximo 10 números.")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "&diams; Debe ingresar una dirección de correo electrónico.")]
        [StringLength(40, ErrorMessage = "&diams; Máximo 40 caracteres.")]
        [RegularExpression(@"^([A-Z|a-z|0-9](\.|_){0,1})+[A-Z|a-z|0-9]\@([A-Z|a-z|0-9])+((\.){0,1}[A-Z|a-z|0-9]){2}\.[a-z]{2,3}$", ErrorMessage = "&diams; Campo email no válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "&diams; Debe ingresar una contraseña.")]
        [RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,13}", ErrorMessage = "&diams; La contraseña debe tener entre 6 y 13 caracteres. Al menos una mayúscula, una minúscula y un número.")]
        public string Password { get; set; }
    }
}
