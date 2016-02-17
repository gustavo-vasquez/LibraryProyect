using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Capa_Entidades
{
    [MetadataType(typeof(PersonMetadata))]
    public partial class Person
    {
        //public string Document
        //{
        //    get { return DNI.ToString(); }
        //    set { DNI = Convert.ToInt32(value); }
        //}
        [Required]
        public string day { get; set; }

        [Required]
        public string month { get; set; }

        [Required]
        public string year { get; set; }        
    }


    public class PersonMetadata
    {
        [Required(ErrorMessage = "*Debe ingresar un nombre.")]
        [StringLength(50, ErrorMessage = "*Máximo 50 caracteres.")]
        [RegularExpression("[a-zA-Z]+ *[a-zA-Z]{1,}", ErrorMessage = "*Campo nombre sólo permite letras.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Debe ingresar al menos un apellido.")]
        [StringLength(50, ErrorMessage = "*Máximo 50 caracteres.")]
        [RegularExpression("[a-zA-Z]+ *[a-zA-Z]{1,}", ErrorMessage = "*Campo apellido sólo permite letras.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*Debe ingresar un dni.")]
        [StringLength(8, ErrorMessage = "*Máximo 8 números.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "*Campo dni sólo puede contener números.")]
        public int DNI { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegistrationDate { get; set; }

        [Required(ErrorMessage = "*Debe ingresar un número de teléfono.")]
        [StringLength(10, ErrorMessage = "*Máximo 10 números.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "*Campo teléfono sólo puede contener números.")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "*Debe ingresar una dirección de correo electrónico.")]
        [StringLength(40, ErrorMessage = "*Máximo 40 caracteres.")]
        [RegularExpression(@"^([A-Z|a-z|0-9](\.|_){0,1})+[A-Z|a-z|0-9]\@([A-Z|a-z|0-9])+((\.){0,1}[A-Z|a-z|0-9]){2}\.[a-z]{2,3}$", ErrorMessage = "*Campo email no válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Debe ingresar una contraseña.")]
        [RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,13}", ErrorMessage = "*La contraseña debe tener entre 6 y 13 caracteres. Al menos una mayúscula, una minúscula y un número.")]
        public string Password { get; set; }
    }
}
