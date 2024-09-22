using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (!Int32.TryParse(AdmID.Text, out int ID))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }
            String password = AdmPass.Text;
            if(ID==1 && password == "admin")
            {
                Response.Redirect("Admin_Access.aspx");
            }
            else
            {
                Response.Write("Login Failed , Incorrect ID or Password");
            }

        }

    }
}