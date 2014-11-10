using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityWebApp.Manager;
using UniversityWebApp.Models;

namespace UniversityWebApp.UI
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        
        DepertmentManager aDepertmentManager= new DepertmentManager();
        StudentManager aStudentManager= new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Depertment> depertments = aDepertmentManager.GetAllDepartment();
                departmentDropDownList.DataSource = depertments;
                departmentDropDownList.DataTextField = "Code";
                departmentDropDownList.DataValueField = "Id";
                departmentDropDownList.DataBind();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string regNo = Request.Form["regNo"].ToString();
            string name = Request.Form["name"].ToString();
            string email=Request.Form["email"].ToString();
            int deprtId = Convert.ToInt32(departmentDropDownList.SelectedValue);

            try
            {
                Student student = new Student(regNo, name, email, deprtId);
                int IsSave = aStudentManager.Insert(student);

                if (IsSave>0)
                {
                    Label1.Text = "Student has been saved";
                }
                else
                {
                    Label1.Text = "Student can't save";
                }
            }
            catch (Exception exception)
            {

                Label1.Text = exception.Message;
            }
            
        }
    }
}