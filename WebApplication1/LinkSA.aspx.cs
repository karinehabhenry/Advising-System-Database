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
    public partial class LinkSA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

            if (!Int32.TryParse(TextBox1.Text, out int StuID))
            {
                Response.Write("Please enter Student ID in form of integer");
                return;
            }

            if (!Int32.TryParse(TextBox2.Text, out int AdvID))
            {
                Response.Write("Please enter Advisor ID in form of integer");
                return;
            }
            


            SqlCommand Procedures_AdminLinkStudentToAdvisor = new SqlCommand("Procedures_AdminLinkStudentToAdvisor", connection);
            Procedures_AdminLinkStudentToAdvisor.CommandType = System.Data.CommandType.StoredProcedure;

            Procedures_AdminLinkStudentToAdvisor.Parameters.Add("@studentID", StuID);
            Procedures_AdminLinkStudentToAdvisor.Parameters.Add("@advisorID", AdvID);

            connection.Open();
             int affected = Procedures_AdminLinkStudentToAdvisor.ExecuteNonQuery();
            connection.Close();

            if (affected > 0)
            {
                Response.Write("Student Linked to Advisor Successfully!");
            }
            else
            {
                Response.Write("Not Linked");
            }

        }
     

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Access.aspx");

        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");

        }
    }
}