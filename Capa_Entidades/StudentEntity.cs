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
        public int IdCareer { get; set; }
        
        [Required(ErrorMessage = "*Debe elegir un tipo de estudiante.")]
        public string IdCondition { get; set; }
    }
}
