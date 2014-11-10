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
    public partial class Views : System.Web.UI.Page
    {
        private DepertmentManager aDepertmentManager = new DepertmentManager();
        private StudentManager aStudentManager = new StudentManager();

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

            int deprtId = Convert.ToInt32(departmentDropDownList.SelectedValue);
            List<Student> students = aStudentManager.GetAllStudentByDepartment(deprtId);
            studentDropDownList.DataSource = students;
            studentDropDownList.DataTextField = "RegNo";
            studentDropDownList.DataValueField = "Id";
            studentDropDownList.DataBind();
        }

        protected void departmentDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deprtId = Convert.ToInt32(departmentDropDownList.SelectedValue);
            List<Student> students = aStudentManager.GetAllStudentByDepartment(deprtId);
            studentDropDownList.DataSource = students;
            studentDropDownList.DataTextField = "RegNo";
            studentDropDownList.DataValueField = "Id";
            studentDropDownList.DataBind();
        }

        protected void studentDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            Student student = new Student();
            student = (Student)studentDropDownList.DataSourceObject;
            Label1.Text = "" + studentDropDownList.SelectedItem.Value[Convert.ToInt32(student.Name)]+ "";


        }
    }
}