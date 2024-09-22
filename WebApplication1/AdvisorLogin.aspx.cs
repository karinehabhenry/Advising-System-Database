using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdvisorLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

           
            if (!Int32.TryParse(AdvID.Text, out int id))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }
            string pass = AdvPass.Text;

            SqlCommand loginAdv = new SqlCommand("SELECT dbo.FN_AdvisorLogin(@advisor_Id, @password)", connection);

            loginAdv.Parameters.Add(new SqlParameter("@advisor_Id", id));
            loginAdv.Parameters.Add(new SqlParameter("@password", pass));

            connection.Open();
            bool success = (bool)loginAdv.ExecuteScalar();
            connection.Close();

            if (success)
            {
                Session["user2"] = id;
                Response.Redirect("adv_access.aspx");
            }
            else
                Response.Write("Incorrect ID or Password");


        }


        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void reg(object sender, EventArgs e)
        {

            Response.Redirect("AdvReg.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }


    }

  
}