using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int DeprtId { get; set; }

        public Student(string regNo, string name, string email, int deprtId):this()
        {
            RegNo = regNo;
            Name = name;
            Email = email;
            DeprtId = deprtId;
        }

        public Student()
        {
        }
    }
}