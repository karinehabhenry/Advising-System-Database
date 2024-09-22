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
    public partial class LinkICS : System.Web.UI.Page
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
                Response.Write("Please enter course ID in form of integer");
                return;
            }
            if (!Int32.TryParse(TextBox2.Text, out int InstructorID))
            {
                Response.Write("Please enter instructor ID in form of integer");
                return;
            }
            if (!Int32.TryParse(TextBox3.Text, out int SlotID))
            {
                Response.Write("Please enter the slot in form of integer");
                return;
            }
        


            SqlCommand Procedures_AdminLinkInstructor = new SqlCommand("Procedures_AdminLinkInstructor", connection);
            Procedures_AdminLinkInstructor.CommandType = System.Data.CommandType.StoredProcedure;

            Procedures_AdminLinkInstructor.Parameters.Add("@cours_id", CourseID);
            Procedures_AdminLinkInstructor.Parameters.Add("@instructor_id", InstructorID);
            Procedures_AdminLinkInstructor.Parameters.Add("@slot_id", SlotID);

            connection.Open();
             int affected =Procedures_AdminLinkInstructor.ExecuteNonQuery();
            connection.Close();

             if (affected > 0)
            {
                Response.Write("Instructor Linked To Course Successfully!");
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