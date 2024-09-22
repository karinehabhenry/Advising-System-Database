using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LinkCI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

            if (!Int32.TryParse(TextBox1.Text, out int CourseID))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }
            if (!Int32.TryParse(TextBox2.Text, out int InstructorID))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }
            if (!Int32.TryParse(TextBox3.Text, out int StuID))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }
          
            String SemCode = TextBox4.Text;


            SqlCommand Procedures_AdminLinkStudent = new SqlCommand("Procedures_AdminLinkStudent", connection);
            Procedures_AdminLinkStudent.CommandType = System.Data.CommandType.StoredProcedure;

            Procedures_AdminLinkStudent.Parameters.Add("@cours_id", CourseID);
            Procedures_AdminLinkStudent.Parameters.Add("@instructor_id", InstructorID);
            Procedures_AdminLinkStudent.Parameters.Add("@studentID", StuID);
            Procedures_AdminLinkStudent.Parameters.Add("@semester_code", SemCode);

            connection.Open();
             int affected =Procedures_AdminLinkStudent.ExecuteNonQuery();
            connection.Close();

            if (affected > 0)
            {
                Response.Write("Student Linked to Course with specific Instructor Successfully!");
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