using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Capa_Entidades
{
    [MetadataType(typeof(BookMetadata))]
    public partial class Book
    {
        public int Stock { get; set; }
    }


    public class BookMetadata
    {
        [Required(ErrorMessage = "&diams; Debe ingresar un título.")]
        [StringLength(50, ErrorMessage = "&diams; Máximo 50 caracteres.")]
        [RegularExpression("[a-zA-Z0-9 ñ¡!¿?áéíóü]+", ErrorMessage = "&diams; Campo título sólo permite valores alfanuméricos.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "&diams; Debe ingresar un autor.")]
        [StringLength(50, ErrorMessage = "&diams; Máximo 20 caracteres.")]
        [RegularExpression("[a-zA-Z ñáéíóü]+", ErrorMessage = "&diams; Campo autor sólo permite letras.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "&diams; Debe ingresar una descripción.")]
        [StringLength(50, ErrorMessage = "&diams; Máximo 50 caracteres.")]
        [RegularExpression("[a-zA-Z0-9 ñáéíóü]+", ErrorMessage = "&diams; Campo descripción sólo permite valores alfanuméricos.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "&diams; Debe elegir una fecha.")]
        public DateTime PublicationDate { get; set; }

        [Required(ErrorMessage = "&diams; Debe ingresar el nombre completo de la edición.")]
        [StringLength(50, ErrorMessage = "&diams; Máximo 20 caracteres.")]
        [RegularExpression("[a-zA-Z áéíóü]+", ErrorMessage = "&diams; Campo edición sólo permite letras.")]
        public string Edition { get; set; }

        [Required(ErrorMessage = "&diams; Debe ingresar una materia.")]
        [StringLength(50, ErrorMessage = "&diams; Máximo 20 caracteres.")]
        [RegularExpression("[a-zA-Z áéíóü]+", ErrorMessage = "&diams; Campo materia sólo permite letras.")]
        public string Subject { get; set; }
        
    }
}
