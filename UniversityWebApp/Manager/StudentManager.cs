using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityWebApp.Gateway;
using UniversityWebApp.Models;

namespace UniversityWebApp.Manager
{
    public class StudentManager
    {
        StudentGateway aStudentGateway= new StudentGateway();
        public int Insert(Student student)
        {
            if (!HasStudentRegNo(student.RegNo))
            {
                return aStudentGateway.Insert(student);
            }
            else
            {
                throw new Exception("Student already exsit");
            }
            
        }

        private bool HasStudentRegNo(string regNo)
        {
            return aStudentGateway.HasStudentRegNo(regNo);
        }


        public List<Student> GetAllStudentByDepartment(int deprtId)
        {
            return aStudentGateway.GetAllStudentByDepartment(deprtId);
        }
    }
}