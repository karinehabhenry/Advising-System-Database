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
    public partial class AdminIssuingInstallment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);


            
            if (!Int32.TryParse(TextBox1.Text, out int pid))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }

            SqlCommand Procedures_AdminIssueInstallment = new SqlCommand("Procedures_AdminIssueInstallment", connection);

            Procedures_AdminIssueInstallment.CommandType = System.Data.CommandType.StoredProcedure;
            Procedures_AdminIssueInstallment.Parameters.Add(new SqlParameter("@payment_id", pid));
            connection.Open();
            int affected = Procedures_AdminIssueInstallment.ExecuteNonQuery();
            connection.Close();

            if (affected > 0)
            {
                Response.Write("Payment issued successfully!");
            }
            else
            {
                Response.Write("Payment Not Issued");
            }
        }
    

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Access.aspx");
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");

        }
    }
}