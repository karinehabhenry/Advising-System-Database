using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdvReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void reg_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

            string Name = advn.Text;
            string Password = advpass.Text;
            string Mail = advmail.Text;
            string Office = advoff.Text;

            SqlCommand advReg = new SqlCommand("Procedures_AdvisorRegistration", connection);
            advReg.CommandType = System.Data.CommandType.StoredProcedure;

            advReg.Parameters.Add(new SqlParameter("@advisor_name", Name));
            advReg.Parameters.Add(new SqlParameter("@password", Password));
            advReg.Parameters.Add(new SqlParameter("email", Mail));
            advReg.Parameters.Add(new SqlParameter("@office", Office));
           

            SqlParameter reg =  advReg.Parameters.Add("@Advisor_id", SqlDbType.Int);
            reg.Direction = ParameterDirection.Output;
           
            connection.Open();
            advReg.ExecuteNonQuery(); 
            int AdvId = Convert.ToInt32(reg.Value);
           
            Response.Write("Your ID is  ");
            Response.Write(AdvId);
            Response.Write("    Please Go To Login Page");
            connection.Close();



        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorLogin.aspx");
        }
    }
}