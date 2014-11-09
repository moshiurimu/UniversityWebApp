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
            Connection.Open();
            string query = "INSERT INTO t_Depertment VALUES(@code,@name)";
            Command.CommandText = query;
            Command.Parameters.AddWithValue("@code", aDepertment.Code);
            Command.Parameters.AddWithValue("@name",aDepertment.Name);
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public bool HasDepartmentCode(string code)
        {
            Connection.Open();
            string query = "SELECT * FROM t_Depertment WHERE Code= '" + code + "'";
            Command.CommandText = query;
            SqlDataReader aDataReader = Command.ExecuteReader();
            bool hasRow = aDataReader.HasRows;
            Connection.Close();
            return hasRow;

        }
    }
}