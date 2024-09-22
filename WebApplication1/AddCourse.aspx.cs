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
    public partial class AddCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

           
        


            String Major = TextBox1.Text;
            if (!Int32.TryParse(TextBox2.Text, out int Semester))
            {
                Response.Write("Please enter the semester in form of integer");
                return;
            }

            if (!Int32.TryParse(TextBox3.Text, out int CreditHours))
            {
                Response.Write("Please enter Credit hours in form of integer");
                return;
            }
            String Name = TextBox4.Text;
            String isOffered = TextBox5.Text;


            SqlCommand Procedures_AdminAddingCourse = new SqlCommand("Procedures_AdminAddingCourse", connection);
            Procedures_AdminAddingCourse.CommandType = System.Data.CommandType.StoredProcedure;

            Procedures_AdminAddingCourse.Parameters.Add("@major", Major);
            Procedures_AdminAddingCourse.Parameters.Add("@semester", Semester);
            Procedures_AdminAddingCourse.Parameters.Add("@credit_hours", CreditHours);
            Procedures_AdminAddingCourse.Parameters.Add("@name", Name);
            Procedures_AdminAddingCourse.Parameters.Add("@is_offered", isOffered);

            connection.Open();
            int affected= Procedures_AdminAddingCourse.ExecuteNonQuery();
            connection.Close();

            
            if (affected > 0)
            {
                Response.Write("Course Added Successfully!");
            }
            else
            {
                Response.Write("Course Not Added");
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