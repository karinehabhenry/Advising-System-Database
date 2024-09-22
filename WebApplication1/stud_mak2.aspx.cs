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
    public partial class stud_mak2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {                

            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);
            if (!Int32.TryParse(TextBox1.Text, out int sID))
            {
                Response.Write("Please enter Student ID in form of integer");
                return;
            }
            if (!Int32.TryParse(TextBox2.Text, out int cID))
            {
                Response.Write("Please enter Course ID in form of integer");
                return;
            }
            String sem = (TextBox3.Text);



            SqlCommand mak2 = new SqlCommand("Procedures_StudentRegisterSecondMakeup", connection);
            mak2.CommandType = System.Data.CommandType.StoredProcedure;

            mak2.Parameters.Add("@StudentID", sID);
            mak2.Parameters.Add("@courseID", cID);
            mak2.Parameters.Add("@studentCurr_sem", sem);


            connection.Open();
            int affected = mak2.ExecuteNonQuery();
            connection.Close();


            if (affected > 0)
            {
                Response.Write("Register successfully");
            }
            else
            {
                Response.Write("Didn't Register");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("student_access.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
    }
