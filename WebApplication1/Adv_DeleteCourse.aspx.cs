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
    public partial class Adv_DeleteCourse2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);




            if (!Int32.TryParse(TextBox1.Text, out int StudentID))
            {
                Response.Write("Please enter Student ID in form of integer");
                return;
            }

            string SemCode = TextBox2.Text;

            if (!Int32.TryParse(TextBox3.Text, out int CourseID))
            {
                Response.Write("Please enter  Course ID in form of integer");
                return;
            }




            SqlCommand DelCourse = new SqlCommand("Procedures_AdvisorDeleteFromGP", connection);
            DelCourse.CommandType = System.Data.CommandType.StoredProcedure;



            DelCourse.Parameters.Add(new SqlParameter("@studentID", StudentID));
            DelCourse.Parameters.Add(new SqlParameter("@sem_code", SemCode));
            DelCourse.Parameters.Add(new SqlParameter("@courseID", CourseID));

            connection.Open();

            int affected = DelCourse.ExecuteNonQuery();

            connection.Close();

            if (affected > 0)
            {
                Response.Write("Course deleted successfully");
            }
            else
            {
                Response.Write("Not deleted");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("adv.access.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}