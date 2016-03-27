using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Data.Objects;
using System.Security.Cryptography;

using Capa_Entidades;

namespace Capa_Servicios
{
    public class UserServices
    {
        private LibraryUniversityEntities context = new LibraryUniversityEntities();

        public string EncryptSHA256(string textToEncrypt)
        {
            HashAlgorithm hasher = null;
            try
            {
                hasher = new SHA256Managed();
            }
            catch
            {
                hasher = new SHA256CryptoServiceProvider();
            }

            byte[] plainBytes = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
            byte[] hashedBytes = hasher.ComputeHash(plainBytes);
            hasher.Clear();

            return Convert.ToBase64String(hashedBytes);
        }

        public bool LoginAccess(Login data, ref string message)
        {
            ObjectParameter messageParameter = new ObjectParameter("message", typeof(string));
            ObjectParameter allowLogin = new ObjectParameter("allowLogin", typeof(bool));

            try
            {
                context.sp_Login(data.email, data.password, messageParameter, allowLogin);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            message = messageParameter.Value.ToString();

            return Convert.ToBoolean(allowLogin.Value);
        }

        public List<string> SetSessionInformation(string email)
        {
            List<sp_GetUserInformation_Result> result = context.sp_GetUserInformation(email).ToList();
            int idRangeUser = result[0].IdRange;
            var rangeTable = context.Ranges.Where(r => r.RangeID.Equals(idRangeUser)).FirstOrDefault();

            List<string> information = new List<string>();
            information.Add(rangeTable.Detail);
            information.Add(result[0].Name);
            information.Add(result[0].LastName);
            information.Add(result[0].Email);
            information.Add(result[0].Password);            
            
            return information;
        }        

        public List<string> RestoreCookiesData(string cookieSaved)
        {
            Person PersonObject = context.People.FirstOrDefault(p => p.EmailSHA256 == cookieSaved);
            var rangeTable = context.Ranges.Where(r => r.RangeID.Equals(PersonObject.IdRange)).FirstOrDefault();

            List<string> cookieData = new List<string>();
            cookieData.Add(rangeTable.Detail);
            cookieData.Add(PersonObject.Name);
            cookieData.Add(PersonObject.LastName);
            cookieData.Add(PersonObject.Email);
            cookieData.Add(PersonObject.Password);
            
            return cookieData;
        }


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
                                       this.EncryptSHA256(data.Person.Email),
                                       data.Person.Password,
                                       data.IdCareer,
                                       data.IdCondition,
                                       messageParameter,
                                       resultParameter);

            message = messageParameter.Value.ToString();
            
            return Convert.ToBoolean(resultParameter.Value);
        }

        public bool AddEmployee(Employee data, ref string message)
        {
            ObjectParameter messageParameter = new ObjectParameter("message", typeof(string));
            ObjectParameter resultParameter = new ObjectParameter("salida", typeof(bool));

            context.sp_RegisterEmployee(
                    data.Person.Name,
                    data.Person.LastName,
                    data.Person.DNI,
                    data.Person.BirthDate,
                    data.Person.Phone,
                    data.Person.Email,
                    this.EncryptSHA256(data.Person.Email),
                    data.Person.Password,
                    data.Antique,
                    data.Salary,
                    messageParameter,
                    resultParameter
                );

            message = messageParameter.Value.ToString();

            return Convert.ToBoolean(resultParameter.Value);
        }

        public bool AddAdministrator(Administrator data, ref string message)
        {
            ObjectParameter messageParameter = new ObjectParameter("message", typeof(string));
            ObjectParameter resultParameter = new ObjectParameter("salida", typeof(bool));            

            context.sp_RegisterAdministrator(
                    data.Person.Name,
                    data.Person.LastName,
                    data.Person.DNI,
                    data.Person.BirthDate,
                    data.Person.Phone,
                    data.Person.Email,
                    this.EncryptSHA256(data.Person.Email),
                    data.Person.Password,
                    data.PoliticalGroup,
                    data.Salary,
                    messageParameter,
                    resultParameter
                );

            message = messageParameter.Value.ToString();

            return Convert.ToBoolean(resultParameter.Value);
        }
        
    }
}
