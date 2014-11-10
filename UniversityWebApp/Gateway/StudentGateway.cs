using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniversityWebApp.Models;

namespace UniversityWebApp.Gateway
{
    public class StudentGateway:Gateway
    {
        public int Insert(Student student)
        {
            string query = "INSERT INTO t_Student VALUES(@regNo,@name,@email,@deprtId)";
            Command.CommandText = query;
            Command.Parameters.AddWithValue("@regNo",student.RegNo);
            Command.Parameters.AddWithValue("@name ", student.Name);
            Command.Parameters.AddWithValue("@email", student.Email);
            Command.Parameters.AddWithValue("@deprtId", student.DeprtId);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public bool HasStudentRegNo(string regNo)
        {
            string query = "SELECT * FROM t_Student WHERE RegNo='"+regNo+"'";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader aDataReader = Command.ExecuteReader();
            bool hasRow = aDataReader.HasRows;
            Connection.Close();
            return hasRow;
        }


        public List<Student> GetAllStudentByDepartment(int deprtId)
        {
            List<Student> students= new List<Student>();
            string query = "SELECT * FROM t_Student WHERE DeprtId='" + deprtId + "'";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader aDataReader = Command.ExecuteReader();
            while (aDataReader.Read())
            {
                Student student= new Student();
                student.Id = (int) aDataReader[0];
                student.RegNo= aDataReader[1].ToString();
                student.Name= aDataReader[2].ToString();
                student.Email=aDataReader[3].ToString();
                student.DeprtId= (int) aDataReader[4];
                students.Add(student);
            }
            aDataReader.Close();
            Connection.Close();
            return students;

        }
    }
}