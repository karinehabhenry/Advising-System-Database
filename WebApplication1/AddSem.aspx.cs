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
    public partial class AddSem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

            DateTime startdate = DateTime.Parse(TextBox1.Text);
            DateTime enddate = DateTime.Parse(TextBox2.Text);
            String semestercode = TextBox3.Text;

            SqlCommand AdminAddingSemester = new SqlCommand("AdminAddingSemester", connection);
            AdminAddingSemester.CommandType = System.Data.CommandType.StoredProcedure;

            AdminAddingSemester.Parameters.Add("@start_date", startdate.Date);
            AdminAddingSemester.Parameters.Add("@end_date", enddate.Date);
            AdminAddingSemester.Parameters.Add("@semester_code", semestercode);

            connection.Open();
            int affected = AdminAddingSemester.ExecuteNonQuery();
            connection.Close();

            if (affected > 0)
            {
                Response.Write("Semester Added Successfully!");
            }
            else
            {
                Response.Write("Semester Not Added");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Access.aspx");
        }

      

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");

        }
    }
}