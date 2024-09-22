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
    public partial class SendH : System.Web.UI.Page
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


            int userName = (int)Session["user"];

            if (!Int32.TryParse(TextBox2.Text, out int credithours))
            {
                Response.Write("Please enter credit hours in form of integer");
                return;
            }

            string type = TextBox3.Text;
            string comment = TextBox4.Text;
            



            if (sid == userName)
            {

                SqlCommand StuH = new SqlCommand("Procedures_StudentSendingCHRequest", connection);
                StuH.CommandType = System.Data.CommandType.StoredProcedure;
                StuH.Parameters.Add(new SqlParameter("@StudentID", sid));
                StuH.Parameters.Add(new SqlParameter("@credit_hours", credithours));
                StuH.Parameters.Add(new SqlParameter("@type", type));
                StuH.Parameters.Add(new SqlParameter("@comment", comment));



                connection.Open();
                int affected = StuH.ExecuteNonQuery();
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