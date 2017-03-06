using MVC2Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC2Ado.Net.DataAccessLayer
{
    public class DataAccessLayer
    {
        public string InsertDate(Customer cust)
        {
            SqlConnection con = null;
            string result;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings[""].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Customer", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", cust.CustomerId);
                cmd.Parameters.AddWithValue("@Name", cust.Name);
                cmd.Parameters.AddWithValue("@Address", cust.Address);
                cmd.Parameters.AddWithValue("@MobileNo", cust.MobileNo);
                cmd.Parameters.AddWithValue("@BirthDate", cust.BirthDate);
                cmd.Parameters.AddWithValue("@EmailId", cust.EmailId);
                cmd.Parameters.AddWithValue("@Query", 1);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;

            }
            catch
            {
                return result = "There has been internal error and Data has not been updated";
            }
            finally
            {
                con.Close();
            }
        }

        public string UpdateCustomer(Customer cust)
        {
            SqlConnection con = null;
            string result;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings[""].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Customer", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", cust.CustomerId);
                cmd.Parameters.AddWithValue("@Name", cust.Name);
                cmd.Parameters.AddWithValue("@Address", cust.Address);
                cmd.Parameters.AddWithValue("@MobileNo", cust.MobileNo);
                cmd.Parameters.AddWithValue("@BirthDate", cust.BirthDate);
                cmd.Parameters.AddWithValue("@EmailId", cust.EmailId);
                cmd.Parameters.AddWithValue("@Query", 2);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;

            }
            catch
            {
                return result = "There has been internal error and data not updated";
            }

            finally
            {
                con.Close();
            }
        }

        public string DeleteCustomer(Customer cust)
        {
            SqlConnection con = null;
            string result;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings[""].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Customer", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", cust.CustomerId);
                cmd.Parameters.AddWithValue("@Query", 3);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;

            }
            catch
            {
                return result = "There has been internal error and data not updated";
            }

            finally
            {
                con.Close();
            }

        }


       
        
    }
}