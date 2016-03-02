using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Capa_Entidades
{
    public class Login
    {
        [Required(ErrorMessage = "Campo EMAIL vacío.")]
        [StringLength(40, ErrorMessage = "El EMAIL debe tener como máximo 40 caracteres.")]
        [RegularExpression(@"^([A-Z|a-z|0-9](\.|_){0,1})+[A-Z|a-z|0-9]\@([A-Z|a-z|0-9])+((\.){0,1}[A-Z|a-z|0-9]){2}\.[a-z]{2,3}$", ErrorMessage = "*Campo EMAIL no válido.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Campo CONTRASEÑA vacío.")]
        [RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,13}", ErrorMessage = "La CONTRASEÑA debe tener entre 6 y 13 caracteres. Al menos una mayúscula, una minúscula y un número.")]
        public string password { get; set; }
    }
}
