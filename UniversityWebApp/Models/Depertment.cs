using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityWebApp.Models
{
    public class Depertment
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public Depertment(string code, string name):this()
        {
            Code = code;
            Name = name;
        }

        public Depertment()
        {
        }
    }
}