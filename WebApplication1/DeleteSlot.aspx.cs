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
    public partial class DeleteSlot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

            string semestercode = TextBox1.Text;



            SqlCommand Procedures_AdminDeleteSlots = new SqlCommand("Procedures_AdminDeleteSlots", connection);
            Procedures_AdminDeleteSlots.CommandType = System.Data.CommandType.StoredProcedure;

            Procedures_AdminDeleteSlots.Parameters.Add("@current_semester", semestercode);


            connection.Open();
            int affected= Procedures_AdminDeleteSlots.ExecuteNonQuery();
            connection.Close();

            if (affected > 0)
            {
                Response.Write("Slot deleted successfully");
            }
            else
            {
                Response.Write("Not deleted");
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