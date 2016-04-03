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

        public void ApproveLoan(int idLoanRequest, string email)
        {
            try
            {
                var user = context.People.FirstOrDefault(u => u.Email == email);
                var employee = context.Employees.FirstOrDefault(e => e.IdPerson == user.PersonID);
                context.sp_ApproveLoan(idLoanRequest, employee.EmployeeID);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void RejectLoan(int requestID, string errorMessage)
        {
            if(errorMessage.Contains("no está disponible"))
            {
                var loanRejected = context.LoanRequests.FirstOrDefault(lr => lr.LoanRequestID == requestID);
                context.LoanRequests.Remove(loanRejected);
                context.SaveChanges();
            }
        }

        public List<sp_GetLoansHistory_Result> GetLoansHistory()
        {
            return context.sp_GetLoansHistory().ToList();
        }

        public void MarkAsReturned(int loanID)
        {
            context.sp_MarkBook(loanID);
        }
    }
}
