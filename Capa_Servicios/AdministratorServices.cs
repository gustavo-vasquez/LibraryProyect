using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

using Capa_Entidades;

namespace Capa_Servicios
{
    public class AdministratorServices
    {
        private LibraryUniversityEntities context = new LibraryUniversityEntities();

        public void RefreshContext()
        {
            foreach (var entity in context.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }

        public void CreateNewBook(Book data)
        {
            try
            {
                context.sp_CreateBook(data.Title, data.Author, data.Description, data.PublicationDate, data.Edition, data.Subject, data.Stock);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<sp_ShowBooks_Result> GetBooksList()
        {
            return context.sp_ShowBooks().ToList();
        }

        public Book SearchBook(int id)
        {            
            RefreshContext();
            var book = context.Books.FirstOrDefault(b => b.BookID == id);
            book.Stock = context.StockBooks.FirstOrDefault(b => b.IdBook == id).Stock;            

            return book;
        }

        public void EditStockData(int id, int stockToAssign, string choosedRadio)
        {
            var book = context.StockBooks.FirstOrDefault(sb => sb.IdBook == id);
            book.Stock = IncreaseOrDecrease(book.Stock, stockToAssign, choosedRadio);
            context.SaveChanges();            
        }

        public void EditBookData(int id, Book data, int stockToAssign, string choosedRadio)
        {
            try
            {
                data.Stock = IncreaseOrDecrease(data.Stock, stockToAssign, choosedRadio);
                context.sp_EditBook(id, data.Title, data.Author, data.Description, data.PublicationDate, data.Edition, data.Subject, data.Stock);                
                context.SaveChanges();                
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        private int IncreaseOrDecrease(int currentStock, int stockToAssign, string choosedRadio)
        {
            switch (choosedRadio)
            {
                case "+":
                    currentStock += stockToAssign;
                    break;

                case "-":
                    currentStock -= stockToAssign;
                    break;

                default:
                    currentStock += 0;
                    break;
            }

            return currentStock;
        }
    }
}
