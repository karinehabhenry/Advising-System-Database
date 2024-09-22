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
    public partial class Studentlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

     

        protected void Studentloginn(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

            if (!Int32.TryParse(stuser.Text, out int id))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }
            string pass = stpass.Text;

            SqlCommand logins = new SqlCommand("SELECT dbo.FN_StudentLogin(@Student_id, @password)", connection);

            logins.Parameters.Add(new SqlParameter("@Student_id", id));
            logins.Parameters.Add(new SqlParameter("@password", pass));

            connection.Open();
            bool success = (bool)logins.ExecuteScalar();
            connection.Close();
            Response.Write(success);

            if (success)
            {
                Session["user"] = id;
                
                Response.Redirect("student_access.aspx");


            }
            else
                Response.Write("Incorrect password or username ");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void reg(object sender, EventArgs e)
        {
            Response.Redirect("Student_Registration.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("student_access.aspx");
        }
    }
}