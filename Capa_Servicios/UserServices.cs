using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Data.Objects;

using Capa_Entidades;

namespace Capa_Servicios
{
    public class UserServices
    {
        private LibraryUniversityEntities context = new LibraryUniversityEntities();

        public List<sp_ShowPersons_Result> ListOfPersons(string filter)
        {            
            List<sp_ShowPersons_Result> resultado = context.sp_ShowPersons(filter).ToList();
            return resultado;
        }

        public List<sp_ListingCareers_Result> ListOfCareers()
        {
            return context.sp_ListingCareers().ToList();
        }        
        
    }
}
