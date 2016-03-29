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
    }
}
