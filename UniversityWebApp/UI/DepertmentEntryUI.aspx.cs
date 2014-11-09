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
    public partial class DepertmentEntryUI : System.Web.UI.Page
    {
        DepertmentManager aDepertmentManager= new DepertmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string code = Request.Form["code"].ToString();
            string name = Request.Form["name"].ToString();

            try
            {
                Depertment aDepertment= new Depertment(code,name);
                int IsSave = aDepertmentManager.Insert(aDepertment);

                if (IsSave>0)
                {
                    Label1.Text = "Depertment has been saved";
                }
                else
                {
                    Label1.Text = "Depertment not saved";
                }
            }
            catch (Exception exception)
            {

                Label1.Text = exception.Message;
            }
            
        }
    }
}