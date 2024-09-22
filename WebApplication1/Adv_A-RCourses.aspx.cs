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
    public partial class Adv_A_RCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("adv_access.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);



            if (!Int32.TryParse(TextBox1.Text, out int RequestID))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }
            string CurrentSemCode = TextBox2.Text;


            SqlCommand ARCH = new SqlCommand("Procedures_AdvisorApproveRejectCourseRequest", connection);
            ARCH.CommandType = System.Data.CommandType.StoredProcedure;



            ARCH.Parameters.Add(new SqlParameter("@requestID", RequestID));
            ARCH.Parameters.Add(new SqlParameter("@current_semester_code", CurrentSemCode));

            connection.Open();

            int affected = ARCH.ExecuteNonQuery();
          
            connection.Close();

            if (affected > 0)
            {
                Response.Write("Done");
            }
            else
            {
                Response.Write("Sorry, cannot be inserted");
            }
        }
    }
}