using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_Servicios
{
    public class StudentServices
    {
        private LibraryUniversityEntities context = new LibraryUniversityEntities();

        public bool CheckSanctionOfStudent(string email)
        {
            var person = context.People.FirstOrDefault(p => p.Email == email);
            var student = context.Students.FirstOrDefault(s => s.IdPerson == person.PersonID);

            return student.Sanctioned;
        }

        public List<sp_SearchInBooks_Result> SearchQuery(string query, string filter)
        {
            var result = context.sp_SearchInBooks(query, filter).ToList();

            return result;
        }

        public Book BookInformation(int id)
        {
            var book = context.Books.FirstOrDefault(b => b.BookID == id);
            return book;
        }

        public void SendLoanRequest(string email, int idBook)
        {
            try
            {
                var user = context.People.FirstOrDefault(u => u.Email == email);
                var student = context.Students.FirstOrDefault(s => s.IdPerson == user.PersonID);
                context.sp_SendLoanRequest(idBook, student.StudentID);
            }
            catch(Exception ex)
            {
                throw ex;
            }            
        }

        public List<sp_LoansForStudent_Result> GetLoansForStudent()
        {
            return context.sp_LoansForStudent().ToList();
        }
    }
}
