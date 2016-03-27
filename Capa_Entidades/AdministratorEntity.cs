using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Capa_Entidades
{    
    public partial class Administrator
    {
        [Required(ErrorMessage = "&diams; Debe resolver el captcha.")]
        public string CaptchaTextbox { get; set; }
    }    
}
