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
    public partial class stud_choosei : System.Web.UI.Page
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
                Response.Write("Please enter Student ID in form of integer");
                return;
            }

            if (!Int32.TryParse(TextBox2.Text, out int iid))
            {
                Response.Write("Please enter Instructor ID in form of integer");
                return;
            }
            if (!Int32.TryParse(TextBox3.Text, out int cid))
            {
                Response.Write("Please enter Course ID in form of integer");
                return;
            }

           
            string semestercode = TextBox4.Text;



            SqlCommand cccc = new SqlCommand("Procedures_Chooseinstructor", connection);
            cccc.CommandType = System.Data.CommandType.StoredProcedure;

            cccc.Parameters.Add("@StudentID", sid);
            cccc.Parameters.Add("@instrucorID", iid);
            cccc.Parameters.Add("@CourseID", cid);
            cccc.Parameters.Add("@current_semester_code", semestercode);



            connection.Open();
             int affected = cccc.ExecuteNonQuery();
            connection.Close();

            if (affected > 0)
            {
                Response.Write("Chosen Successfully!");
            }
            else
            {
                Response.Write("Not Chosen");
            }
        }
       

     

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("student_access.aspx");
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");

        }
    }
}