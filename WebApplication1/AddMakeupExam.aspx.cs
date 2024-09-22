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
    public partial class AddMakeupExam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

            string type = TextBox1.Text;

            DateTime date = DateTime.Parse(TextBox2.Text);
           

            if (!Int32.TryParse(TextBox3.Text, out int cID))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }




            SqlCommand Procedures_AdminAddExam = new SqlCommand("Procedures_AdminAddExam", connection);
            Procedures_AdminAddExam.CommandType = System.Data.CommandType.StoredProcedure;

            Procedures_AdminAddExam.Parameters.Add("@Type", type);
            Procedures_AdminAddExam.Parameters.Add("@date", date);
            Procedures_AdminAddExam.Parameters.Add("@courseID", cID);
            

            connection.Open();
            int affected=  Procedures_AdminAddExam.ExecuteNonQuery();
            connection.Close();


            if (affected > 0)
            {
                Response.Write("Makeup Exam added Successfully!");
            }
            else
            {
                Response.Write("Makeup Exam Not Added");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Access.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}