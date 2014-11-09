using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityWebApp.UI
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string regNo = Request.Form["regNo"].ToString();
            string name = Request.Form["name"].ToString();
            string email=Request.Form["email"].ToString();
            int deprtId = Convert.ToInt32(Request.Form["deprtId"]);


        }
    }
}