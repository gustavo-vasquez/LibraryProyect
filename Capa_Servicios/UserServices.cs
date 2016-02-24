using System;
using System.Collections;
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

        public bool AddStudent(Student data, ref string message)
        {
            ObjectParameter messageParameter = new ObjectParameter("message", typeof(string));          
            ObjectParameter resultParameter = new ObjectParameter("salida", typeof(bool));

            context.sp_RegisterStudent(data.Person.Name,
                                       data.Person.LastName,
                                       data.Person.DNI,
                                       data.Person.BirthDate,
                                       data.Person.Phone,
                                       data.Person.Email,
                                       data.Person.Password,
                                       data.IdCareer,
                                       data.IdCondition,
                                       messageParameter,
                                       resultParameter);

            message = messageParameter.Value.ToString();
            
            return Convert.ToBoolean(resultParameter.Value);
        }
        
    }
}
