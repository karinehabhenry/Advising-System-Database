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
    public partial class Insert_Grad_Plan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

            string SemCode = TextBox1.Text;
            DateTime ExpGradDate =  DateTime.Parse(TextBox2.Text);

            if (!Int32.TryParse(TextBox1.Text, out int SemCredH))
            {
                Response.Write("Please enter Semester credit hours in form of integer");
                return;
            }

            if (!Int32.TryParse(TextBox2.Text, out int AdvID))
            {
                Response.Write("Please enter Advisor ID in form of integer");
                return;
            }

            if (!Int32.TryParse(TextBox3.Text, out int StuID))
            {
                Response.Write("Please enter Student ID in form of integer");
                return;
            }
           

            SqlCommand gradplan = new SqlCommand("Procedures_AdvisorCreateGP", connection);
            gradplan.CommandType = System.Data.CommandType.StoredProcedure;

            gradplan.Parameters.Add(new SqlParameter("@Semester_code", SemCode));
            gradplan.Parameters.Add(new SqlParameter("@expected_graduation_date", ExpGradDate.Date));
            gradplan.Parameters.Add(new SqlParameter("sem_credit_hours", SemCredH));
            gradplan.Parameters.Add(new SqlParameter("@advisor_id", AdvID));
            gradplan.Parameters.Add(new SqlParameter("@student_id",  StuID ));

            connection.Open();

            int affected = gradplan.ExecuteNonQuery();
            connection.Close();

            if (affected > 0)
            {
                Response.Write("Inserted successfully");
            }
            else
            {
                Response.Write("Not Inserted");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("adv_access.aspx");
        }
    }
}