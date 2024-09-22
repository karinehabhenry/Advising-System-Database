using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Adv_Insert_Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

            if (!Int32.TryParse(stuId.Text, out int StudentID))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }

            string SemCode = semcode.Text;
            string CourseName = cname.Text;
           

            SqlCommand InsCourse = new SqlCommand("Procedures_AdvisorAddCourseGP", connection);
            InsCourse.CommandType = System.Data.CommandType.StoredProcedure;

            InsCourse.Parameters.Add(new SqlParameter("@student_id", StudentID));
            InsCourse.Parameters.Add(new SqlParameter("@Semester_code", SemCode));
            InsCourse.Parameters.Add(new SqlParameter("course_name", CourseName));

            connection.Open();

            int affected = InsCourse.ExecuteNonQuery();
           
            connection.Close();

            if (affected > 0)
            {
                Response.Write("Added successfully");
            }
            else
            {
                Response.Write("Not Added");
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("adv.access.aspx");
        }
    }
}