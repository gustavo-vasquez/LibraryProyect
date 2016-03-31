﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class LibraryUniversityEntities : DbContext
    {
        public LibraryUniversityEntities()
            : base("name=LibraryUniversityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Sanction> Sanctions { get; set; }
        public DbSet<StockBook> StockBooks { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Range> Ranges { get; set; }
        public DbSet<LoanRequest> LoanRequests { get; set; }
    
        public virtual int sp_CreateBook(string title, string author, string description, Nullable<System.DateTime> publicationDate, string edition, string subject, Nullable<int> stock)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var authorParameter = author != null ?
                new ObjectParameter("author", author) :
                new ObjectParameter("author", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            var publicationDateParameter = publicationDate.HasValue ?
                new ObjectParameter("publicationDate", publicationDate) :
                new ObjectParameter("publicationDate", typeof(System.DateTime));
    
            var editionParameter = edition != null ?
                new ObjectParameter("edition", edition) :
                new ObjectParameter("edition", typeof(string));
    
            var subjectParameter = subject != null ?
                new ObjectParameter("subject", subject) :
                new ObjectParameter("subject", typeof(string));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("stock", stock) :
                new ObjectParameter("stock", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CreateBook", titleParameter, authorParameter, descriptionParameter, publicationDateParameter, editionParameter, subjectParameter, stockParameter);
        }
    
        public virtual int sp_EditBook(Nullable<int> id, string title, string author, string description, Nullable<System.DateTime> publicationDate, string edition, string subject, Nullable<int> stock)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var authorParameter = author != null ?
                new ObjectParameter("author", author) :
                new ObjectParameter("author", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            var publicationDateParameter = publicationDate.HasValue ?
                new ObjectParameter("publicationDate", publicationDate) :
                new ObjectParameter("publicationDate", typeof(System.DateTime));
    
            var editionParameter = edition != null ?
                new ObjectParameter("edition", edition) :
                new ObjectParameter("edition", typeof(string));
    
            var subjectParameter = subject != null ?
                new ObjectParameter("subject", subject) :
                new ObjectParameter("subject", typeof(string));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("stock", stock) :
                new ObjectParameter("stock", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EditBook", idParameter, titleParameter, authorParameter, descriptionParameter, publicationDateParameter, editionParameter, subjectParameter, stockParameter);
        }
    
        public virtual ObjectResult<sp_GetUserInformation_Result> sp_GetUserInformation(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetUserInformation_Result>("sp_GetUserInformation", emailParameter);
        }
    
        public virtual ObjectResult<sp_ListingCareers_Result> sp_ListingCareers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ListingCareers_Result>("sp_ListingCareers");
        }
    
        public virtual int sp_Login(string email, string password, ObjectParameter message, ObjectParameter allowLogin)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Login", emailParameter, passwordParameter, message, allowLogin);
        }
    
        public virtual int sp_RegisterAdministrator(string name, string lastName, Nullable<int> dni, Nullable<System.DateTime> birthDate, Nullable<int> phone, string email, string emailEncrypted, string password, string politicalGroup, Nullable<decimal> salary, ObjectParameter message, ObjectParameter salida)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var dniParameter = dni.HasValue ?
                new ObjectParameter("dni", dni) :
                new ObjectParameter("dni", typeof(int));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("birthDate", birthDate) :
                new ObjectParameter("birthDate", typeof(System.DateTime));
    
            var phoneParameter = phone.HasValue ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var emailEncryptedParameter = emailEncrypted != null ?
                new ObjectParameter("emailEncrypted", emailEncrypted) :
                new ObjectParameter("emailEncrypted", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var politicalGroupParameter = politicalGroup != null ?
                new ObjectParameter("politicalGroup", politicalGroup) :
                new ObjectParameter("politicalGroup", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_RegisterAdministrator", nameParameter, lastNameParameter, dniParameter, birthDateParameter, phoneParameter, emailParameter, emailEncryptedParameter, passwordParameter, politicalGroupParameter, salaryParameter, message, salida);
        }
    
        public virtual int sp_RegisterEmployee(string name, string lastName, Nullable<int> dni, Nullable<System.DateTime> birthDate, Nullable<int> phone, string email, string emailEncrypted, string password, Nullable<int> antique, Nullable<decimal> salary, ObjectParameter message, ObjectParameter salida)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var dniParameter = dni.HasValue ?
                new ObjectParameter("dni", dni) :
                new ObjectParameter("dni", typeof(int));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("birthDate", birthDate) :
                new ObjectParameter("birthDate", typeof(System.DateTime));
    
            var phoneParameter = phone.HasValue ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var emailEncryptedParameter = emailEncrypted != null ?
                new ObjectParameter("emailEncrypted", emailEncrypted) :
                new ObjectParameter("emailEncrypted", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var antiqueParameter = antique.HasValue ?
                new ObjectParameter("antique", antique) :
                new ObjectParameter("antique", typeof(int));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_RegisterEmployee", nameParameter, lastNameParameter, dniParameter, birthDateParameter, phoneParameter, emailParameter, emailEncryptedParameter, passwordParameter, antiqueParameter, salaryParameter, message, salida);
        }
    
        public virtual int sp_RegisterStudent(string name, string lastName, Nullable<int> dni, Nullable<System.DateTime> birthDate, Nullable<int> phone, string email, string emailEncrypted, string password, Nullable<int> idCareer, string idCondition, ObjectParameter message, ObjectParameter salida)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var dniParameter = dni.HasValue ?
                new ObjectParameter("dni", dni) :
                new ObjectParameter("dni", typeof(int));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("birthDate", birthDate) :
                new ObjectParameter("birthDate", typeof(System.DateTime));
    
            var phoneParameter = phone.HasValue ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var emailEncryptedParameter = emailEncrypted != null ?
                new ObjectParameter("emailEncrypted", emailEncrypted) :
                new ObjectParameter("emailEncrypted", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var idCareerParameter = idCareer.HasValue ?
                new ObjectParameter("idCareer", idCareer) :
                new ObjectParameter("idCareer", typeof(int));
    
            var idConditionParameter = idCondition != null ?
                new ObjectParameter("idCondition", idCondition) :
                new ObjectParameter("idCondition", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_RegisterStudent", nameParameter, lastNameParameter, dniParameter, birthDateParameter, phoneParameter, emailParameter, emailEncryptedParameter, passwordParameter, idCareerParameter, idConditionParameter, message, salida);
        }
    
        public virtual ObjectResult<sp_ShowBooks_Result> sp_ShowBooks()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ShowBooks_Result>("sp_ShowBooks");
        }
    
        public virtual ObjectResult<sp_ShowPersons_Result> sp_ShowPersons(string filter)
        {
            var filterParameter = filter != null ?
                new ObjectParameter("filter", filter) :
                new ObjectParameter("filter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ShowPersons_Result>("sp_ShowPersons", filterParameter);
        }
    
        public virtual ObjectResult<sp_SortBooks_Result> sp_SortBooks(string filter)
        {
            var filterParameter = filter != null ?
                new ObjectParameter("filter", filter) :
                new ObjectParameter("filter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SortBooks_Result>("sp_SortBooks", filterParameter);
        }
    
        public virtual ObjectResult<sp_SearchInBooks_Result> sp_SearchInBooks(string query, string filter)
        {
            var queryParameter = query != null ?
                new ObjectParameter("query", query) :
                new ObjectParameter("query", typeof(string));
    
            var filterParameter = filter != null ?
                new ObjectParameter("filter", filter) :
                new ObjectParameter("filter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SearchInBooks_Result>("sp_SearchInBooks", queryParameter, filterParameter);
        }
    
        public virtual int sp_SendLoanRequest(Nullable<int> idBook, Nullable<int> idStudent)
        {
            var idBookParameter = idBook.HasValue ?
                new ObjectParameter("idBook", idBook) :
                new ObjectParameter("idBook", typeof(int));
    
            var idStudentParameter = idStudent.HasValue ?
                new ObjectParameter("idStudent", idStudent) :
                new ObjectParameter("idStudent", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SendLoanRequest", idBookParameter, idStudentParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_SearchStudentID(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_SearchStudentID", emailParameter);
        }
    
        public virtual ObjectResult<sp_GetRequestsList_Result> sp_GetRequestsList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetRequestsList_Result>("sp_GetRequestsList");
        }
    }
}
