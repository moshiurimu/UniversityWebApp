using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityWebApp.Gateway;
using UniversityWebApp.Models;

namespace UniversityWebApp.Manager
{
    public class DepertmentManager
    {
        DepertmentGateway aDepertmentGateway= new DepertmentGateway();
        public int Insert(Depertment aDepertment)
        {
            if (!HasDepartmentCode(aDepertment.Code))
            {
                return aDepertmentGateway.Insert(aDepertment);
            }
            else
            {
                throw new Exception("Department code is exsit");
            }
            
        }

        private bool HasDepartmentCode(string code)
        {
            return aDepertmentGateway.HasDepartmentCode(code);
        }
    }
}