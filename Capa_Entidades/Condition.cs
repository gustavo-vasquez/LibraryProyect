//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Condition
    {
        public Condition()
        {
            this.Students = new HashSet<Student>();
        }
    
        public string ConditionID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Student> Students { get; set; }
    }
}
