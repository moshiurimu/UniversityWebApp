using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using UniversityWebApp.Models;

namespace UniversityWebApp.Gateway
{
    public class DepertmentGateway:Gateway
    {
        public int Insert(Depertment aDepertment)
        {
            
            string query = "INSERT INTO t_Depertment VALUES(@code,@name)";
            Command.CommandText = query;
            Command.Parameters.AddWithValue("@code", aDepertment.Code);
            Command.Parameters.AddWithValue("@name",aDepertment.Name);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public bool HasDepartmentCode(string code)
        {
            
            string query = "SELECT * FROM t_Depertment WHERE Code= '" + code + "'";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader aDataReader = Command.ExecuteReader();
            bool hasRow = aDataReader.HasRows;
            Connection.Close();
            return hasRow;

        }

        public List<Depertment> GetAllDepartment()
        {
            List<Depertment> depertments= new List<Depertment>();
            string query = "SELECT * FROM t_Depertment";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader aDataReader = Command.ExecuteReader();
            while (aDataReader.Read())
            {
                Depertment depertment= new Depertment();
                depertment.Id = (int) aDataReader[0];
                depertment.Code = aDataReader[1].ToString();
                depertment.Name = aDataReader[2].ToString();
                depertments.Add(depertment);
            }
            aDataReader.Close();
            Connection.Close();
            return depertments;
        }
    }
}