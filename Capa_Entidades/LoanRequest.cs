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
    
    public partial class LoanRequest
    {
        public int LoanRequestID { get; set; }
        public int Duration { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int IdBook { get; set; }
        public int IdStudent { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Student Student { get; set; }
    }
}
