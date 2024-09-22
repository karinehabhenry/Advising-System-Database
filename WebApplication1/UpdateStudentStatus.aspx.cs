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
    public partial class UpdateStudentStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);


            if (!Int32.TryParse(TextBox1.Text, out int sid))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }


            SqlCommand Procedure_AdminUpdateStudentStatus = new SqlCommand("Procedure_AdminUpdateStudentStatus", connection);

            Procedure_AdminUpdateStudentStatus.CommandType = System.Data.CommandType.StoredProcedure;
            Procedure_AdminUpdateStudentStatus.Parameters.Add(new SqlParameter("@student_id", sid));
            connection.Open();
            int affected = Procedure_AdminUpdateStudentStatus.ExecuteNonQuery();
            connection.Close();

            if (affected > 0)
            {
                Response.Write("Update student status successfully!");
            }
            else
            {
                Response.Write(" Not Updated");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Access.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}