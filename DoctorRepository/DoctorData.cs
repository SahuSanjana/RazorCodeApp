using RazorCodeApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RazorCodeApp.DoctorRepository
{
    public class DoctorData
    {
       

        public List<string> GetAllDoctors()
        {
            List<string> drList = new List<string>();
            DoctorsData doctors = new DoctorsData();
            string connection = "Data Source=.;Initial Catalog=ADO;Integrated Security=sspi";
            using(SqlConnection cn = new SqlConnection(connection))
            using (SqlCommand cmd = new SqlCommand("RetrieveDoctorData", cn))
                
            try
            {
                 cn.Open();
                 cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    drList.Add(dr["Doctor_name"].ToString());

                }
                dr.Close();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return drList;
        }
    }
}