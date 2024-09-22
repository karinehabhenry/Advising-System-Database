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
    public partial class addPhone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

            string mobile = TextBox2.Text;
            
            if (!Int32.TryParse(TextBox1.Text, out int id))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }

            int userName = (int)Session["user"];
            if(mobile==""){
                Response.Write("enter mobile number");
                

            }
            
            if (id == userName && mobile!="")
            {

                SqlCommand StuPH = new SqlCommand("Procedures_StudentaddMobile", connection);
                StuPH.CommandType = System.Data.CommandType.StoredProcedure;
                StuPH.Parameters.Add(new SqlParameter("@StudentID", id));
                StuPH.Parameters.Add(new SqlParameter("@mobile_number", mobile));


                connection.Open();
                int affected= StuPH.ExecuteNonQuery();
                connection.Close();

                if (affected > 0)
                {
                    Response.Write("Mobile phones added Successfully!");
                }
                else
                {
                    Response.Write("Mobile Phone Not Added");
                }

            }
            else
                if(mobile!="")
                Response.Write("Enter your ID");
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