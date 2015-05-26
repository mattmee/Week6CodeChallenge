using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Week6CodeChallenge.Models
{
    public class ContentDataAccess
    {   
        public static bool InsertContact(Contact contact)
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                con.Open(); //opens connection to database
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Contacts(FirstName, LastName, Email, PhoneNumber, CompanyName, ProductDesc, Comment) Values (@firstName, @lastName, @email, @phoneNumber, @companyName, @productDesc, @comment)", con);
                    //using parameters avoids SQL injections
                    command.Parameters.Add(new SqlParameter("firstName", contact.FirstName));
                    command.Parameters.Add(new SqlParameter("lastName", contact.LastName));
                    command.Parameters.Add(new SqlParameter("email", contact.Email));
                    command.Parameters.Add(new SqlParameter("phoneNumber", contact.PhoneNum));
                    command.Parameters.Add(new SqlParameter("companyName", contact.CompanyName));
                    command.Parameters.Add(new SqlParameter("projectDesc", contact.ProductDesc));
                    command.Parameters.Add(new SqlParameter("comment", contact.Comment));
                    //execute query
                    command.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}