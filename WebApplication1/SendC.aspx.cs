using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class SendC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

            if (!Int32.TryParse(TextBox1.Text, out int cid))
            {
                Response.Write("Please enter Course ID in form of integer");
                return;
            }
            if (!Int32.TryParse(TextBox2.Text, out int sid))
            {
                Response.Write("Please enter Student ID in form of integer");
                return;
            }

          
            string type = TextBox3.Text;
            string comment = TextBox4.Text;

            int userName = (int)Session["user"];
            if (sid == userName)
            {
                SqlCommand StuC = new SqlCommand("Procedures_StudentSendingCourseRequest", connection);
                StuC.CommandType = System.Data.CommandType.StoredProcedure;
                StuC.Parameters.Add(new SqlParameter("@courseID", cid));
                StuC.Parameters.Add(new SqlParameter("@StudentID", sid));
                StuC.Parameters.Add(new SqlParameter("@type", type));
                StuC.Parameters.Add(new SqlParameter("@comment", comment));



                connection.Open();
                int affected =StuC.ExecuteNonQuery();
                connection.Close();

                if (affected > 0)
                {
                    Response.Write("Sent Successfully!");
                }
                else
                {
                    Response.Write(" Not Sent");
                }
            }
            else
                Response.Write("Enter Your ID");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("student_access.aspx");
        }
    }
}