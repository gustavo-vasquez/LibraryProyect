using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Capa_Entidades
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
        [Required(ErrorMessage = "*Debe resolver el captcha.")]
        public string CaptchaTextbox { get; set; }
    }

    public class StudentMetadata
    {        
        [Required(ErrorMessage = "*Debe elegir un tipo de estudiante.")]
        public string IdCondition { get; set; }
    }
}
