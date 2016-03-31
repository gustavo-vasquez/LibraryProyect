using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_Servicios
{
    public class EmployeeServices
    {
        private LibraryUniversityEntities context = new LibraryUniversityEntities();

        public int GetNotifications()
        {
            var requests = context.LoanRequests.ToList().Count();

            return requests;
        }

        public List<sp_GetRequestsList_Result> GetLoanRequestsList()
        {
            var requestsList = context.sp_GetRequestsList().ToList();

            return requestsList;
        }
    }
}
