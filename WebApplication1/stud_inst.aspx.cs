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
    public partial class stud_inst : System.Web.UI.Page
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


            SqlCommand ss = new SqlCommand("SELECT dbo.FN_StudentUpcoming_installment(@student_ID)", connection);

            ss.Parameters.Add(new SqlParameter("@student_ID", sid));

            connection.Open();
            
            string d = ss.ExecuteScalar().ToString();
            DateTime dd = DateTime.Parse(d);

            string fd = dd.ToString("dd/MM/yyyy");

            Response.Write(fd);

            connection.Close();
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