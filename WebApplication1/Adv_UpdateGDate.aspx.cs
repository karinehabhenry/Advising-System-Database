using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class Adv_UpdateGDate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);


            DateTime ExpGradDate = DateTime.Parse(TextBox1.Text);
            if (!Int32.TryParse(TextBox2.Text, out int StudentID))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }



            SqlCommand UGradDate = new SqlCommand("Procedures_AdvisorUpdateGP", connection);
            UGradDate.CommandType = System.Data.CommandType.StoredProcedure;

           
            UGradDate.Parameters.Add(new SqlParameter("@expected_grad_date", ExpGradDate.Date));
            UGradDate.Parameters.Add(new SqlParameter("@studentID", StudentID));


            connection.Open();

            int affected =UGradDate.ExecuteNonQuery();
            connection.Close();

            if (affected > 0)
            {
                Response.Write("Updated Successfully!");
            }
            else
            {
                Response.Write("Not Updated");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("adv_access.aspx");
        }

       
    }
}