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
        
    }

    public class StudentMetadata
    {
        [Required(ErrorMessage = "*Debe elegir una carrera.")]
        public int IdCareer { get; set; }

        [Required(ErrorMessage = "*Debe elegir un tipo de estudiante.")]
        public int IdCondition { get; set; }
    }
}
